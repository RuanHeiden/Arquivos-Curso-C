using System;
using System.Globalization;
namespace ContaCorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcinario conta;
            conta = new Funcinario();

            Console.WriteLine("- - - - - Conta Corrente - - - - -");
      
            Console.Write("Nome :");
            conta.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            conta.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto :");
            conta.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("- - - - - - - - - - - - - - - - -"); 
            Console.WriteLine(conta.ToString());

            Console.Write("Digite a porcentagem par aumentar o salário :");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.AumentaSalario(porcent);

            Console.WriteLine(conta.ToString());



        }
    }
}
