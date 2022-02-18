using System;

namespace Frequencia_Numeros.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 0;
            Console.WriteLine("Informe quantos números serão inseridos(informe um valor entre 1 e 2000):");
            int quantidadeValores = Convert.ToInt32(Console.ReadLine());

            if (quantidadeValores < 1 || quantidadeValores > 2000)
            {

                Console.WriteLine("Quantidade inserida é inválida! Tente novamente.");

            }
            else
            {

                int[] numeros = new int[quantidadeValores];
                for (int i = 0; i < quantidadeValores; i++)
                {

                    Console.WriteLine("Informe o número na posição " + i);
                    numeros[i] = Convert.ToInt32(Console.ReadLine());

                }

                Array.Sort(numeros);

                for (int i = 0; i < numeros.Length; i++)
                {

                    for (int j = 0; j < numeros.Length; j++)
                    {

                        if (numeros[i] == numeros[j])
                        {

                            cont++;

                        }
                    }

                    Console.Write(numeros[i] + " apareceu " + cont + " vez(es) \n");
                    cont = 0;
                }
            }

            Console.ReadKey();
        }
    }
}
