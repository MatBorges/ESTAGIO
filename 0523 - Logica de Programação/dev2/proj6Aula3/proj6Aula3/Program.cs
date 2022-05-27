using System;
using System.Globalization;

namespace proj6Aula3
{
    class Program{
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            String login, senha;

            Console.WriteLine("Login:");
            login = Console.ReadLine();

            if (login == "1234"){
                Console.WriteLine("Senha:");
                senha = Console.ReadLine();
                if (senha == "9999"){
                    Console.WriteLine("Acesso autorizado!!");
                }
                else{
                    Console.WriteLine("Senha incorreta!!");
                }
            }
            else{
                Console.WriteLine("Login inválido!!");
            }
        }
    }
}
