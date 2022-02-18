using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_projeto_01_.Model;
using _01_Projeto.Conversores;
using Biblioteca_projeto_01_.Arquivo; 

namespace _01_Projeto.Telas
{
    class ManterCliente
    {
        
        public void CadastrarCliente()
        {
            Clientes cliente = new Clientes();

            Console.Clear();

            Console.WriteLine("Você na opção: 'Cadastrar Cliente'");

            Console.WriteLine("Nome");
            cliente.nome = Console.ReadLine();

            Console.WriteLine("Data De Nascimento");
            cliente.dataNascimento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Telefone");
            cliente.telefone = Console.ReadLine();

            Console.WriteLine("CPF");
            cliente.CPF = Console.ReadLine();

            Console.WriteLine("RG");
            cliente.RG = Console.ReadLine();

            Console.WriteLine("CEP (Digite Apenas Numeros): ");
            cliente.CEP = Convert.ToInt32( Console.ReadLine());

            Console.WriteLine("Estado");
            cliente.estado = Console.ReadLine();

            Console.WriteLine("Cidade");
            cliente.cidade = Console.ReadLine();

            GerenciadorDeArquivo.GravarArquivo("cliente", ClienteTexto.ConverterParaTexto(cliente));

        }
        public void ListarClientes()
        {
            Console.Clear();
            Console.WriteLine("Listagem de Clientes");

            string[] linhas = GerenciadorDeArquivo.LerArquivo("Cliente");

            foreach  (string linha in linhas)
            {
                Clientes clientes = Conversores.ClienteTexto.ConverterTextoParaClientes(linha);
                Console.WriteLine("Nome: " + clientes.nome);
                Console.WriteLine(linha);
            }

        }
    }
}
