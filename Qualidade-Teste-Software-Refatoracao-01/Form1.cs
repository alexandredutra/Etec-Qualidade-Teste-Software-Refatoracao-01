using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qualidade_Teste_Software_Refatoracao_01
{
    public partial class Form1 : Form
    {
        private string stringConexao = @"Server=.\SQLEXPRESS;Database=EtecVendas;Trusted_Connection=True;";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (txtClienteNome.Text == "" || txtClienteCpf.Text == "")
            {
                MessageBox.Show("Preencha o nome e o CPF!");
                return;
            }

            string cpfLimpo = txtClienteCpf.Text.Replace(".", "").Replace("-", "").Trim();
            if (cpfLimpo.Length != 11)
            {
                MessageBox.Show("CPF inválido!");
                return;
            }

            if (!decimal.TryParse(txtValorBruto.Text, out decimal valorBruto) || valorBruto <= 0)
            {
                MessageBox.Show("Valor inválido!");
                return;
            }

            decimal desconto = 0;
            if (cmbTipoCliente.Text == "Estudante")
            {
                desconto = valorBruto * 0.10m;
            }
            else if (cmbTipoCliente.Text == "VIP")
            {
                if (valorBruto > 200)
                    desconto = valorBruto * 0.15m;
                else
                    desconto = valorBruto * 0.05m;
            }
            else if (cmbTipoCliente.Text == "Comum")
            {
                desconto = 0;
            }

            // Acréscimo se for parcelado (outra regra)
            decimal acrescimo = 0;
            if (rbCartaoCredito.Checked && numParcelas.Value > 3)
            {
                acrescimo = valorBruto * 0.05m; // 5% de juros
            }

            decimal valorFinal = valorBruto - desconto + acrescimo;

            try
            {
                using (SqlConnection conn = new SqlConnection(stringConexao))
                {
                    conn.Open();
                    string query = "INSERT INTO Pedido (Cliente, CPF, ValorBruto, Desconto, Acrescimo, ValorFinal, DataVenda) " +
                                   "VALUES (@cli, @cpf, @bruto, @desc, @acresc, @final, @data)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cli", txtClienteNome.Text);
                        cmd.Parameters.AddWithValue("@cpf", cpfLimpo);
                        cmd.Parameters.AddWithValue("@bruto", valorBruto);
                        cmd.Parameters.AddWithValue("@desc", desconto);
                        cmd.Parameters.AddWithValue("@acresc", acrescimo);
                        cmd.Parameters.AddWithValue("@final", valorFinal);
                        cmd.Parameters.AddWithValue("@data", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }
                }

                lblResumo.Text = $"Total: R$ {valorFinal:F2} (Desc: R$ {desconto:F2} | Juros: R$ {acrescimo:F2})";
                MessageBox.Show("Pedido salvo com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de banco: " + ex.Message);
            }
        }
    }
}
