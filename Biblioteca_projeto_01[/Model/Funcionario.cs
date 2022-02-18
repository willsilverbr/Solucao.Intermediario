using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca_projeto_01_.Model
{
    public sealed class Funcionario : Pessoa 
        //Seald Para que não tenha derivados dessa classe, ou seja,
        // essa classe herda de pessoas, mas nenhuma outra classe pode herdar de Clientes
    {
        public string cargo { get; set; }
        public double salario { get; set; }
        public DateTime dataContratacao { get; set; }
    }
}
