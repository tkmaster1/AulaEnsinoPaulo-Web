using System.Threading.Tasks;

namespace TKMaster.AulaEnsinoJogos.Web.UI.Application.BaseService.Interfaces
{
    public interface INotificationHandler<T> where T : class
    {
        Task Handle(T notification);
    }
}
