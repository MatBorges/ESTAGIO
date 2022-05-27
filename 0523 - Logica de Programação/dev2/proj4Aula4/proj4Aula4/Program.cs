using System;
using System.Globalization;

namespace proj4Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Digite um número: ");
            int x = int.Parse(Console.ReadLine());

            for(int i = 0; i < x; i++){
                if((i % 2) != 0){
                    Console.WriteLine(i);
                }
            }
        }
    }
}
