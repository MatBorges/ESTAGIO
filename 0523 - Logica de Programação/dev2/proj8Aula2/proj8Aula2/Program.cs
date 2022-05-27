using System;

namespace proj8Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            int matricula, hrsTrabalhadas;
            double slrPorHora;
            Console.WriteLine($"Informe a matricula do funcionário: ");
            matricula = int.Parse(Console.ReadLine());
            Console.WriteLine($"Informe quantas horas o funcionário matricúla {matricula} trabalhou: ");
            hrsTrabalhadas = int.Parse(Console.ReadLine());
            Console.WriteLine($"Informo o salário por hora do funcionário {matricula}: ");
            slrPorHora = double.Parse(Console.ReadLine());

            Console.WriteLine($"O funcionário matricula {matricula} trabalhou {hrsTrabalhadas} hras esse mês e seu salário sera de ${(slrPorHora * hrsTrabalhadas).ToString("f2")}");
        }
    }
}
