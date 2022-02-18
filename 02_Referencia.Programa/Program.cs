using System;
using _04_Biblioteca;
namespace _02_Referencia.Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoJuros calc = new CalculoJuros();
            int a; int b;
            int resultado;
            Console.WriteLine("Digite dois valores para somar: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            resultado = calc.Soma(a, b);
            Console.WriteLine("Resultad: " + resultado);
            
        }
    }
}
