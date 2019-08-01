using System;
using System.Globalization;

namespace CalculaRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret;
            ret = new Retangulo();    

            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Console.Write("Largura: ");
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA: " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
                
            Console.WriteLine("PERÍMETRO: " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL: " + ret.Diagonal().ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
