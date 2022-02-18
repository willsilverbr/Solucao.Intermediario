using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificadores.De.Acesso.Lib
{
    public class Veiculo
    {
        public string marca;
        protected string modelo; 
        private DateTime anofabricacao;
        internal string nome; 

        void infoVeiculo()
        {
            marca = "Fiat";
            Console.WriteLine(marca);

            modelo = "Palio";
            anofabricacao = new DateTime(0, 0, 2000);
            nome = "will";
        }
    }
}
