using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeuhero.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using jeuhero.Core.Data;
using jeuhero.Core.Data.Models;
using System.Security.Policy;

namespace jeuhero.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        public IActionResult Index([FromServices] DefaultContext context)
        {
            ViewBag.Title = "Aventure Page";

            var query = from item in context.Aventures
                        select item;

            return View(query.ToList());
        }
    }
}