using System;
using System.Globalization;

namespace proj11Aula3{
    class Program{
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int a, b, c, d;

            Console.WriteLine("Informe os valores de\nA:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("B:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("C:");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("D:");
            d = int.Parse(Console.ReadLine());


            if ((b > c) && (d > a)){
                if ((c + d) > (a + b)){
                    if ((c > 0) && (d > 0)) {
                        if ((a % 2) == 0) {
                            Console.WriteLine("Valores aceitos");
                        }

                        else{
                            Console.WriteLine("Valores não aceitos");
                        }
                    }

                    else
                    {
                        Console.WriteLine("Valores não aceitos");
                    }
                }

                else
                {
                    Console.WriteLine("Valores não aceitos");
                }
            }

            else
            {
                Console.WriteLine("Valores não aceitos");
            }
        }
    }
}
