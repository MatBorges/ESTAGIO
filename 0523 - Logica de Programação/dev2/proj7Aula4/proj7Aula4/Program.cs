using System;

namespace proj7Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, maior = 0, posiMaior = 0;

            for(int i = 1; i <= 20; i++){
                Console.Write($"{i}° Valor: ");
                valor = int.Parse(Console.ReadLine());
                if(valor > maior){
                    maior = valor;
                    posiMaior = i;
                }
            }
            Console.WriteLine($"O maior número informado foi o {maior}, na {posiMaior}ª posição");
        }
    }
}
