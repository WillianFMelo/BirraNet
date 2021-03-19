using BirraNet.Infra.Data.Entidades;
using System.Collections.Generic;

namespace BirraNet.Infra.Data.Repositorios
{
    public interface IMensagemRepository
    {
        MensagemEntity BuscarPorId(int id);
        IEnumerable<MensagemEntity> BuscarTodas();
    }
}
