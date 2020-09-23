using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jeuhero.Core.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace jeuhero.backoffice.Web.UI.Controllers
{
    public class AnswerController : Controller
    {
        #region Champs privés
        private DefaultContext _context = null;
        #endregion


        #region Constructeur
        public AnswerController(DefaultContext context)
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
            setQuesionList();

            return View();
        }

        [HttpPost]
        public IActionResult Add(Answer answer)
        {
            if (ModelState.IsValid)
            {
                _context.Answers.Add(answer);
                _context.SaveChanges();
            }

            setQuesionList();

            return View(answer);
        }

        private void setQuesionList()
        {
            ViewBag.QuestionList = _context.Questions.ToList();
        }
    }
}
