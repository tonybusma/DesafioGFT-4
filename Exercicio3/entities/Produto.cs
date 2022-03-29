namespace Exercicio3.entities
{
    public class Produto
    {
        public string descricao;
        public double valorReal;
        public string operacao;
        public double percentual;
        public double valorFinal;

        
        public Produto()
        {

        }
        public Produto(double valorReal, string operacao, double percentual)
        {
            this.valorReal = valorReal;
            this.operacao = operacao;
            this.percentual = percentual;
        }

        public double Calcular()
        {
            
            if(operacao == "acrescimo")
            {
                this.valorFinal = this.valorReal + (valorReal * (percentual / 100));

            }
            else if(operacao == "desconto")
            {
                this.valorFinal = this.valorReal - (valorReal * (percentual / 100));
            }

            return valorFinal;
        }
    }
}