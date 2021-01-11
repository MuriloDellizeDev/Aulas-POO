using System.Collections.Generic;
using Aula37Eplayers.Models;

namespace Aula37Eplayers.Interfaces
{
    public interface INoticias
    {
        void Create(Noticias n);
        List<Noticias> ReadAll(); 
        void Update(Noticias n);
        void Delete(int IdNoticia);
    }
}