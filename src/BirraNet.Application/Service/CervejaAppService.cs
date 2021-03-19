using AutoMapper;
using BirraNet.Application.ViewModels;
using BirraNet.Infra.Data.Repositorios;
using System.Collections.Generic;

namespace BirraNet.Application.Service
{
    public class CervejaAppService : ICervejaAppService
    {
        private readonly IMapper _mapper;
        private readonly ICervejaRepository _cervejaRepository;

        public CervejaAppService(IMapper mapper ,ICervejaRepository cervejaRepository)
        {
            _mapper = mapper;
            _cervejaRepository = cervejaRepository;
        }

        public IEnumerable<CervejaViewModel> BuscarTodas()
        {
            return _mapper.Map<IEnumerable<CervejaViewModel>>(_cervejaRepository.BuscarTodas());
        }
    }
}
