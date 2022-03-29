using Exercicio1.interfaces;

namespace Exercicio1.entities
{

    public class CartaoBandeiraMaster : IPagamentoCartao
    {
       
        public string pagamentoCredito()
        {
            return "Pago com Master - Crédito.";
        }

        public string pagamentoDebito()
        {
            return "Pago com Master - Débito.";
        }

    }
    
}