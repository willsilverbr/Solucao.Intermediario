using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estruturas
{
    struct Polegada
    {
        double centimetro;
        double polegada;

        public Polegada(double polegadas)
        {
            centimetro = 2.54;
            polegada = centimetro * polegadas; 
        }
        public double getPolegadaCentimetro()
        {
            return polegada; 
        }

    }
}
