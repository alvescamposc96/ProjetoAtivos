using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtivos
{
     class Ativo
    {
        public String Nome { get; set; }

        public Emissor Emissor { get; set; }


        public int Quantidade { get; set; }

        public double PrecoUnitario { get; set; }




        public static List<Ativo> ListaDeAtivos = new List<Ativo>();
      



        public Ativo(String nome, Emissor emissor, int quantidade, double precoUnitario)
        {
            this.Nome = nome;
            this.Emissor = emissor;
            this.Quantidade = quantidade;
            this.PrecoUnitario = precoUnitario;

        }

        public static void AdicionaAtivo() {
            Console.WriteLine("Digite o nome do ativo:");
            String ativo = Console.ReadLine();

            Console.WriteLine("Digite o nome do emissor:");
            String emissor = Console.ReadLine();

            Console.WriteLine("Digite a quantidade:");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o preço unitário:");
            double precoUnitario = Convert.ToDouble(Console.ReadLine());


            Emissor emissorref = new Emissor(emissor);
            Ativo ativoref = new Ativo(ativo, emissorref, quantidade, precoUnitario);


            Ativo.ListaDeAtivos.Add(ativoref);


        }
        






        //ESSE SOBRESCREVE, NÃO SUBSTITUI
        /*TextWriter tw = new StreamWriter("c:\\arquivo.txt");
        tw.WriteLine($"Ativo: {ativoref.Nome}  \nEmissor: {emissorref.Nome} \nQuantidade: {ativoref.Quantidade} \nPrecoUnitario: {ativoref.PrecoUnitario}  \n  ");
        tw.Close();*/


        //QUANDO NÃO TEM LISTA E QUERO APENAS SALVAR EM UM ARQUIVO
        /*StreamWriter sw = File.AppendText("c:\\arquivo.txt");
        sw.WriteLine($"Ativo: {ativoref.Nome}  \nEmissor: {ativoref.Emissor.Nome} \nQuantidade: {ativoref.Quantidade} \nPrecoUnitario: {ativoref.PrecoUnitario}  \n  ");
            sw.Close();*/


    }
}
