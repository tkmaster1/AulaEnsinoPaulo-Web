using AutoMapper;
using TKMaster.AulaEnsinoJogos.Web.UI.Application.DTO;
using TKMaster.AulaEnsinoJogos.Web.UI.Application.Request.Equipe;
using TKMaster.AulaEnsinoJogos.Web.UI.ViewModels;

namespace TKMaster.AulaEnsinoJogos.Web.UI.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<EquipeViewModel, EquipeDTO>();
            CreateMap<EquipeViewModel, RequestAdicionarEquipe>();
            CreateMap<EquipeViewModel, RequestAtualizarEquipe>();
        }
    }
}
