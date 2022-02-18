using System;

namespace PassarInformacoesPorReferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = 25;

            Console.WriteLine("Main . var valor: "+ valor);

            AlterarValor(valor);

            Console.WriteLine("Main . var valor: " + valor);

        }
        static void AlterarValor(double valor)
        {
            Console.WriteLine("AlterarValor > var valor" + valor);

            valor += 10;

            Console.WriteLine("AlterarValor > var valor" + valor);
        }
    }
}
