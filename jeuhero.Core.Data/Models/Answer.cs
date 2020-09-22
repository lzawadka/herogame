using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace jeuhero.Core.Data.Models
{
    [Table("Answer")]
    public class Answer
    {
        #region Propriétés

        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "La description doit être renseigner")]
        public string Description { get; set; }

        public int QuestionId { get; set; }

        #endregion
    }
}
