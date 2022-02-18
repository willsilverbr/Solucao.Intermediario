using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Polimofirsmo
{
    class Carro :Veiculo, ITansporte
    {
        public void Andar()
        {
            Console.WriteLine("Carro Andando: ");
        }

    }
}
