using System;
using System.Globalization;
using objetoCompartilhado.Entities;

namespace objetoCompartilhado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Seu Nome :");
            string name = Console.ReadLine();
            Console.Write("Sua idade :");
            int idade = int.Parse(Console.ReadLine());
            Console.Write("Email :" );
            string email = Console.ReadLine();
            Console.Write("Sua senha :");
            string senha = Console.ReadLine();

            Usuario usuario = new Usuario(name, idade, email, senha);

            
            //Console.WriteLine(usuario.UserData(name, idade, email, senha).ToString(CultureInfo.InvariantCulture));
            
            Console.Write("Gostaria de receber email sobre produtos de sua preferencia ? (S/N)");
            string SNEmail = Console.ReadLine();
            if (SNEmail == "S" || SNEmail == "s" || SNEmail == "SIM")
            {
                Console.Write("A quantidade de produtos de preferencia ?");
                int n = int.Parse(Console.ReadLine());
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine($"Preferecia #{i}");
                    Console.WriteLine("O produto da sua preferencia ;");
                    string productPref = Console.ReadLine();
                    Console.WriteLine("O dia da semanha que você gostaria de receber o NewsLetter:(Segunda, Terça, Quarta, Quinta, Sexta, Sabado e Domingo)");
                    string dayPref = Console.ReadLine();

                    Newsletter Letters = new Newsletter(productPref, dayPref);
                    usuario.AddPreference(Letters); 
                } 
            }


            Console.WriteLine("< DADOS DE CADASTRO DE USUARIO >");
            Console.WriteLine();

            Console.WriteLine("Nome do usuario :" + usuario.Name);
            Console.WriteLine("Idade do usuario :" + usuario.Idade);
            Console.WriteLine("E-mail :" + usuario.Email);
            Console.WriteLine("Senha do usuario :" + usuario.Senha); 

            Console.WriteLine();
            
            Console.WriteLine("Produtos e data do NewsLetter cadastrados ;");
            Console.WriteLine(usuario.Data().ToString(CultureInfo.InvariantCulture));
            



        }
    }
}
