using System;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {

            //For
            for (int i = 0; i <= 10; i++){
                Console.Write($"{i}, ");
            }

            //Vetor
            int[] vetorInt; //declara
            String[] nomes = ["Mateus", "Lucas", "João"];

            vetorInt = new int[5];  //instancia

            //Foreach
            foreach (String nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }
    }
}
