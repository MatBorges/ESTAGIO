using System;
using System.Globalization;

namespace proj8Aula4{
    class Program{
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            int casos, qtdR, qtdC, qtdS = qtdC = qtdR = 0;
            double totCobaias = 0;
            String cob;
            String[] cobV;

            Console.Write("Informe quantos casos de teste foram feitos: ");
            casos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= casos; i++){
                Console.WriteLine($"No {i}º teste, quantas cobais foram usadas e qual o tipo Rato(R), Sapo ou Coelho");
                cob = Console.ReadLine().ToLower();
                cobV = cob.Split();

            }
            Console.WriteLine($"Foram usados {totCobaias} Cobaias em {casos} casos");
            Console.WriteLine($"{qtdR} Ratos, {((100 * qtdR) / totCobaias).ToString("f2")}%");
            Console.WriteLine($"{qtdS} Sapos, {((100 * qtdS) / totCobaias).ToString("f2")}%");
            Console.WriteLine($"{qtdC} Coelhos, {((100 * qtdC) / totCobaias).ToString("f2")}%");
        }
    }
}
