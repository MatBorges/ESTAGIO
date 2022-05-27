using System;
using System.Globalization;

namespace proj13Aula3{
    class Program{
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            float salario;

            Console.WriteLine("Salário: ");
            salario = float.Parse(Console.ReadLine());

            if (salario <= 0){
                Console.WriteLine("Salário inválido!!");
            }

            else if (salario > 2000.0){
                Console.WriteLine($"NOVO SALÁRIO : ${(salario + (salario * 0.04)).ToString("f2")}");
                Console.WriteLine($"REAJUSTE: +${(salario * 0.04).ToString("f2")}");
                Console.WriteLine($"EM PERCENTUAL 4%");
            }

            else if (salario <= 400.0)
            {
                Console.WriteLine($"NOVO SALÁRIO : ${(salario + (salario * 0.15)).ToString("f2")}");
                Console.WriteLine($"REAJUSTE: +${(salario * 0.15).ToString("f2")}");
                Console.WriteLine($"EM PERCENTUAL 15%");
            }

            else if ((salario > 400.0) && (salario <= 800.0))
            {
                Console.WriteLine($"NOVO SALÁRIO : ${(salario + (salario * 0.12)).ToString("f2")}");
                Console.WriteLine($"REAJUSTE: +${(salario * 0.12).ToString("f2")}");
                Console.WriteLine($"EM PERCENTUAL 12%");
            }

            else if ((salario > 800.0) && (salario <= 1200.0))
            {
                Console.WriteLine($"NOVO SALÁRIO : ${(salario + (salario * 0.1)).ToString("f2")}");
                Console.WriteLine($"REAJUSTE: +${(salario * 0.1).ToString("f2")}");
                Console.WriteLine($"EM PERCENTUAL 10%");
            }

            else if ((salario > 1200.0) && (salario <= 2000.0))
            {
                Console.WriteLine($"NOVO SALÁRIO : ${(salario + (salario * 0.07)).ToString("f2")}");
                Console.WriteLine($"REAJUSTE: +${(salario * 0.07).ToString("f2")}");
                Console.WriteLine($"EM PERCENTUAL 7%");
            }
        }
    }
}
