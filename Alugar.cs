using System;
namespace vetor_aluguel {
    class Alugar {

        public string Nome { get; set; }
        public string Email { get; set; }
        

        public Alugar(string nome, string email) {
            Nome = nome;
            Email = email;
        }

        public override string ToString() {
            return "Quarto: " 
                + "Nome: " 
                + Nome 
                + "E-mail: " 
                + Email;
        }
    }
}
