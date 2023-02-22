using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission06_brd48.Models
{
    public class FormResponse
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [Required(ErrorMessage ="Hey you fool! What are you thinking trying to submit a movie without the title?")]
        public string MovieTitle { get; set; }
        [Required(ErrorMessage ="What year was it made? We gotta know!")]
        public int Year { get; set; }
        [Required (ErrorMessage ="What, there was no director? Add the Director's name!")]
        public string Director { get; set; }
        [Required (ErrorMessage ="You can't forget the MPAA rating silly pants!")]
        public string Rating { get; set; }

        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [StringLength(25)]
        public string Notes { get; set; }

        //build foreign key relationship
        [Required (ErrorMessage ="You MUST add the category. Or else.")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
