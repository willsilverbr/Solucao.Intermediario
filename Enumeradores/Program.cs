using System;
using Enumeradores.This.Base;

namespace Enumeradores
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();
            veiculo.Andar();
            
            Carro carro = new Carro(19);
            carro.Andar();
            Console.WriteLine("Estado Civil " + EstadoCivil.Solteiro);
        }
    }
}
