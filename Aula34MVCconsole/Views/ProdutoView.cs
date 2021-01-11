using System;
using System.Collections.Generic;
using Aula34MVCconsole.Models; //Colocamos a pasta onde se encontra a classe Produto.

namespace Aula34MVCconsole.Views
{
    public class ProdutoView 
    {
       
        //    Escreve no console dados sobre o produto.
       //           Uma lista de produtos.
        public void MostrarNoConsole(List<Produto> produtos) {
            foreach(Produto produto in produtos) {
                Console.WriteLine($"{produto.Nome} - {produto.Preco:c}");
            }
        }
    }
}