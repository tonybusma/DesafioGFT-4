using System;
using Exercicio3.entities;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produtoComAcrescimo = new Produto(1500, "acrescimo", 25);
            Produto produtoComDesconto = new Produto(2000, "desconto", 30);

            System.Console.WriteLine($"O produto custa {produtoComAcrescimo.valorReal} e com acréscimo de {produtoComAcrescimo.percentual}% ficou com o valor de ${produtoComAcrescimo.Calcular()}");
            System.Console.WriteLine($"O produto custa {produtoComDesconto.valorReal} e com desconto de {produtoComDesconto.percentual}% ficou com o valor de ${produtoComDesconto.Calcular()}");
        }
    }
}
