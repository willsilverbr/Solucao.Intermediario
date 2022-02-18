using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_projeto_01_.Arquivo;
using Biblioteca_projeto_01_.Model;
using _01_Projeto.Conversores;

namespace _01_Projeto.Telas

{
    class ManterFuncionario
    {
        public void CadastrarFuncionario()
        {
            
                Funcionario funcionario = new Funcionario();

                Console.Clear();

                Console.WriteLine("Você na opção: 'Cadastrar funcionario'");

                Console.WriteLine("Nome");
                funcionario.nome = Console.ReadLine();

                Console.WriteLine("Data De Nascimento");
                funcionario.dataNascimento = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("Telefone");
                funcionario.telefone = Console.ReadLine();

                Console.WriteLine("CPF");
                funcionario.CPF = Console.ReadLine();

                Console.WriteLine("RG");
                funcionario.RG = Console.ReadLine();

                Console.WriteLine("CEP (Digite Apenas Numeros): ");
                funcionario.CEP = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Estado");
                funcionario.estado = Console.ReadLine();

                Console.WriteLine("Cidade");
                funcionario.cidade = Console.ReadLine();
           
                Console.WriteLine("Salario");
                funcionario.salario = Convert.ToDouble( Console.ReadLine());

                Console.WriteLine("Data da Contratação");
                funcionario.dataContratacao = Convert.ToDateTime( Console.ReadLine());

            GerenciadorDeArquivo.GravarArquivo("cliente", FuncionarioTexto.ConverterParaTexto(funcionario));

             

        }

        public void ListarFuncionarios()
        {
            Console.Clear();

            Console.WriteLine("ListarFuncionarios de funcionarios");

            string[] linhas = GerenciadorDeArquivo.LerArquivo(
                "Funcionario");

            foreach (string linha in linhas)
            {
                Funcionario funcionario = Conversores.FuncionarioTexto.ConverterTextoParaFuncionario(linha);
                Console.WriteLine("Nome: " + funcionario.nome + "Cargo: " + funcionario.cargo);
            }

        }
    }
}
