using System;

namespace Aula24ObjetosComArgumentos
{
    class Program
    {
        static void Main(string[] args)
        {

            //Criamos alguns produtos
           Produto p1 = new Produto(1, "Read Dead Redemption 2", 499f);
           Produto p2 = new Produto(2, "GTA V", 56.90f);
           Produto p3 = new Produto(3, "Detroit Become Human", 120.50f);
           Produto p4 = new Produto(4, "Celeste", 22.99f);

            // Adicionamos ao carrinho
           Carrinho carrinho = new Carrinho();
           carrinho.AdicionarProdutos(p1);
           carrinho.AdicionarProdutos(p2);
           carrinho.AdicionarProdutos(p3);
           carrinho.AdicionarProdutos(p4);


            //Mostrar no carrinho
           carrinho.MostrarProduto();
           
        }
    }
}
