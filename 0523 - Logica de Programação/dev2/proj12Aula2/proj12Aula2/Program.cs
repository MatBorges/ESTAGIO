using System;
using System.Globalization;

namespace proj12Aula2{
    class Program{
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            String pessoaUm, pessoaDois;
            String[] p1, p2;

            Console.WriteLine($"Informe o primeiro nome e idade da primeira pessoa: ");
            pessoaUm = Console.ReadLine();
            Console.WriteLine($"Informe o primeiro nome e idade da segunda pessoa: ");
            pessoaDois = Console.ReadLine();

            p1 = pessoaUm.Split(' ');
            p2 = pessoaDois.Split(' ');

            Console.WriteLine($"A idade média de {p1[0]} e {p2[0]} é {((float.Parse(p1[1]) + float.Parse(p2[1])) / 2)}");

        }
    }
}
