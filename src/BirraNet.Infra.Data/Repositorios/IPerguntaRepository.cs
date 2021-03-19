using BirraNet.Infra.Data.Entidades;
using System.Collections.Generic;

namespace BirraNet.Infra.Data.Repositorios
{
    public interface IPerguntaRepository
    {
        PerguntaEntity BuscarPorId(int id);
        IEnumerable<PerguntaEntity> BuscarTodos();
        PerguntaEntity BuscarProximaPergunta(int id, string respostaPai);
    }
}
