using System;

namespace proj1Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TABUADA, digite um número: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++){
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }
    }
}
