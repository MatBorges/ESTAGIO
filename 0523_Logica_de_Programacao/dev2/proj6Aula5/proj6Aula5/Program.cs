using System;
using System.Globalization;

namespace proj6Aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int tam = int.Parse(Console.ReadLine());            
            double[,] matriz = new double[tam, tam];
            double[] linha = new double[tam];
            double[] coluna = new double[tam];
            double soma = 0.0;
            for(int l = 0; l < tam; l++)
            {
                String[] numeros = Console.ReadLine().Split(' '); 
                for (int c = 0; c < tam; c++)
                {
                    matriz[l, c] = double.Parse(numeros[c]);
                    if (double.Parse(numeros[c]) > 0.0)
                    {
                        soma += double.Parse(numeros[c]);
                    }
                }
            }

            int lEscolhida = int.Parse(Console.ReadLine()), cEscolhida = int.Parse(Console.ReadLine());

            Console.WriteLine($"SOMA DOS POSITIVOS: {soma.ToString("f1")}");

            Console.Write($"LINHA ESCOLHIDA: ");
            for (int c = 0; c < tam; c++)
            {
                Console.Write($"{(matriz[lEscolhida, c]).ToString("F1")} ");
            }

            Console.Write($"\nCOLUNA ESCOLHIDA: ");
            for (int l = 0; l < tam; l++)
            {
                Console.Write($"{(matriz[l, cEscolhida]).ToString("F1")} ");                
            }

            Console.Write($"\nDIAGONAL PRINCIPAL: ");
            for (int l = 0; l < tam; l++)
            {
                for(int c = 0; c < tam; c++)
                {                    
                    if (l == c)
                    {
                        Console.Write($"{(matriz[l, c]).ToString("f1")} ");
                    }
                }
            }

            Console.Write($"\nMATRIZ ALTERADA: \n");
            for (int l = 0; l < tam; l++)
            {
                for(int c = 0; c < tam; c++)
                {
                    if (matriz[l, c] < 0)
                    {
                        Console.Write($"{(matriz[l, c] * matriz[l, c]).ToString("f1")} ");
                    }
                    else
                    {
                        Console.Write($"{(matriz[l, c]). ToString("f1")} ");
                    }
                }
                Console.Write($"\n");
            }
            
            //for (int c = 0; c < tam; c++)
            //{
            //    linha[c] = matriz[lEscolhida, c];
            //}

            //for (int l = 0; l < tam; l++)
            //{
            //    coluna[l] = matriz[l, cEscolhida];
            //}
        }
    }
}
