using BirraNet.Infra.Data.Entidades;
using System.Collections.Generic;

namespace BirraNet.Infra.Data.Repositorios
{
    public interface ICervejaRepository
    {
        IEnumerable<CervejaEntity> BuscarTodas();
    }
}
  

