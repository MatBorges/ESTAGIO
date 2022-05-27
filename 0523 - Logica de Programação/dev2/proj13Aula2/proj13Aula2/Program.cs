using System;
using System.Globalization;
namespace proj13Aula2{
    class Program{
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            String nomeComp, infoCompleta;
            int qtdQuartos;
            double precoProd;
            String[] infoCompletaV;

            Console.WriteLine($"Entre com seu nome completo: ");
            nomeComp = Console.ReadLine();
            Console.WriteLine($"Quantos quartos tem na sua casa?: ");
            qtdQuartos = int.Parse(Console.ReadLine());
            Console.WriteLine($"Entre com o preço de um produto: ");
            precoProd = double.Parse(Console.ReadLine());
            Console.WriteLine($"Entre com seu último nome, idade e altura (NA MESMA LINHA): ");
            infoCompleta = Console.ReadLine();

            infoCompletaV = infoCompleta.Split(' ');

            Console.WriteLine($"{nomeComp}");
            Console.WriteLine($"{qtdQuartos}");
            Console.WriteLine($"{precoProd}");
            Console.WriteLine($"{infoCompletaV[0]}");
            Console.WriteLine($"{infoCompletaV[1]}");
            Console.WriteLine($"{infoCompletaV[2]}");
        }
    }
}
