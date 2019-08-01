using System;
using System.Globalization;
namespace CalculaRaio
{
    class Program
    {
       
        static void Main(string[] args)
        { 

            Console.Write("Entre com o valor do Raio :");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
            double circ = Calculadora.Circunferencia(raio);
            double volu = Calculadora.Volume(raio);


            Console.WriteLine("Circunfenrencia :" + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O volume do raio : " + volu.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi : " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

            
        }

       
         

    }
}
