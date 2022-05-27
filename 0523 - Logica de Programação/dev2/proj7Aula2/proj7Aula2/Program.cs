using System;
using System.Globalization;
namespace proj7Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, D;

            Console.WriteLine($"Informe o primeiro número: ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine($"Informe o segundo número: ");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine($"Informe o terceiro número: ");
            C = double.Parse(Console.ReadLine());
            Console.WriteLine($"Informe o quarto número: ");
            D = double.Parse(Console.ReadLine());

            Console.WriteLine($"DIFERENÇA = {(A * B) - (C * D)}");
        }
    }
}
