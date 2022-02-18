using System;

namespace Interface.Polimofirsmo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            sobreVeiculo(carro);
            sobreTransporte(carro);
          
            
        }

        static void sobreVeiculo(Veiculo veiculo)
        {
            Console.WriteLine(veiculo.marca);
        }

        static void sobreTransporte(ITansporte transporte)
        {
            transporte.Andar();
        }
    }
}
