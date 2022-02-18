using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores.De.Acesso.Lib
{
    public class Carro : Veiculo
    {
        byte qtdRodas = 4 ; 


        public void InforCarro()
        {
            modelo = "Gol";
            marca = "VW";
            nome = "eu";
        }

    }
}
