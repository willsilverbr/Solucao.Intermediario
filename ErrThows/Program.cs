using System;

namespace ErroThows
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pessoa pessoa = new Pessoa();
                pessoa.setCEP("ABC10");
            }

            catch (FormatException ForEx) //É a primeira verificação que será tratada
            {
                Console.WriteLine("Erro Format" + ForEx.Message);
            }

            catch (Exception ex) //Deve ser o ultimo tratamento
            {
                Console.WriteLine("Erro ex: " + ex.Message);
            }
            finally
            {
                //É muito usado quando você tem conexão com o banco de dados,
                //pois em caso de erro você fecha as conexão. 

                //É usado para finalizar as pendencias do try/catch
            }

           ////--------------------------Exemplo de Thorw exception---------------------------------------// 

           // Console.Write("Digite o numero 1 ");
           // string digitado = Console.ReadLine();

           // if (digitado == "1")
           // {
           //     Console.WriteLine("Correto!");
           // }
           // else
           // {
           //     //throw new Exception("O valor Digitado não é valido");
                

           //     Console.WriteLine("Errado!");



           // }
        }
    }
}
