using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace jeuhero.Core.Data.Models
{
    [Table("Paragraphe")]
    public class Paragraphe
    {
        #region Propriétés

        [Key]
        public int Id { get; set; }

        [Range(1, 99999999)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Le numéro doit être renseigner")]
        public int Number { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Le titre doit être renseigner")]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "La description doit être renseigner")]
        public string Description { get; set; }

        public Question MyQuestion { get; set; }

        #endregion
    }
}
