using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HL7MVC5.Models;

namespace HL7MVC5.ViewModels
{
    public class PatientFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Patient Patient { get; set; }
    }
}