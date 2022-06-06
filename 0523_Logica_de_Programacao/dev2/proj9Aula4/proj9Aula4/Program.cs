using System;

namespace proj9Aula4{
    class Program{
        static void Main(string[] args){
            int n, x, y, soma = 0;

            n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++){
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                if (x == y)
                {
                    //soma CONTINUA COM 0
                }

                else if (y < x)
                {
                    for (int i2 = (x - 1); i > y; i--)
                    {
                        if ((i % 2) != 0)
                        {
                            soma = soma + i;
                        }
                    }
                }

                else
                {
                    for (int i2 = (x + 1); i < y; i++)
                    {
                        if ((i % 2) == 1)
                        {
                            soma = soma + i;
                        }
                    }
                }

                Console.WriteLine
            }
        }
    }
}
