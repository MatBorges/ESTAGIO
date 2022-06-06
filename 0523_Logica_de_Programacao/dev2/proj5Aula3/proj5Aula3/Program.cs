using System;
using System.Globalization;
namespace proj5Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;
            double qtdMor, qtdMac, pcMor, pcMac, totPreco, totPeso, desconto;
            Console.WriteLine("Bem vindo a quitanda do Joãozinho!!");
            Console.WriteLine("Tabela de Preços");
            Console.WriteLine("Morangos até 5KG: $2,50 p/KG, acima de 5KG: $2,20 p/KG");
            Console.WriteLine("Maçãs até 5KG: $1,80 p/KG, acima de 5KG: $1,50 p/KG");
            Console.WriteLine("Mais DESCONTO DE 10% para compras acima de 8KG ou $25,00 ;D");

            Console.WriteLine("Quantos KG de morangos vai levar hj?");
            qtdMor = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos KG de maçãs vai levar hj?");
            qtdMac = double.Parse(Console.ReadLine());

            //calcula preco total Morango
            if (qtdMor <= 0){
                pcMor = 0.0;
            }
            else if (qtdMor <= 5){
                pcMor = qtdMor * 2.5;
            }
            else{
                pcMor = qtdMor * 2.2;
            }

            //calcula preco total maçã
            if (qtdMac <= 0)
            {
                pcMac = 0.0;
            }
            else if (qtdMac <= 5)
            {
                pcMac = qtdMac * 1.8;
            }
            else
            {
                pcMac = qtdMac * 1.5;
            }

            //totais e desconto
            totPeso = qtdMac + qtdMor;
            totPreco = pcMor + pcMac;
            desconto = ((pcMor + pcMac) * 0.1);

            if (totPeso > 8.0 || totPreco > 25.0){
                Console.WriteLine($"Total:\nMorangos ${pcMor.ToString("f2")}\nMaçãs ${pcMac.ToString("f2")}");
                Console.WriteLine($"Total Final: ${totPreco.ToString("f2")} - ${desconto.ToString("f2")} (DESCONTO!!) = {(totPreco - desconto).ToString("f2")}");
            }
            else {
                Console.WriteLine($"Total:\nMorangos ${pcMor.ToString("f2")}\nMaçãs ${pcMac.ToString("f2")}");
                Console.WriteLine($"Total Final: ${totPreco.ToString("f2")}");
            }
        }
    }
}
