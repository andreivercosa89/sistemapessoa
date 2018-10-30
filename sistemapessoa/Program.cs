using System;

namespace sistemapessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Informe seu nome: ");
            pessoa.setNome(Console.ReadLine());

            Console.WriteLine("\n\nOla " + pessoa.getNome());
        }
    }
}
