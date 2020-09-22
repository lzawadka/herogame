using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeuhero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeuhero.backoffice.Web.UI.Controllers
{
    public class ParagrapheController : Controller
    {
        #region Champs privés
        private DefaultContext _context = null;
        #endregion


        #region Constructeur
        public ParagrapheController(DefaultContext context)
        {
            _context = context;
        }
        #endregion

        #region Méthodes
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Paragraphe paragraphe)
        {
            if(ModelState.IsValid)
            {
                _context.Paragraphes.Add(paragraphe);
                _context.SaveChanges();

                return View();
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            Paragraphe paragraphe = null;

            paragraphe = _context.Paragraphes.First(item => item.Id == id);

            return View(paragraphe);
        }

        [HttpPost]
        public IActionResult Edit(Paragraphe paragraphe)
        {
            if(ModelState.IsValid)
            {
                _context.Attach<Paragraphe>(paragraphe);
                _context.Entry(paragraphe).Property(item => item.Title).IsModified = true;

                _context.SaveChanges();

                return View(paragraphe);
            }
            else
            {
                return View(paragraphe);
            }
        }

        #endregion
    }
}
