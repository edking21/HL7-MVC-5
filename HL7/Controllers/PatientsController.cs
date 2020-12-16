using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using HL7MVC5.Models;
using HL7MVC5.ViewModels;

namespace HL7MVC5.Controllers
{
    public class PatientsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PatientsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new PatientFormViewModel
            {
                Patient = new Patient(),
                MembershipTypes = membershipTypes
            };

            return View("PatientForm", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Patient patient)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new PatientFormViewModel
                {
                    Patient = patient,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };

                return View("PatientForm", viewModel);
            }

            if (patient.Id == 0)
                _context.Patients.Add(patient);
            else
            {
                var patientInDb = _context.Patients.Single(c => c.Id == patient.Id);
                patientInDb.Name = patient.Name;
                patientInDb.Birthdate = patient.Birthdate;
                patientInDb.MembershipTypeId = patient.MembershipTypeId;
                patientInDb.IsSubscribedToNewsletter = patient.IsSubscribedToNewsletter;
            }

            _context.SaveChanges();

            return RedirectToAction("Index", "Patients");
        }

        public ViewResult Index()
        {
            var patients = _context.Patients.Include(c => c.MembershipType).ToList();
            return View(patients);
        }

        public ActionResult Details(int id)
        {
            var patient = _context.Patients.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (patient == null)
                return HttpNotFound();

            return View(patient);
        }

        public ActionResult Edit(int id)
        {
            var patient = _context.Patients.SingleOrDefault(c => c.Id == id);

            if (patient == null)
                return HttpNotFound();

            var viewModel = new PatientFormViewModel
            {
                Patient = patient,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("PatientForm", viewModel);
        }
    }
}