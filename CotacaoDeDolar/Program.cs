using System;
using System.Globalization;

namespace CotacaoDeDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar ?: ");
            double contacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar ?: ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
             

            Console.Write(ConversorDeMoeda.Converter(contacao, quantia));


        }
    }
}
