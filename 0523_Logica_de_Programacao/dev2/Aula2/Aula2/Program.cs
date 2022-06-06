using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            String frase;
            String[] palavras;
            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();
            palavras = frase.Split(' ');

            Console.WriteLine(palavras[2]);
            */
            //Console.WriteLine(frase[3]);

            String f, nome;
            String[] frase;
            int idade;
            char sexo;
            Console.WriteLine("Informe seu nome, idade e sexo: ");
            f = Console.ReadLine();
            frase = f.Split(' ');

            nome = frase[0];
            idade = int.Parse(frase[1]);
            sexo = char.Parse(frase[2]);

            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine($"Sexo: {sexo}");

        }
    }
}
