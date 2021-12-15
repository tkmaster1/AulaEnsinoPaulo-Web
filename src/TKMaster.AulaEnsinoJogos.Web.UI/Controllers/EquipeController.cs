using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TKMaster.AulaEnsinoJogos.Web.UI.Application.Interfaces;
using TKMaster.AulaEnsinoJogos.Web.UI.ViewModels;

namespace TKMaster.AulaEnsinoJogos.Web.UI.Controllers
{
    public class EquipeController : Controller
    {
        #region Properties

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        #endregion

        #region Constructor

        public EquipeController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        #endregion

        #region Views

        public async Task<IActionResult> Index()
        {
            var retorno = await ListarTodos();

            return View(retorno);
        }

        #endregion

        #region Methods Públicos

        public async Task<List<EquipeViewModel>> ListarTodos()
        {
            //var response = await _unitOfWork.EquipeApp.ListarTodos();
            //return _mapper.Map<List<EquipeViewModel>>(response?.Data.ToList() ?? new List<EquipeDTO>());

            var response = new List<EquipeViewModel>()
            {
                new EquipeViewModel { Codigo = 1, Nome = "Tabajara F.C.", CodigoCidade = 1 },
                new EquipeViewModel { Codigo = 2, Nome = "Pingaiada F.C.", CodigoCidade = 2 },
                new EquipeViewModel { Codigo = 3, Nome = "TFumaça F.C.", CodigoCidade = 3 },

                new EquipeViewModel { Codigo = 4, Nome = "E.C.Nacional", CodigoCidade = 4 },
                new EquipeViewModel { Codigo = 5, Nome = "Vivaldi F.C.", CodigoCidade = 1 },
                new EquipeViewModel { Codigo = 6, Nome = "Tabajara F.C.", CodigoCidade = 2 },

                new EquipeViewModel { Codigo = 7, Nome = "São Matheus F.C.", CodigoCidade = 3 },
                new EquipeViewModel { Codigo = 8, Nome = "Pq Marajoara F.C.", CodigoCidade = 4 },
                new EquipeViewModel { Codigo = 9, Nome = "S.R Vila União", CodigoCidade = 1 },

                new EquipeViewModel { Codigo = 10, Nome = "Sacadura Cabral F.C.", CodigoCidade = 2},
                new EquipeViewModel { Codigo = 11, Nome = "Moinho Velho F.C.", CodigoCidade = 3 },
                new EquipeViewModel { Codigo = 12, Nome = "Utinga F.C.", CodigoCidade = 4 }
            };

            return response;

        }

        #endregion
    }
}
