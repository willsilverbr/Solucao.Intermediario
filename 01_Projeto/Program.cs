using System;
using _01_Projeto.Telas;

namespace _01_Projeto

    //Programa de cadastro de funcionario e Cliente em Prompt e usando o Txt como banco
    //

{
    class Program
    {
        static void Main(string[] args)
        {
            ManterCliente telaCliente = new ManterCliente();
            ManterFuncionario telaFuncionario = new ManterFuncionario();
            int opcoes = 0;
            while (opcoes !=5)
            {
                Console.WriteLine("O que deseja Fazer?: " +
                              "\n *1 = Cadastrar Cliente," +
                              "\n *2 = Listar Cliente " +
                              "\n *3 = Cadastrar Funcionario" +
                              "\n *4 Listar Funcionário" +
                              "\n *5 = Fechar Programa");

                opcoes = int.Parse(Console.ReadLine());

              
                switch (opcoes)
                {
                    case 1:
                        
                        telaCliente.CadastrarCliente();
                        break;
                    case 2:
                        telaCliente.ListarClientes();
                        break;
                    case 3:
                        telaFuncionario.CadastrarFuncionario();
                        break;
                    case 4:
                        telaFuncionario.CadastrarFuncionario();
                        break;
                    default :
                        Console.WriteLine("Comando não encontrado! ");
                        break;

                }
            }
            
        }

    }
}
