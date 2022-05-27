using System;
using System.Globalization;
namespace proj8Aula3
{
    class Program{
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            int num, menor;

            Console.WriteLine("Informe o Primeiro número: ");
            menor = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o Segundo número: ");
            num = int.Parse(Console.ReadLine());

            if (num < menor){
                menor = num;
            }

            Console.WriteLine("Informe o Terceiro número: ");
            num = int.Parse(Console.ReadLine());

            if (num < menor){
                menor = num;
            }

            Console.WriteLine($"O menor número digitado foi: {menor}");
        }
    }
}
