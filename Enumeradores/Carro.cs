using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeradores.This.Base
{
    class Carro : Veiculo
    {
        public Carro(int i) :  base(i)
        {
            Console.WriteLine("Construindo Carro");
        }
        public override void Andar()
        {
             base.Andar();
            // base é usado para se referenciar a clase pai
            Console.WriteLine("Carro Andando");
            
        }
    }
}
