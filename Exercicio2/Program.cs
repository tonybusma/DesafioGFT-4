using System;

namespace Exercicio2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Informe quantos números serão inseridos no vetor: ");
            int numVetor = int.Parse(Console.ReadLine());

            int[] vetor = new int[numVetor];

            Console.WriteLine("Digite um número: ");
            vetor[0] = int.Parse(Console.ReadLine());

            for(int i = 1; i < numVetor; i++)
            {
                Console.WriteLine("Digite um número: ");
                int num = int.Parse(Console.ReadLine());

                foreach (int vet in vetor)
                {
                    if(num != vet)
                    {
                        if(num < vet)
                        {
                            vetor[i] = num;
                        }
                        
                    Array.Sort(vetor);
                    
                    }
                }
            }

            Console.WriteLine(vetor);
        }
    }
}
