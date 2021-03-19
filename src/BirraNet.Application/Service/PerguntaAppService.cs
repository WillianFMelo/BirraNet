using AutoMapper;
using BirraNet.Application.ViewModels;
using BirraNet.Domain.Servicos;
using BirraNet.Infra.Data.Repositorios;
using System.Collections.Generic;

namespace BirraNet.Application.Service
{
    public class PerguntaAppService : IPerguntaAppService
    {
        private readonly IMapper _mapper;
        private readonly IPerguntaRepository _perguntaRepository;
        //private readonly IPerguntaDomainService _perguntaDomainService;

        public PerguntaAppService(IPerguntaRepository perguntaRepository, IMapper mapper)
        {
            _perguntaRepository = perguntaRepository;
            //_perguntaDomainService = perguntaDomainService;
            _mapper = mapper;
        }

        public PerguntaViewModel BuscarPorId(int id)
        {
            return _mapper.Map<PerguntaViewModel>(_perguntaRepository.BuscarPorId(id));
        }

        public PerguntaViewModel BuscarProximaPergunta(int idRespostaPai, string respostaPai)
        {
            return _mapper.Map<PerguntaViewModel>(_perguntaRepository.BuscarProximaPergunta(idRespostaPai, respostaPai));
        }

        public IEnumerable<PerguntaViewModel> BuscarTodos()
        {
            return _mapper.Map<IEnumerable<PerguntaViewModel>>(_perguntaRepository.BuscarTodos());
        }
    }
}
