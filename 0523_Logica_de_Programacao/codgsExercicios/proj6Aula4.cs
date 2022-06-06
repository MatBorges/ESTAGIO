using System;
using System.Globalization;

namespace proj6Aula4{
    class Program{
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            int n;
            double x;

            Console.Write("Quer fazer quantos casos de teste?: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++){
                x = 0;
                Console.WriteLine($"{i}° Caso--------------------- ");
                for (int i2 = 1; i2 <= 3; i2++){
                    Console.Write($"{i2}° Número: ");
                    x += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"A média é {(x / 3).ToString("f1")}");
            }
        }
    }
}
