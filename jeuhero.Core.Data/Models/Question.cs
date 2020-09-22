using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace jeuhero.Core.Data.Models
{
    [Table("Question")]
    public class Question
    {
        #region Propriétés

        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Le titre doit être renseigner")]
        public string Title { get; set; }

        public int ParagrapheId { get; set; }

        public List<Answer> MyAnswers { get; set; }

        #endregion
    }
}
