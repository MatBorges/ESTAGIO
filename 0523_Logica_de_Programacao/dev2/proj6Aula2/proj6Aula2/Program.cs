using System;
using System.Globalization;
namespace proj6Aula2{
    class Program{
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double A, B, C;
            Console.WriteLine($"Digite a primeira nota: ");
            A = double.Parse(Console.ReadLine());
            Console.WriteLine($"Digite a segunda nota: ");
            B = double.Parse(Console.ReadLine());
            Console.WriteLine($"Digite a terceira nota: ");
            C = double.Parse(Console.ReadLine());

            Console.WriteLine($"MÉDIA = {(((A * 2) + (B * 3) + (C * 5)) / 10).ToString("f1")}");
        }
    }
}
