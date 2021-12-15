using Microsoft.AspNetCore.Http;
using TKMaster.AulaEnsinoJogos.Web.UI.Application.Interfaces;

namespace TKMaster.AulaEnsinoJogos.Web.UI.Application.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Properties

        private readonly IBaseService _baseService;
        private readonly IHttpContextAccessor _context;

        #endregion

        #region Constructor

        public UnitOfWork(IBaseService baseService,
                          IHttpContextAccessor context)
        {
            _baseService = baseService;
            _context = context;
        }

        #endregion

        #region Instância Privadas

        private IEquipeAppService equipeApp;

        #endregion

        #region Propriedades Públicas

        public IEquipeAppService EquipeApp
        {
            get { return equipeApp ?? new EquipeAppService(_baseService); }
        }

        #endregion
    }
}
