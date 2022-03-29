
using Exercicio1.interfaces;

namespace Exercicio1.entities
{
    public class CartaoBandeiraVisa : IPagamentoCartao
    {
        public string pagamentoCredito()
        {
            return "Pago com Visa - Crédito.";
        }

        public string pagamentoDebito()
        {
            return "Pago com Visa - Débito.";
        }
    }
    
}