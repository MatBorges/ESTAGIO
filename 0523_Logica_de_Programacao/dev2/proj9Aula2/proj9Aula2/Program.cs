using System;
using System.Globalization;
namespace proj9Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            int tempoGasto, velocidadeMedia;
            double distancia, consumo;

            Console.WriteLine($"Quanto tempo durou a viagem?: ");
            tempoGasto = int.Parse(Console.ReadLine());
            Console.WriteLine($"Qual a velocidade média");
            velocidadeMedia = int.Parse(Console.ReadLine());

            distancia = tempoGasto * velocidadeMedia;
            consumo = distancia / 12;

            Console.WriteLine($"Você gastou {(consumo.ToString("f3"))} litros de combustivel");
        }
    }
}
