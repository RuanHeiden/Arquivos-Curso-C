using System;
using System.Globalization;
namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            conta p = new conta();

            Console.Write("Entre com o número da conta: ");
            int NumeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre com o titular da conta :");
            string Nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial(S/N) ?:");
            char SN = char.Parse(Console.ReadLine());
            double Valor = 0;
            int i = 1;
            while (i < 2) { 
                switch (SN) {
                    case 'S':
                        Console.WriteLine("Entre com valor de depósito inicial: ");
                        Valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        i++;
                        break; 
                    case 'N':
                        Valor = 0;
                        i++;
                        break;
                    default:
                        Console.Write("!!! Valor Invalido !!!");
                        Console.Write("Haverá depósito inicial(S/N) ?:");
                        SN = char.Parse(Console.ReadLine());
                        break;
                }
            }
            p.CriandoConta(NumeroConta, Nome, Valor);
            Console.WriteLine(p.DadosDaConta());
            Console.WriteLine("_____________________________________");

            i = 1;
            while (i < 2)
            {
                Console.WriteLine("Informe uma Operação");
                Console.WriteLine("DEPÓSITO (D) / SAQUE (S) / EXIT (E) ");
                char opc = char.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 'D':
                        Console.WriteLine("Entre um valor para depósito:");
                        Valor = double.Parse(Console.ReadLine());
                        p.Deposito(Valor);
                        Console.WriteLine(p.DadosDaConta());
                        break;
                    case 'S':
                        Console.WriteLine("Entre um para saque:");
                        Valor = double.Parse(Console.ReadLine());
                        p.Saque(Valor);
                        Console.WriteLine(p.DadosDaConta());
                        break;
                    case 'E':
                        Console.WriteLine("--------------------Exit----------------------");
                        i++;
                        break;
                    default:
                        Console.Write("!!! Valor Invalido !!!");
                        break;
                }
            }
        }
    }
}
