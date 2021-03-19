using BirraNet.Application.ViewModels;
using System.Collections.Generic;

namespace BirraNet.Application.Service
{
    public interface IPerguntaAppService
    {
        IEnumerable<PerguntaViewModel> BuscarTodos();
        PerguntaViewModel BuscarPorId(int id);
        PerguntaViewModel BuscarProximaPergunta(int idRespostaPai, string respostaPai);
    }
}
