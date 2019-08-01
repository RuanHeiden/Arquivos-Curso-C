using System; 

namespace ExHotel{
    class Estudante{

        public string Nome { set; get; }
        public string Email { set; get; }

        public Estudante(string nome, string email) {
            Nome = nome;
            Email = email;
        }

        public override string ToString()
        {
            return Nome + ", " + Email;
        }

    }
}
