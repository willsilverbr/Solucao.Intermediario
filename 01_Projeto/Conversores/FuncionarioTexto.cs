using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_projeto_01_.Model;

namespace _01_Projeto.Conversores
{
    class FuncionarioTexto
    {
        public static string ConverterParaTexto(Funcionario funcionario)
        {
            string texto = string.Format("{0},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}",
                 funcionario.nome,
                 funcionario.dataNascimento,
                 funcionario.telefone,
                 funcionario.CPF,
                 funcionario.RG,
                 funcionario.CEP,
                 funcionario.estado,
                 funcionario.cidade,
                 funcionario.endereco, 
                 funcionario.cargo,
                 funcionario.salario, 
                 funcionario.dataContratacao);
            return texto;
        }

        public static Funcionario ConverterTextoParaFuncionario(String Linha)
        {
            string[] elementos = Linha.Split(',');
            Funcionario Funcionario = new Funcionario();
            Funcionario.nome = elementos[0];
            Funcionario.dataNascimento = DateTime.Parse(elementos[1]);
            Funcionario.telefone = elementos[2];
            Funcionario.CPF = elementos[3];
            Funcionario.RG = elementos[4];
            Funcionario.CEP = int.Parse(elementos[5]);
            Funcionario.estado = elementos[6];
            Funcionario.cidade = elementos[7];
            Funcionario.endereco = elementos[8];
            Funcionario.cargo = elementos[9];
            Funcionario.salario = double.Parse(elementos[10]);
            Funcionario.dataContratacao = DateTime.Parse( elementos[11]);

            return Funcionario;

        }
    }
}
