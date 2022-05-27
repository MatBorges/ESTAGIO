using System;
using System.Globalization;

namespace proj3Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double baseT, alturaT, area, perimetro, diagonal;

            Console.WriteLine($"Informe a Base do Retângulo: ");
            baseT = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a altura do Retângulo: ");
            alturaT = double.Parse(Console.ReadLine());

            area = baseT * alturaT;

            Console.WriteLine(baseT);

            perimetro = 2 * baseT + 2 * alturaT;
            diagonal = Math.Sqrt((Math.Pow(baseT, 2)) + (Math.Pow(alturaT, 2)));

            
            Console.WriteLine($"Área: {area:f4}");
            Console.WriteLine($"Perimetro: {perimetro:f4}");
            Console.WriteLine($"Diagonal: {diagonal:f4}");            

        }
    }
}
