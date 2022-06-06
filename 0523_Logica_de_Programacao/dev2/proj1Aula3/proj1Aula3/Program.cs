using System;
using System.Globalization;
namespace proj1Aula3
{
    class Program
    {
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;            
            float nota;
            Console.WriteLine($"Digite a nota do aluno: ");
            
            nota = float.Parse(Console.ReadLine());

            if (nota < 6){
                Console.WriteLine($"Nota {nota.ToString("f2")}, Reprovado!");
            }
            else{
                Console.WriteLine($"Nota {nota.ToString("f2")}, Aprovado!!");
            }
        }
    }
}
