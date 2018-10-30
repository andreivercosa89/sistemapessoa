using System;

namespace sistemapessoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();

            Console.WriteLine("Informe seu nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.WriteLine("Informe sua idade: ");
            pessoa.Idade = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n\nOla {0} sua idade e {1}", pessoa.Nome, pessoa.Idade);

        }
    }
}
