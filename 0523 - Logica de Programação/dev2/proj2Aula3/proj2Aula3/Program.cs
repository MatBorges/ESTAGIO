using System;
using System.Globalization;

namespace proj2Aula3{
    class Program{
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            char associado;
            int idade;
            Console.WriteLine("Informe sua idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Você é aposentado(a)?: (s/n)");
            associado = char.Parse(Console.ReadLine());

            if (idade >= 65 || associado == 's'){
                if(idade >= 65){
                    Console.WriteLine($"Sua idade é de {idade}, Você possui desconto!!!");
                }
                else{
                    Console.WriteLine("Você tem desconto por ser associado!!");
                }
            }
            else{
                Console.WriteLine("Desculpe, mas você não é elegível para receber desconto!!");
            }
        }
    }
}
