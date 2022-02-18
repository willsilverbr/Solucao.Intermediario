using System;
using Modificadores.De.Acesso.Lib;

namespace Modificadores.De.Acesso
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo veiculo = new Veiculo();
            Carro carro = new Carro();
            Caminhao caminhao = new Caminhao();
            string marcaCaminhao = "Volvo; ";
            string marcaCarro = "Chevrolet";
            caminhao.marca = marcaCaminhao;
            carro.marca =  marcaCarro;
            Console.WriteLine (veiculo.marca); 
           

            
                
        }
    }
}
