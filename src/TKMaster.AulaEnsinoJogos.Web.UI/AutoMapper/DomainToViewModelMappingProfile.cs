using AutoMapper;
using TKMaster.AulaEnsinoJogos.Web.UI.Application.DTO;
using TKMaster.AulaEnsinoJogos.Web.UI.Application.Request.Equipe;
using TKMaster.AulaEnsinoJogos.Web.UI.ViewModels;

namespace TKMaster.AulaEnsinoJogos.Web.UI.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<EquipeDTO, EquipeViewModel>();
            CreateMap<RequestAdicionarEquipe, EquipeViewModel>();
            CreateMap<RequestAtualizarEquipe, EquipeViewModel>();
        }
    }
}
