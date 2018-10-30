using System;
namespace sistemapessoa
{
    public class Pessoa
    {
        private string nome;
        private int idade;

        public string Nome{
            set { this.nome = value; }
            get { return this.nome; }
        }

        public int Idade{
            set { this.idade = value; }
            get { return this.idade; }
        }

        public Pessoa()
        {
        }
    }
}
