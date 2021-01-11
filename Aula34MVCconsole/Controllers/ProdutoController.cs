using Aula34MVCconsole.Models;
using Aula34MVCconsole.Views;

namespace Aula34MVCconsole.Controllers
{
    public class ProdutoController 
    {
        Produto produtoModel = new Produto();
        ProdutoView produtoView = new ProdutoView();

        
        ///   retorna ao view uma lista processada pelo model.
     
        public void Listar() {
            produtoView.MostrarNoConsole( produtoModel.Ler() );
        }
    }
}