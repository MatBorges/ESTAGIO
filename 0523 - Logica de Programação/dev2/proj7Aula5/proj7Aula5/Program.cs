using System;

namespace proj7Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas = int.Parse(Console.ReadLine()), colunas = int.Parse(Console.ReadLine());
            String[,] pelotao = new String[linhas, colunas];

            for (int l = 0; l < linhas; l++)
            {
                String[] fila = Console.ReadLine().Split(' ');
                for (int c = 0; c < colunas; c++)
                {
                    pelotao[l, c] = fila[c];
                }
            }

            int linhaEscolhida = (int.Parse(Console.ReadLine())) - 1;

            for (int l = 0; l < linhas; l++)
            {
                if (l == linhaEscolhida)
                {
                    Console.Write("\n");
                    Console.Write($"{pelotao[l, (colunas - 1)]} ");
                    for (int c = 0; c < (colunas - 1); c++)
                    {
                        Console.Write($"{pelotao[l, c]} ");
                    }                    
                }
                else
                {
                    Console.Write("\n");
                    for (int c = 0; c < colunas; c++)
                    {
                        Console.Write($"{pelotao[l, c]} ");
                    }
                }
            }
        }
    }
}
