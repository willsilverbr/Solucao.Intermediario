using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomizarExeption
{
    class MinhaExecp : Exception
    {
        string linhaDoErro;

        public void MinhaException(string linha) : base("Minha Exeption")
        {
            linhaDoErro = linha;


        }
    }
}
