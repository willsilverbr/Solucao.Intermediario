using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca_projeto_01_.Model;

namespace _01_Projeto.Conversores
{
    class ClienteTexto
    {
        public static string ConverterParaTexto(Clientes cliente)
        {
           string texto = string.Format("{0},{2},{3},{4},{5},{6},{7},{8},",
                cliente.nome,
                cliente.dataNascimento,
                cliente.telefone,
                cliente.CPF,
                cliente.RG,
                cliente.CEP,
                cliente.estado,
                cliente.cidade,
                cliente.endereco);
            return texto;
        }

        public  static Clientes ConverterTextoParaClientes(String Linha)
        {
            string[] elementos = Linha.Split(',');
            Clientes clientes = new Clientes();
            clientes.nome = elementos[0];
            clientes.dataNascimento = DateTime.Parse(elementos[1]);
            clientes.telefone = elementos[2];
            clientes.CPF = elementos[3];
            clientes.RG = elementos[4];
            clientes.CEP = int.Parse(elementos[5]);
            clientes.estado = elementos[6];
            clientes.cidade = elementos[7];
            clientes.endereco = elementos[8];

            return clientes;

        }
    }
}
