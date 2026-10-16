using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qualidade_Teste_Software_Refatoracao_01
{
    public static class PedidoRepository
    {
        public static bool Salvar(Pedido pedido)
        {
            string stringConexao = @"Server=.\SQLEXPRESS;Database=EtecVendas;Trusted_Connection=True;";

            bool sucesso = true;

            try
            {
                using (SqlConnection conn = new SqlConnection(stringConexao))
                {
                    conn.Open();
                    string query = "INSERT INTO Pedido (Cliente, CPF, ValorBruto, Desconto, Acrescimo, ValorFinal, DataVenda) " +
                                   "VALUES (@cli, @cpf, @bruto, @desc, @acresc, @final, @data)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@cli", pedido.ClienteNome);
                        cmd.Parameters.AddWithValue("@cpf", pedido.ClienteCpf);
                        cmd.Parameters.AddWithValue("@bruto", pedido.ValorBruto);
                        cmd.Parameters.AddWithValue("@desc", pedido.Desconto());
                        cmd.Parameters.AddWithValue("@acresc", pedido.Acrescimo());
                        cmd.Parameters.AddWithValue("@final", pedido.ValorFinal());
                        cmd.Parameters.AddWithValue("@data", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                sucesso = false;
            }

            return sucesso;
        
        }
    }
}
