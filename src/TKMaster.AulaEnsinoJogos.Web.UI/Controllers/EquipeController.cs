using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TKMaster.AulaEnsinoJogos.Web.UI.Controllers
{
    public class EquipeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
