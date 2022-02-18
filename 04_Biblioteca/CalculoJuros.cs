using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Biblioteca
{
    public class CalculoJuros
    {
        public int Soma(int A, int B, int Resultado)
        {
            Resultado = A + B;
            return Resultado;
            Console.WriteLine("Apenas teste");
        }

        public int Soma(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
