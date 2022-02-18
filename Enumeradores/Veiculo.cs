using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeradores.This.Base
{
    class Veiculo   
    {
        public Veiculo()
        { 
            Console.WriteLine("Contruindo Veiculo");
        }
        public Veiculo(int i)
        {
            Console.WriteLine("Construindo veiculo N:" + i);
        }
        public virtual void Andar()
        {
            Console.WriteLine("Veiculo andando");
        }

    }
}
