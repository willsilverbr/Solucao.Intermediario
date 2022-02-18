using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            VariasEntradas01(10, "Will" , "Ana", "Teste" , "Quantas entradas de dados eu quiser");
        }

        static void VariasEntradas01 (int idade, params string[] nomes)
        {

        }
    }
}
