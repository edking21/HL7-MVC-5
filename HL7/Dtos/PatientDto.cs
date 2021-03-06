﻿using HL7MVC5.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace HL7MVC5.Dtos
{
    public class PatientDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }
        public AddressMaster AddressMaster { get; set; }

        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

//        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}