using AutoMapper;
using BirraNet.Application.ViewModels;
using BirraNet.Infra.Data.Entidades;

namespace BirraNet.Application.AutoMapper
{
    public class ViewModelToEntityProfile : Profile
    {
        public ViewModelToEntityProfile()
        {
            CreateMap<PerguntaViewModel, PerguntaEntity>()
                .ConstructUsing(vm => new PerguntaEntity
                {
                    Id = vm.Id,
                    PerguntaPai = vm.IdPerguntaPai.HasValue ? new PerguntaEntity { Id = vm.IdPerguntaPai.Value } : null,
                    RespostaPai = vm.RespostaPai,
                    Texto = vm.Mensagem,
                    Ordem = vm.Ordem
                });
            CreateMap<CervejaViewModel, CervejaEntity>();
        }
    }
}
