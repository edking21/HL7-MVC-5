using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HL7MVC5.Models
{
    public class Coding
    {
        public byte Id { get; set; }

        [StringLength(255)]
        public string System { get; set; }

        [Required]
        [StringLength(255)]
        public string Code { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Display { get; set; }

    }
}