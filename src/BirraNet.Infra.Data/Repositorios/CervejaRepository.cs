using BirraNet.Infra.Data.Contexto;
using BirraNet.Infra.Data.Entidades;
using System.Collections.Generic;

namespace BirraNet.Infra.Data.Repositorios
{
    public class CervejaRepository : ICervejaRepository
    {
        private DataContext _contexto;

        public CervejaRepository(DataContext contexto)
        {
            _contexto = contexto;
        }

        public IEnumerable<CervejaEntity> BuscarTodas() => _contexto.Cervejas;
    }
}
