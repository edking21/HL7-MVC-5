using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HL7MVC5.Models
{
    public class AddressMaster
    {
        public int Id { get; set; }
        [Required]
        public string Line { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

    }
}