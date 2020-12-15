using AutoMapper;
using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;
using HL7MVC5.Dtos;
using HL7MVC5.Models;
using System.Collections.Generic;

namespace HL7MVC5.Controllers.Api
{
    public class PatientsController : ApiController
    {
        private ApplicationDbContext _context;

        public PatientsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/patients
        public IEnumerable<PatientDto> GetPatients(string query = null)
        {
            var patientsQuery = _context.Patients
                .Include(c => c.MembershipType);

            if (!String.IsNullOrWhiteSpace(query))
                patientsQuery = patientsQuery.Where(c => c.Name.Contains(query));

            return patientsQuery
                .ToList()
                .Select(Mapper.Map<Patient, PatientDto>);
            
        }

        // GET /api/patients/1
        public IHttpActionResult GetPatient(int id)
        {
            var patient = _context.Patients.SingleOrDefault(c => c.Id == id);

            if (patient == null)
                return NotFound();

            return Ok(Mapper.Map<Patient, PatientDto>(patient));
        }

        // POST /api/patients
        [HttpPost]
        public IHttpActionResult CreatePatient(PatientDto patientDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var patient = Mapper.Map<PatientDto, Patient>(patientDto);
            _context.Patients.Add(patient);
            _context.SaveChanges();

            patientDto.Id = patient.Id;
            return Created(new Uri(Request.RequestUri + "/" + patient.Id), patientDto);
        }

        // PUT /api/patients/1
        [HttpPut]
        public IHttpActionResult UpdatePatient(int id, PatientDto patientDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var patientInDb = _context.Patients.SingleOrDefault(c => c.Id == id);

            if (patientInDb == null)
                return NotFound();

            Mapper.Map(patientDto, patientInDb);

            _context.SaveChanges();

            return Ok();
        }

        // DELETE /api/patients/1
        [HttpDelete]
        public IHttpActionResult DeletePatient(int id)
        {
            var patientInDb = _context.Patients.SingleOrDefault(c => c.Id == id);

            if (patientInDb == null)
                return NotFound();

            _context.Patients.Remove(patientInDb);
            _context.SaveChanges();

            return Ok();
        }
    }
}
