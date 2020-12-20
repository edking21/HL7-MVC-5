using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HL7MVC5.Models
{
    public class Medication
    {
        public int Id { get; set; }
        public Coding Code { get; set; }
        
        [Display(Name = "Code")]
        [Required]
        public int CodingId { get; set; }

        [StringLength(255)]
        [Required]
        public string Text { get; set; }

    }
}