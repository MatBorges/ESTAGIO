using System;
using System.Globalization;
namespace proj10Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int segundos;

            Console.WriteLine($"Digite o tempo em segundos: ");
            segundos = int.Parse(Console.ReadLine());

            Console.WriteLine($"{}:{segundos / 60}:{}");
        }
    }
}
