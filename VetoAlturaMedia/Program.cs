using System;
using System.Globalization;
namespace VetoAlturaMedia
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];// Criando vetor, \\ "vect" nome do vetor, "new double" o tipo do vetor, "[n]" quantidade de vetores, no caso a quantidade esta para se definida pelo "usuario"

            for (int i = 0; i < n; i++) {// i recebe 0. se i for menor do que "n" que vai ser 3, execute. "i++" adicione 1 no i
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++) {
                sum += vect[i];
            }

            double soma = sum / n;
            Console.WriteLine("A altura media é de "+ soma.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
