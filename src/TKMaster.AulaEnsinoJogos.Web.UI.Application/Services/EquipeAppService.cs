using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKMaster.AulaEnsinoJogos.Web.UI.Application.DTO;
using TKMaster.AulaEnsinoJogos.Web.UI.Application.Interfaces;
using TKMaster.AulaEnsinoJogos.Web.UI.Application.Request.Equipe;
using TKMaster.AulaEnsinoJogos.Web.UI.Application.Response;

namespace TKMaster.AulaEnsinoJogos.Web.UI.Application.Services
{
    public class EquipeAppService : IEquipeAppService
    {
        #region Properties

        private readonly IBaseService _service;

        #endregion

        #region Constructor

        public EquipeAppService(IBaseService service)
        {
            _service = service;
        }

        #endregion

        #region Methods

        public async Task<RetornoAPIDataList<EquipeDTO>> ListarTodos()
        {
            // url = ele vai na WebApi - controller: Equipe, Método: ListarTodos
            string url = $"{_service.UrlBase}/Equipe/ListarTodos";

            var request = _service.MontarRequest("GET", url);

            return await _service.MontarResponseList<EquipeDTO>(request);
        }

        public async Task<RetornoAPIData<EquipeDTO>> ObterPorCodigo(int codigo)
        {
            string url = $"{_service.UrlBase}/Equipe/ObterPorCodigo/{codigo.ToString()}";

            var request = _service.MontarRequest("GET", url);

            return await _service.MontarResponse<EquipeDTO>(request);
        }

        public async Task<RetornoAPIData<object>> Adicionar(RequestAdicionarEquipe req)
        {
            string url = $"{_service.UrlBase}/Equipe/Adicionar/";

            var request = _service.MontarRequest("POST", url, req);

            return await _service.MontarResponse<object>(request);
        }

        public async Task<RetornoAPIData<object>> Atualizar(RequestAtualizarEquipe requestAtualizar)
        {
            string url = $"{_service.UrlBase}/Equipe/Atualizar/";

            var request = _service.MontarRequest("PUT", url, requestAtualizar);

            return await _service.MontarResponse<object>(request);
        }

        public async Task<RetornoAPIData<object>> Deletar(RequestReativarExcluirEquipe req)
        {
            string url = $"{_service.UrlBase}/Equipe/Excluir/";

            var request = _service.MontarRequest("PUT", url, req);

            return await _service.MontarResponse<object>(request);
        }

        #endregion
    }
}
