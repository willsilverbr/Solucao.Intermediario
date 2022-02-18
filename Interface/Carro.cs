using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Carro : Veiculo, ITransporte
    {
        public void Mover(byte velocidade)
        {
            throw new NotImplementedException();
        }
    }
}
