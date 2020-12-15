using System.Collections.Generic;

namespace HL7MVC5.Dtos
{
    public class NewRentalDto
    {
        public int PatientId { get; set; }
        public List<int> MovieIds { get; set; }
    }
}