using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeuhero.Web.UI.Models;
using Microsoft.AspNetCore.Mvc;
using jeuhero.Core.Data;

namespace jeuhero.Web.UI.Controllers
{
    public class AventureController : Controller
    {
        public IActionResult Index()
        {
            this.ViewBag.Title = "Aventure Page";

            List<Aventure> maList = new List<Aventure>();

            maList.Add(new Aventure()
            {
                Id = 1,
                Title = "Aventure 1",
                Content = "Mon contenu"
            });

            maList.Add(new Aventure()
            {
                Id = 2,
                Title = "Aventure 2",
                Content = "Mon contenu"
            });

            return View(maList);
        }
    }
}