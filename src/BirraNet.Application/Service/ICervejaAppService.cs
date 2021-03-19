using BirraNet.Application.ViewModels;
using System.Collections.Generic;

namespace BirraNet.Application.Service
{
    public interface ICervejaAppService
    {
        IEnumerable<CervejaViewModel> BuscarTodas();
    }
}
