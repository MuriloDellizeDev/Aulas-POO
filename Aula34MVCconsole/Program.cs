

using System;
using Aula34MVCconsole.Controllers;

namespace Aula34MVCconsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            //usa o controller pq ele tem acesso à todas as classes. 
            //Ele é o controlador == (o garçom) , o que transita com as requisições ou pedidos entre a view e o model.
            ProdutoController controller = new ProdutoController();
            controller.Listar();
        }
    }
}

