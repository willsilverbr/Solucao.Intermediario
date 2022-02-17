using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Metodos
{
    class Pessoa
    {
        public string nome;
        public string sexo;
        public DateTime dataNascimento;
        public double posicaoX, posicaoY;

        public string PegaPosicao()
        {
            return posicaoX + ", " + posicaoX;
        }
        public void setPosicao(double x, double Y)
        {
            posicaoX = x;
            posicaoY = Y;
        }
    }
}
