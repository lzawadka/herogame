using System;
using System.Collections.Generic;
using System.Text;

namespace jeuhero.Core.Data.Models
{
    public class Question
    {
        #region Propriétés

        public int Id { get; set; }

        public int Title { get; set; }

        public List<Answer> MyAnswers { get; set; }

        #endregion
    }
}
