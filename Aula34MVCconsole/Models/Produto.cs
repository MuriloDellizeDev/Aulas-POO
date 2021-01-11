using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


//INICIE PELO MODEL ELE DA A BASE PARA O PROGRMA

namespace Aula34MVCconsole.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public const string PATHARCHIVE = "Database/Produto.csv";

        public Produto(int _codigo, string _nome, double _preco)
        {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this.Preco = _preco;
        }

        public Produto() {
            
        }

        public List<Produto> Ler() {
            List<Produto> produtos = new List<Produto>();
            string[] linhas = File.ReadAllLines(PATHARCHIVE);

            foreach(string linha in linhas) {
                string[] dado = linha.Split(";");
                Produto produto = new Produto( Int32.Parse(dado[0]), dado[1], Double.Parse(dado[2]) );
                produtos.Add(produto);
            }

            produtos=produtos.OrderBy(produto=>produto.Nome).ToList();

            return produtos;
        }
    }
}