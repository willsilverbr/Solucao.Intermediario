using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classe01
{
    class Pessoa
    {
        public string nome;
        public string sexo;
        public DateTime dataNascimento; 

        public string ResumoPessoa()
        {
            string resumo =  "Nome" + nome; ;
            resumo += "\nsexo: "+  sexo;
            resumo += "\nData de Nascimento: " + dataNascimento; 
            return resumo;
        }
    }
}
