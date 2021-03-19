using BirraNet.Infra.Data.Contexto;
using BirraNet.Infra.Data.Entidades;
using System.Collections.Generic;

namespace BirraNet.Infra.Data.Repositorios
{
    public class MensagemRepository : IMensagemRepository
    {
        private readonly DataContext _contexto;

        public MensagemRepository(DataContext dataContext)
        {
            _contexto = dataContext;
        }

        public MensagemEntity BuscarPorId(int id) => _contexto.Mensagens.Find(id);

        public IEnumerable<MensagemEntity> BuscarTodas() => _contexto.Mensagens;
    }
}
