using System;
using System.Globalization;
namespace ExHotel
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudante[] vect = new Estudante[10];

            Console.WriteLine("-- H O T E L --");
            Console.WriteLine("Quantidade de estudante que iram alugar o hotel: ");
            int N = int.Parse(Console.ReadLine()); 

            for (int i = 0; i < N; i++ ) {
                Console.WriteLine("Estudante #" + (i + 1));

                Console.Write("Nome :");
                string nome = Console.ReadLine();

                Console.Write("E-mail :");
                string email = Console.ReadLine();

                Console.Write("Quarto :");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Estudante(nome, email); 
            }

            Console.WriteLine("-----------------------------");

            Console.WriteLine("Quartos ocupados: ");

            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }


        }
    }
}
