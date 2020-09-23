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

        #region Index
        public IActionResult Index()
        {
            return View();
        }

        #endregion

        #region Create

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Paragraphe paragraphe)
        {
            if (ModelState.IsValid)
            {
                _context.Paragraphes.Add(paragraphe);
                _context.SaveChanges();

                return View();
            }
            return View();
        }

        #endregion

        #region Edit
        public IActionResult Edit(int id)
        {
            Paragraphe paragraphe = null;

            paragraphe = _context.Paragraphes.First(item => item.Id == id);

            return View(paragraphe);
        }

        [HttpPost]
        public IActionResult Edit(Paragraphe paragraphe)
        {
            if (ModelState.IsValid)
            {
                _context.Attach<Paragraphe>(paragraphe);
                _context.Entry(paragraphe).Property(item => item.Number).IsModified = true;
                _context.Entry(paragraphe).Property(item => item.Title).IsModified = true;
                _context.Entry(paragraphe).Property(item => item.Description).IsModified = true;

                _context.SaveChanges();

                return View(paragraphe);
            }
            else
            {
                return View(paragraphe);
            }
        }
        #endregion


        #endregion
    }
}
