using System;

namespace Pessoa.Encapsulamento.Aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Console.WriteLine("Digite o nome da pessoa: ");

            //pessoa.nome = Console.ReadLine();

            //Console.WriteLine("O nome é: " +  pessoa.nome);
            //Quando são publicas as informações

            pessoa.setNome(Console.ReadLine());
            Console.WriteLine("O nome é: " +  pessoa.getNome());
            // quando esta encapsulado usando get and set
        }
    }
}
