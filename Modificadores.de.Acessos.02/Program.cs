using System;
using Modificadores.De.Acesso.Lib;

namespace Modificadores.de.Acessos._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Console.WriteLine(carro.marca);
        }
    }
}
