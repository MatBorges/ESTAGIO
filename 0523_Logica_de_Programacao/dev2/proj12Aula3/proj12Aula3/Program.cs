using System;
using System.Globalization;

namespace proj12Aula3{
    class Program{
        static void Main(string[] args){
            CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

            int ini, fin;
            Console.WriteLine("Informe o horário em que o jogo iniciou: ");
            ini = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o horário em que o jogo acabou: ");
            fin = int.Parse(Console.ReadLine());

            if ((ini < 0) && (ini > 24) && (fin < 0) && (fin > 24)) {
                Console.WriteLine("Hora inválidas!!");
            }

            else{
                if (ini == fin){
                    Console.WriteLine($"O JOGO DUROU 24 HORAS");
                }
                else if (ini < fin){
                    Console.WriteLine($"O JOGO DUROU {fin - ini} HORAS");
                }
                else{
                    Console.WriteLine($"O JOGO DUROU {(24 - ini) + fin} HORAS");
                }
            }
        }
    }
}
