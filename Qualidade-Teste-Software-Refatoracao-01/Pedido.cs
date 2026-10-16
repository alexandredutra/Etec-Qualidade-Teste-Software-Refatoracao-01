using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qualidade_Teste_Software_Refatoracao_01
{
    public class Pedido
    {
        public string ClienteNome { get; set; }
        public string ClienteCpf { get; set; }
        public string ClienteTipo { get; set; }
        public decimal ValorBruto { get; set; }
        public bool Dinheiro { get; set; }
        public bool Pix { get; set; }
        public bool Cartao { get; set; }
        public int Parcelas { get; set; }

        public decimal Desconto()
        {
            decimal desconto = 0;

            if (ClienteTipo == "Estudante")
            {
                desconto = ValorBruto * 0.10m;
            }
            else if (ClienteTipo == "VIP")
            {
                if (ValorBruto > 200)
                    desconto = ValorBruto * 0.15m;
                else
                    desconto = ValorBruto * 0.05m;
            }
            else if (ClienteTipo == "Comum")
            {
                desconto = 0;
            }

            return desconto;

        }

        public decimal Acrescimo()
        {
            decimal acrescimo = 0;

            if (Cartao && Parcelas > 3)
            {
                acrescimo = ValorBruto * 0.05m; // 5% de juros
            }

            return acrescimo;

        }

        public decimal ValorFinal()
        { 
            return ValorBruto - Desconto() + Acrescimo();
        }

        //somente para exemplo
        public decimal ValorFinal2 => ValorBruto - Desconto() + Acrescimo();

    }
}
