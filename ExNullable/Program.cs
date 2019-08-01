using System;
using System.Globalization;

namespace ExNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());// "GETValueOrDefault" pegar o valor padrao se o valor for null (double = 0)
            Console.WriteLine(y.GetValueOrDefault());


            Console.WriteLine(x.HasValue); //"HasValue" se não haver valor, informe como FALSE. 
            Console.WriteLine(y.HasValue);//"HasValue" se haver valor,Informe como TRUE.

            if (x.HasValue)// se for TRUE
                Console.WriteLine(x.Value);// imprimir
            else //se for FALSE 
                Console.WriteLine("X is null");// imprimir

            if (y.HasValue)// se for TRUE
                Console.WriteLine(y.Value);// imprimir
            else// se for False
                Console.WriteLine("Y is null");// imprimir


            Console.WriteLine();
            double a = x ?? 100;//a vai receber o valor de x, mas se o valor de x for null, o a vai receber 100.
            double b = y ?? 200;//b vai receber o valor de y, mas se o valor de y for null, o b vai receber 200.

            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
