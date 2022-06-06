using System;

namespace proj5Aula4{
    class Program{
        static void Main(string[] args){
            int n, x, contIn = 0, contOut = 0;

            Console.WriteLine("Quantos números vocês quer digitar?: ");
            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++){
                Console.Write($"{i}° Número: ");
                x = int.Parse(Console.ReadLine());
                if(x > 10 && x < 20){
                    contIn++;
                }
                else{
                    contOut++;
                }
            }
            Console.WriteLine($"{contIn} IN\n{contOut} OUT");
        }
    }
}
