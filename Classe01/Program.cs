using System;

namespace Classe01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.nome = "William";
            pessoa.sexo = "H";
            pessoa.dataNascimento = new DateTime(1993, 05, 02);


            string texto = pessoa.ResumoPessoa();

            Console.Write(texto);
            

        }
    }
}
