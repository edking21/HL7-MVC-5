using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HL7MVC5.Models;

namespace HL7MVC5.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<PatientMaster> Patients { get; set; }
    }
}