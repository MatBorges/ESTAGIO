using System;

namespace proj5Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] tam = Console.ReadLine().Split(' ');

            int[,] A = new int[int.Parse(tam[0]), int.Parse(tam[1])];
            int[,] B = new int[int.Parse(tam[0]), int.Parse(tam[1])];
            int[,] C = new int[int.Parse(tam[0]), int.Parse(tam[1])];

            for (int m = 1; m <= 2; m++)
            {
                for (int l = 0; l < int.Parse(tam[0]); l++)
                {
                    String[] numeros = Console.ReadLine().Split(' ');
                    for (int c = 0; c < int.Parse(tam[1]); c++)
                    {
                        if (m == 1)
                        {
                            A[l, c] = int.Parse(numeros[c]);
                        }
                        else
                        {
                            B[l, c] = int.Parse(numeros[c]);
                            C[l, c] = A[l, c] + B[l, c];
                        }
                    }
                }
            }

            for (int l = 0; l < int.Parse(tam[0]); l++)
            {
                for (int c = 0; c < int.Parse(tam[1]); c++)
                {
                    Console.Write($"{C[l, c]} "); 
                }
                Console.Write("\n");
            }

            //String[] nomes = { "Mateus", "Lucas", "João" };

            //foreach (var i in nomes)
            //{
            //    Console.WriteLine();
            //}
        }
    }
}
