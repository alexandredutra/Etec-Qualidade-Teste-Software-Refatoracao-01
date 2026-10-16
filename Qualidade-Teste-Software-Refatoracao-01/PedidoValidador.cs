using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qualidade_Teste_Software_Refatoracao_01
{
    public static class PedidoValidador
    {
        public static string Validar(Pedido pedido)
        {
            string retorno = "";

            if (string.IsNullOrWhiteSpace(pedido.ClienteNome))
                retorno = "Favor informar o nome";
            else if (string.IsNullOrWhiteSpace(pedido.ClienteCpf))
                retorno = "Favor informar o CPF";
            else if (pedido.ClienteCpf.Length != 11)
                retorno = "CPF inválido";
            else if (pedido.ValorBruto <=0)
                retorno = "Valor inválido!";

            return retorno;
        }
    }
}
