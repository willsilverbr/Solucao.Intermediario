using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrutores.Intermediario
{
    class Pessoa
    {
        string Nome;
        string Sexo;
        DateTime DataNascimento;
        double Posicaox, Posicaoy; 

        public Pessoa(string nome, string sexo, DateTime dataNascimento, double x, double y)
        {
            nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Posicaox = x;
            Posicaoy = y;
        }

        
    }
}
