using System.Collections.Generic;
using Aula37Eplayers.Models;

namespace Aula37Eplayers.Interfaces

{
    public interface IEquipe
    {
         void Create(Equipe e);

        List<Equipe> ReadAll();

        void Update(Equipe e);

        void Delete(int id);
    }
}