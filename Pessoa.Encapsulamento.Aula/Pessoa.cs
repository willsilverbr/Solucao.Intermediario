using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoa.Encapsulamento.Aula
{
    class Pessoa
    {
        private string nome;
        string CEP;
        string endereco;
        string CPF;

        public void setNome(string nome)
        {
            nome = nome.Trim().ToUpper();
        }
        public string getNome()
        {
            Console.WriteLine(nome);
            return nome; 
        }
    }
}
