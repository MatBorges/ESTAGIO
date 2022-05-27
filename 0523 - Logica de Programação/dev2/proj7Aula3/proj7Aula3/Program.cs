using System;
using System.Globalization;
namespace proj7Aula3{
    class Program{
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double n1, n2, media;
            Console.WriteLine("Nota 1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota 2: ");
            n2 = double.Parse(Console.ReadLine());
            
            media = (n1 + n2) / 2;

            if (media < 60.0){
                Console.WriteLine($"NOTA FINAL: {media.ToString("F1")}\nREPROVADO!!!!!!!!");
            }
            else{
                Console.WriteLine($"NOTA FINAL: {media.ToString("F1")}");
            }
        }
    }
}
