using System;
using System.Globalization;

namespace proj3Aula4{
    class Program{
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            float celsius, fahrenheit;
            String resp;
            while(true){
                Console.WriteLine("Digite a temperatura em Celsius:");
                celsius = float.Parse(Console.ReadLine());

                fahrenheit = (celsius * (9 / 5) + 32);

                Console.WriteLine($"{fahrenheit.ToString("f1")}ºF");

                Console.WriteLine("Deseja Repetir? (s/n)");
                resp = Console.ReadLine().ToLower();
                if (resp == "n"){
                    break;
                }
            }
        }
    }
}
