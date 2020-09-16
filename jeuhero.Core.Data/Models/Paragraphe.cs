using System;
using System.Collections.Generic;
using System.Text;

namespace jeuhero.Core.Data.Models
{
    class Paragraphe
    {
        #region Propriétés

        public int Id { get; set; }

        public int Number { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public Question MyQuestion { get; set; }

        #endregion
    }
}
