using System;

namespace proj4Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            int tam = int.Parse(Console.ReadLine());

            int[,] matriz = new int[tam, tam];

            for (int l = 0; l < tam; l++)
            {
                String[] linha = Console.ReadLine().Split(' ');
                for (int c = 0; c < tam; c++)
                {
                    matriz[l, c] = int.Parse(linha[c]);
                }
            }
            int soma = 0;
            for (int i = 0; i < tam; i++)
            {
                
                for (int i2 = 0; i2 < tam; i2++)
                {
                    if (i2 > i)
                    {
                        soma += matriz[i, i2];
                    }
                }                
            }
            Console.WriteLine(soma);
        }
    }
}
