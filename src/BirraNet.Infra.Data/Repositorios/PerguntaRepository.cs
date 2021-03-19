using BirraNet.Infra.Data.Contexto;
using BirraNet.Infra.Data.Entidades;
using System.Collections.Generic;
using System.Linq;

namespace BirraNet.Infra.Data.Repositorios
{
    public class PerguntaRepository : IPerguntaRepository
    {
        private readonly DataContext _contexto;
        
        public PerguntaRepository(DataContext dataContext)
        {
            _contexto = dataContext;
        }
        public PerguntaEntity BuscarPorId(int id) => _contexto.Perguntas.Find(id);

        public PerguntaEntity BuscarProximaPergunta(int id, string respostaPai) => _contexto.Perguntas
            .FirstOrDefault(pergunta => pergunta.PerguntaPai.Id == id
                            && pergunta.RespostaPai.ToLower() == respostaPai.ToLower());

        public IEnumerable<PerguntaEntity> BuscarTodos() => _contexto.Perguntas;


    }
}
