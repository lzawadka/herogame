using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeuhero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeuhero.backoffice.Web.UI.Controllers
{
    public class QuestionController : Controller
    {
        #region Champs privés
        private DefaultContext _context = null;
        #endregion


        #region Constructeur
        public QuestionController(DefaultContext context)
        {
            _context = context;
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            ViewBag.ParagrapheList = _context.Paragraphes.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Add(Question question)
        {
            if(ModelState.IsValid)
            {
                _context.Questions.Add(question);
                _context.SaveChanges();
            }

            ViewBag.ParagrapheList = _context.Paragraphes.ToList();

            return View(question);
        }
    }
}
