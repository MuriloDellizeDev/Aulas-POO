using System.Collections.Generic;

namespace Aula31WhatsAap
{
    public interface IAgenda
    {
        void Cadastrar(Contato cont);

         void Excluir(Contato cont);
         
         List<Contato> Listar();

    }
}