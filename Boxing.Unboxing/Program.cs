using System;

namespace Boxing.Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //boxing pega um tipo armazenado em valor e converte-lo para referencia. 
            //Unboxing faz o processo inverso

            int a = 10;
            //Toda a estrutura herda de Value type 
            object b = a; //Boxing

            int c = (int)b; //Unboxing
        }
    }
}
