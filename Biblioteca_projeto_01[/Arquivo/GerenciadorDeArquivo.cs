using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Biblioteca_projeto_01_.Arquivo
{
    public class GerenciadorDeArquivo
    {
        public static void GravarArquivo(String nome, string Texto)
        {
            string caminho = "C:\\Users\\wills\\Documents\\Montreal Cursos\\C# Intermediario\\Solucao.Intermediario\\Gravar" + nome + "txt";

            if (File.Exists(caminho))
            {
                using (StreamWriter wr = File.AppendText(caminho))
                {
                    wr.WriteLine(Texto);
                }
            }
            else
            {
                  using (StreamWriter wr = new StreamWriter (caminho))
                {
                    wr.WriteLine(Texto);
                }
            }
        }

        public static string[] LerArquivo(String nome)
        {
            string caminho = "C:\\Users\\wills\\Documents\\Montreal Cursos\\C# Intermediario\\Solucao.Intermediario\\Gravar" + nome + "txt";
            return File.ReadAllLines(caminho);
        }
    }
}
