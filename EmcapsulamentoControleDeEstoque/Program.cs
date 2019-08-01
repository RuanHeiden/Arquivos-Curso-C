using System;
using System.Globalization;

namespace ControleEstoque
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 99);

            p.Nome = "v"; 

            Console.WriteLine(p.Nome);

            Console.WriteLine(p.Preco);

            Console.WriteLine(p.Quantidade);





        }
    }
}

