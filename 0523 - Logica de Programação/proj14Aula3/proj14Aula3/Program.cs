using System;
using System.Globalization;

namespace proj14Aula3{
    class Program{
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            String p1, p2, p3;

            Console.WriteLine("O seu animal é 'vertebrado' ou 'invertebrado'?: ");
            p1 = Console.ReadLine().ToLower();
            Console.WriteLine("O seu animal é um 'inseto', um 'mamifero', um 'inseto' ou um 'anelideo'");
            p2 = Console.ReadLine().ToLower();
            Console.WriteLine("O seu animal é um 'carnivoro', um 'onivoro', um 'herbivoro' ou um 'hematofogo'");
            p3 = Console.ReadLine().ToLower();

            if (p1 == "vertebrado"){
                if (p2 == "ave"){

                }
                else
                {
                    Console.WriteLine("Para a primeira palavra são permitidas apenas as palavras 'vertebrados' ou 'invertebrados'");
                }
            }
            
            else if (p1 == "invertebrado"){

            }

            else{
                Console.WriteLine("Para a primeira palavra são permitidas apenas as palavras 'vertebrados' ou 'invertebrados'");
            }
        }
    }
}
