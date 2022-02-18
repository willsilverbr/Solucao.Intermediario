using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErroThows
{
    class Pessoa
    {
       private string nome;
       private string CEP;
       private string CPF;

        public void setCEP(string cep)
        {
            int resultado;

            if (int.TryParse(cep, out resultado)) //identifica se a tring possui numeros
            {
                //Valido
                CEP = cep; 
            }
            else
            {
                throw new Exception("CEP Invalido!");
            }
           

        }
    }
}
