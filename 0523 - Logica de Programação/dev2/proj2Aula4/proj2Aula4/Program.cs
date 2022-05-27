using System;
using System.Globalization;
namespace proj2Aula4
{
    class Program
    {
        static void Main(string[] args){

            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            int x, y, soma = 0;
            Console.WriteLine("Digite dois números para saber a soma dos número pares entre eles:\nPrimeiro número:");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Segundo número:");
            y = int.Parse(Console.ReadLine());

            if(x == y){
                //soma CONTINUA COM 0
            }

            else if(y < x){
                for (int i = (x - 1); i > y; i--)
                {
                    if ((i % 2) != 0)
                    {
                        soma = soma + i;
                    }
                }
            }

            else{
                for(int i = (x + 1); i < y; i++){
                    if((i % 2) == 1){
                        soma = soma + i;
                    }
                }
            }

            Console.WriteLine($"x = {x}, y = {y} a soma dos números impares entre eles é = {soma}");
        }
    }
}