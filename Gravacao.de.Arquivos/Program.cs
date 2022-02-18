using System;
using System.IO;


namespace Gravacao.de.Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter arquivo = new StreamWriter("C:\\Users\\wills\\Deskto\\texto.txt");
            Console.WriteLine("olá mundo \n");
            Console.WriteLine("Meu primeiro arquivo gravado: ");

            Console.WriteLine("Arquivo gravado!");

            //Ler um arquivo
            string textoInput = File.ReadAllText("C:\\Users\\wills\\Deskto\\texto.txt");

            string[] linhas = File.ReadAllLines("C:\\Users\\wills\\Deskto\\texto.txt");
            //para ler todas as linhas e jogar no array de texto

            Console.WriteLine("Quantidade de Linhas:" + linhas.Length);

            foreach (string linha in linhas)
            {
                Console.WriteLine("Linha: " + linha);
            }

            Console.WriteLine(textoInput);

           

        }
    }
}
