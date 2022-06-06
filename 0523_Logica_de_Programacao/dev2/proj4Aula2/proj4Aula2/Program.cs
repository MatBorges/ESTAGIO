using System;
using System.Globalization;
namespace proj4Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double raio = double.Parse(Console.ReadLine()), pi = 3.14159;
            Console.WriteLine($"A={(pi * Math.Pow(raio, 2)).ToString("f4")}");
        }
    }
}
