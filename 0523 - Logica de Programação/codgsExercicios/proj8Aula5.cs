using System;
using System.Globalization;

namespace proj8Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double[,] M = new double[5, 5];
            int linha = int.Parse(Console.ReadLine());
            char T = char.Parse(Console.ReadLine());

            for (int l = 0; l < 5; l++)
            {
                for (int c = 0; c < 5; c++)
                {
                    M[l, c] = double.Parse(Console.ReadLine());
                }
            }
            double soma = 0;
            if (T == 'S')
            {
                for (int c = 0; c < 5; c++)
                {
                    soma += M[linha, c];
                }
                Console.WriteLine($"{(soma).ToString("f1")}");
            }

            else
            {
                for (int c = 0; c < 5; c++)
                {
                    soma += M[linha, c];                    
                }
                Console.WriteLine($"{(soma = soma / 5).ToString("f1")}");
            }
        }
    }
}
