using System;
using System.Globalization;

namespace proj8Aula4{
    class Program{
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            int casos, qtdR, qtdC, qtdS = qtdC = qtdR = 0;
            double qtdCobaias, totCobaias = 0;
            String strTipo;
            char tipo;

            Console.Write("Informe quantos casos de teste foram feitos: ");
            casos = int.Parse(Console.ReadLine());

            for (int i = 1; i <= casos; i++){
                Console.Write("Informe quantas cobaias foram usadas: ");
                qtdCobaias = int.Parse(Console.ReadLine());
                totCobaias += qtdCobaias; 
                

                while (true){
                    strTipo = Console.ReadLine().ToLower();
                    Console.WriteLine(strTipo);
                    if ((strTipo[0] == 'r') || (strTipo[0] == 's') || (strTipo[0] == 'c')){
                        switch(strTipo[0]){
                            case 'r':
                                qtdR++;
                            break;
                            case 's':
                                qtdS++;
                            break;
                            case 'c':
                                qtdC++;
                            break;
                        }
                        break;
                    }
                    else{
                        Console.WriteLine("Cobaia inválida, Cobaias Válidas: Rato, Sapo e Coelho");
                    }
                }
            }

            Console.WriteLine($"Foram usados {totCobaias} Cobaias em {casos} casos");
            Console.WriteLine($"{qtdR} Ratos, {((double)((100 * qtdR) / totCobaias)).ToString("f2")}%");
            Console.WriteLine($"{qtdS} Sapos, {((double)((100 * qtdS) / totCobaias)).ToString("f2")}%");
            Console.WriteLine($"{qtdC} Coelhos, {((double)((100 * qtdC) / totCobaias)).ToString("f2")}%");
        }
    }
}





//segunda solução

