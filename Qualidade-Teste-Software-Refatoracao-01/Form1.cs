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


        public Form1()
        {
            InitializeComponent();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.ClienteNome = txtClienteNome.Text;
            pedido.ClienteCpf = txtClienteCpf.Text;
            pedido.ClienteTipo = cmbTipoCliente.Text;
            pedido.ValorBruto = Convert.ToDecimal(txtValorBruto.Text);
            pedido.Pix = rbPix.Checked;
            pedido.Dinheiro = rbDinheiro.Checked;
            pedido.Cartao = rbCartaoCredito.Checked;
            pedido.Parcelas = (int)numParcelas.Value;
            
            string retorno = PedidoValidador.Validar(pedido);

            if (!string.IsNullOrEmpty(retorno))
            {
                MessageBox.Show(retorno);
                return;
            }

            decimal valorFinal = pedido.ValorFinal();

            PedidoRepository.Salvar(pedido);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
