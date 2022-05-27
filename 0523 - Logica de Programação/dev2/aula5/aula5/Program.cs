using System;

namespace aula5
{
    class Program
    {
        static void Main(string[] args)
        {
            int l, c;
            int[,] matriz;
            Console.WriteLine("Digite um número");
            String[] vetor = Console.ReadLine().Split(' ');
            Console.Write("Informe quantas linhas vai ter a sua matriz: ");
            l = int.Parse(Console.ReadLine());
            Console.Write("Informe quantas colunas tem sua matriz: ");
            c = int.Parse(Console.ReadLine());

            matriz = new int[l, c];

            for (int i = 0; i<l; i++){
                String[] s = Console.ReadLine().Split(' ');
                for (int i2 = 0; i2<c; i2++){
                    matriz[i, i2] = int.Parse(s[i2]);
                }
            }

            for (int i = 0; i<l; i++) {
                for (int i2 = 0; i2 < c; i2++) {
                    Console.WriteLine(matriz[i, i2]);
                }
            }
        }
    }
}
