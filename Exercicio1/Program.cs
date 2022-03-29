using System;
using Exercicio1.entities;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoBandeiraMaster master = new CartaoBandeiraMaster();
            CartaoBandeiraVisa visa = new CartaoBandeiraVisa();

            Console.WriteLine(visa.pagamentoCredito());
            Console.WriteLine(visa.pagamentoDebito());
            Console.WriteLine(master.pagamentoCredito());
            Console.WriteLine(master.pagamentoDebito());
        }
    }
}
