using System;
using System.Globalization;

namespace proj2Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double largura, comprimento, preco;

            Console.WriteLine($"Informe a Largura do terreno: ");
            largura = double.Parse(Console.ReadLine());
            //Console.WriteLine(largura);
            Console.WriteLine($"Informe o comprimento do terreno: ");
            comprimento = double.Parse(Console.ReadLine());

            Console.WriteLine($"Agora nos informe o preço do metro²:");
            preco = double.Parse(Console.ReadLine());

            //OS RESULTADOS SÃO CALCULADOS NO PRINT!!
            Console.WriteLine($"A área do seu terreno é de {(largura * comprimento).ToString("f2")}m²");
            Console.WriteLine($"Preço total ${(preco * (largura * comprimento)).ToString("f2")}");
        }
    }
}
