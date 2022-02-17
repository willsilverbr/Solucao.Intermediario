using System;

namespace _02.Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Revisando Os metodos com parametros e sem parametros
            Pessoa pessoa = new Pessoa();
            pessoa.setPosicao(20.5, 10.5);

            Console.WriteLine("Posição: "+ pessoa.PegaPosicao());

        }
    }
}
