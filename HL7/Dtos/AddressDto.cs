using System.ComponentModel.DataAnnotations;

namespace HL7MVC5.Dtos
{
    public class AddressDto
    {
        public int Id { get; set; }
        [Required]
        public string Line { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }

    }
}