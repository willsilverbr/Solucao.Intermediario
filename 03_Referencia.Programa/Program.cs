using System;
using _03_Biblioteca;


namespace _03_Referencia.Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            int vla, vlb ;
            int resultado;
            CalculoJuros calc = new CalculoJuros();
            Console.WriteLine("Digite o primeiro valor");
            vla = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o Segundo valor");
            vlb = Convert.ToInt32(Console.ReadLine());
            resultado = Convert.ToInt32( calc.Soma(vla, vlb));
            Console.WriteLine("Digite o Segundo valor de A e B" + vla, vlb);
            Console.WriteLine("Resultado agora e Int" + vla, vlb);
        }
    }
}
