using System;
using System.Globalization;
namespace proj5Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            double A = double.Parse(Console.ReadLine()), B = double.Parse(Console.ReadLine());

            Console.WriteLine($"MEDIA = {(((A * 3.5) + (B * 7.5)) / 11).ToString("F5")}");
        }
    }
}
