using System;
using System.Globalization;

namespace proj9Aula3{
    class Program{
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int minutos;

            Console.WriteLine("Informe quantos minutos foram usados: ");
            minutos = int.Parse(Console.ReadLine());

            if (minutos < 0){
                Console.WriteLine("Valor inválido!!");
            }
            else if (minutos <= 100){
                Console.WriteLine("Valor a pagar: $50.00");
            }
            else{
                minutos -= 100;
                Console.WriteLine($"Valor a pagar: ${(50 + (minutos * 2)).ToString("f2")}");
            }
        }
    }
}
