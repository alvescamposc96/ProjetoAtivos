using System;
using System.IO;

namespace ProjetoAtivos
{
    class Program
    {
        static void Main(string[] args)
        {
           //

            bool controle = true;
            while (controle == true)
            {
                Ativo.AdicionaAtivo();

               
                Console.WriteLine("Deseja adicionar mais um ativo? Sim ou Nao");
               String resposta = Console.ReadLine();


                if (resposta=="Nao")
                {
                    Console.WriteLine("Programa encerrado");
                    controle = false;
                }
                //Método para limpar o Console a cada inserção
                Console.Clear();


            }
            foreach (var item in Ativo.ListaDeAtivos)
            {


                StreamWriter sw = File.AppendText("c:\\arquivo.txt");
                sw.WriteLine($"Ativo: {item.Nome}  \nEmissor: {item.Emissor.Nome} \nQuantidade: {item.Quantidade} \nPrecoUnitario: {item.PrecoUnitario}  \n  " );
                sw.Close();
            }
        }
    }
}
