using System;
using System.ComponentModel.DataAnnotations;

namespace HL7MVC5.Models
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var patient = (PatientMaster)validationContext.ObjectInstance;

            if (patient.MembershipTypeId == MembershipType.Unknown || 
                patient.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (patient.Birthdate == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - patient.Birthdate.Value.Year;

            return (age >= 18) 
                ? ValidationResult.Success 
                : new ValidationResult("Patient should be at least 18 years old to go on a membership.");
        }
    }
}