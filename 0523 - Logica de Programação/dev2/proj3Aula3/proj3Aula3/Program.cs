using System;
using System.Globalization;

namespace proj3Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            char estudante;
            int idade;
            Console.WriteLine("Informe sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Você é estudante?: (s/n)");
            estudante = char.Parse(Console.ReadLine());

            if (idade >= 65 || estudante == 's')
            {
                if (idade >= 65)
                {
                    Console.WriteLine($"Sua idade é de {idade}, Seu ingresso sai por apenas $15!!!");
                }
                else
                {
                    Console.WriteLine("Estudante paga meia, portanto $15 o ingresso!!!");
                }
            }
            else
            {
                Console.WriteLine("Uma inteira saindo!! apenas $30");
            }
        }
    }
}
