using System;
namespace sistemapessoa
{
    public class Pessoa
    {
        private string nome;

        public void setNome(string nome){
            this.nome = nome;
        } 

        public string getNome(){
            return this.nome;
        }

        public Pessoa()
        {
        }
    }
}
