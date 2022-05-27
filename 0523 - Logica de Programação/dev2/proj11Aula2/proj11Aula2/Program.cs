using System;
using System.Globalization;
namespace proj11Aula2
{
    class Program{
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int quantia;
            Console.WriteLine("Informe a quantia em dinheiro:");
            quantia = int.Parse(Console.ReadLine());
            Console.WriteLine($"${quantia}");
            Console.WriteLine($"{(quantia / 100)} notas de $100,00");
            quantia %= 100;
            Console.WriteLine($"{(quantia / 50)} notas de $50,00");
            quantia %= 50;
            Console.WriteLine($"{(quantia / 20)} notas de $20,00");
            quantia %= 20;
            Console.WriteLine($"{(quantia / 10)} notas de $10,00");
            quantia %= 10;
            Console.WriteLine($"{(quantia / 5)} notas de $5,00");
            quantia %= 5;
            Console.WriteLine($"{(quantia / 2)} notas de $2,00");
            quantia %= 2;
            Console.WriteLine($"{quantia} notas de $1,00");           
        }
    }
}
