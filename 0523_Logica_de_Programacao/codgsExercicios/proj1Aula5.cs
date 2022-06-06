using System;

namespace proj1Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] tam = Console.ReadLine().Split(' ');
            
            int[,] matriz = new int[int.Parse(tam[0]), int.Parse(tam[1])];

            for (int l = 0; l < int.Parse(tam[0]); l++)
            {
                String[] linha = Console.ReadLine().Split(' ');
                for (int c = 0; c < int.Parse(tam[1]); c++)
                {
                    matriz[l, c] = int.Parse(linha[c]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");
            for (int i = 0; i < int.Parse(tam[0]); i++){
                for (int i2 = 0; i2 < int.Parse(tam[1]); i2++)
                {
                    if (matriz[i, i2] < 0)
                    {
                        Console.WriteLine(matriz[i, i2]);
                    }
                }
            }
        }
    }
}
