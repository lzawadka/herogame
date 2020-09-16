using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace jeuhero.backoffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        #region Méthodes
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        #endregion
    }
}
