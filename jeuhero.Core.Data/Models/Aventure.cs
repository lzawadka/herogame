using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace jeuhero.Core.Data.Models
{
    [Table("Aventure")]
    public class Aventure
    {
        #region Propriétés

        [Key]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Le titre doit être renseigner")]
        public string Title { get; set; }

        [Required(AllowEmptyStrings = false,  ErrorMessage = "Le contenu doit être renseigner")]
        public string Content { get; set; }

        #endregion
    }
}
