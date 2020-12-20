using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using HL7MVC5.Models;

namespace HL7MVC5.ViewModels
{
    public class PatientFormViewModel
    {
        public int? Id { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public AddressMaster Address { get; set; }
        public PatientMaster  Patient { get; set; }
        public string Gender { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }


        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Patient" : "New Patient";
            }
        }

        public PatientFormViewModel()
        {
            Id =0;
        }

        public PatientFormViewModel(PatientMaster patient)
        {
            Id = patient.Id;
            Name = patient.Name;
            Address = patient.AddressMaster;
            Gender = patient.Gender;
            IsSubscribedToNewsletter = patient.IsSubscribedToNewsletter;
        }

    }
}