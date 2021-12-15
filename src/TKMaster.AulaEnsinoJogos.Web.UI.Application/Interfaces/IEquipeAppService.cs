using System.Threading.Tasks;
using TKMaster.AulaEnsinoJogos.Web.UI.Application.DTO;
using TKMaster.AulaEnsinoJogos.Web.UI.Application.Request.Equipe;
using TKMaster.AulaEnsinoJogos.Web.UI.Application.Response;

namespace TKMaster.AulaEnsinoJogos.Web.UI.Application.Interfaces
{
    public interface IEquipeAppService
    {
        Task<RetornoAPIDataList<EquipeDTO>> ListarTodos();

        Task<RetornoAPIData<EquipeDTO>> ObterPorCodigo(int codigo);

        Task<RetornoAPIData<object>> Adicionar(RequestAdicionarEquipe req);

        Task<RetornoAPIData<object>> Atualizar(RequestAtualizarEquipe req);

        Task<RetornoAPIData<object>> Deletar(RequestReativarExcluirEquipe req);
    }
}
