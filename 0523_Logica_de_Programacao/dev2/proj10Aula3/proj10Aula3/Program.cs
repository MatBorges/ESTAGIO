using System;
using System.Globalization;

namespace proj10Aula3{
    class Program{
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            int dia;

            Console.WriteLine("Informe o dia da semana: ");
            dia = int.Parse(Console.ReadLine());
            if (dia == 1){
                Console.WriteLine("Dia da semana: Domingo");
            }

            else if (dia == 2){
                Console.WriteLine("Dia da semana: Segunda");
            }

            else if (dia == 3)
            {
                Console.WriteLine("Dia da semana: Terça");
            }

            else if (dia == 4){
                Console.WriteLine("Dia da semana: Quarta");
            }

            else if (dia == 5){
                Console.WriteLine("Dia da semana: Quinta");
            }
            else if (dia == 6){
                Console.WriteLine("Dia da semana: Sexta");
            }

            else if (dia == 7){
                Console.WriteLine("Dia da semana: Sábado");
            }

            else{
                Console.WriteLine("Dia da semana: Inváido!!!!");
            }
        }
    }
}
