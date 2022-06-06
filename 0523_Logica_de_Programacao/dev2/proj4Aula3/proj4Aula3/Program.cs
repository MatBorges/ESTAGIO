using System;
using System.Globalization;

namespace proj4Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            String combus;
            float qtd;
            Console.WriteLine("Bem vindo ao posto do joãozinho!!");
            while (true){
                Console.WriteLine("Quer abastecer com Álcool(a) ou Gasolina(g)? :");
                combus = Console.ReadLine();
                if (combus == "a"){
                    Console.WriteLine($"Vai por quantos litros hj meu patrão?: ");
                    qtd = int.Parse(Console.ReadLine());
                    if (qtd <= 0){
                        Console.WriteLine("Nada msm? se enganou?");
                    }

                    else if (qtd <= 20){
                        Console.WriteLine($"{qtd} litros de Álcool.. É pra já");
                        Console.WriteLine($"Pronto meu patrão.. deu {((qtd * 4.9) - ((qtd * 4.9) * 0.03)).ToString("f2")} com 3% de desconto chefia!!" );
                        break;
                    }
                    else{
                        Console.WriteLine($"{qtd} litros de Álcool.. É pra já");
                        Console.WriteLine($"Pronto meu patrão.. deu {((qtd * 4.9) - ((qtd * 4.9) * 0.05)).ToString("f2")} com 5% de desconto chefia!!");
                        break;
                    }                    
                }
                else if (combus == "g"){
                    Console.WriteLine($"Vai por quantos litros hj meu patrão?: ");
                    qtd = int.Parse(Console.ReadLine());
                    if (qtd <= 0)
                    {
                        Console.WriteLine("Nada msm? se enganou?");
                    }

                    else if (qtd <= 20)
                    {
                        Console.WriteLine($"{qtd} litros de Gasolina.. É pra já");
                        Console.WriteLine($"Pronto meu patrão.. deu {((qtd * 7.3) - ((qtd * 7.3) * 0.04)).ToString("f2")} com 4% de desconto chefia!!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{qtd} litros de Gasolina.. É pra já");
                        Console.WriteLine($"Pronto meu patrão.. deu {((qtd * 7.3) - ((qtd * 7.3) * 0.06)).ToString("f2")} com 6% de desconto chefia!!");
                        break;
                    }
                }
                else{
                    Console.WriteLine("Acho que você se enganou, não trabalhamos com esse tipo de combustível :(");
                }
            }
        }
    }
}
