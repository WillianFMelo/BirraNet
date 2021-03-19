using AutoMapper;
using BirraNet.Application.ViewModels;
using BirraNet.Infra.Data.Entidades;

namespace BirraNet.Application.AutoMapper
{
    public class EntityToViewModelProfile : Profile
    {
        public EntityToViewModelProfile()
        {
            CreateMap<PerguntaEntity, PerguntaViewModel>()
                .ConstructUsing(p =>                    
                    new PerguntaViewModel(p.Id, p.Texto, p.Ordem, p.PerguntaPai == null ? (int?)null : p.PerguntaPai.Id, p.RespostaPai, p.EhSugestao)
                );
            CreateMap<CervejaEntity, CervejaViewModel>();                
        }
    }
}
