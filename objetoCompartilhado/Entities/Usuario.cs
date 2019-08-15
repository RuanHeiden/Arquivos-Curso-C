using System;
using System.Collections.Generic;
using System.Text;

namespace objetoCompartilhado.Entities
{
    class Usuario
    {

        public string Name { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public List<Newsletter> Letters { get; set; } = new List<Newsletter>();

        public Usuario()
        {
        }

        public Usuario(string name, int idade, string email, string senha)
        {
            Name = name;
            Idade = idade;
            Email = email;
            Senha = senha;
        }

        public void AddPreference(Newsletter Letter)
        {
            Letters.Add(Letter);
        }
        public void RenivePreference(Newsletter Letter)
        {
            Letters.Remove(Letter);
        }

        public string Data()
        {
            string ReturnNews = "";
            StringBuilder sb = new StringBuilder();
            foreach (Newsletter letter in Letters)
             {
                 ReturnNews = letter.ValueNewsletter();
                 sb.AppendLine(ReturnNews);
                 sb.AppendLine("");
             }
              
            return sb.ToString();



        }
    }
}
