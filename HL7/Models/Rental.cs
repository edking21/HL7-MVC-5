using System;
using System.ComponentModel.DataAnnotations;

namespace HL7MVC5.Models
{
    public class Rental
    {
        public int Id { get; set; }

        [Required]
        public Patient Patient { get; set; }

        [Required]
        public Movie Movie { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime? DateReturned { get; set; }
    }
}