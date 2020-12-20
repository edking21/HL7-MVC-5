namespace HL7MVC5.Migrations
{
    using HL7MVC5.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<HL7MVC5.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //context.Patients.AddOrUpdate(a => a.Gender,
            //     new PatientMaster
            //     {
            //         Gender = "F",
            //         Name = "Stevie Nicks",
            //         MembershipTypeId = 1,
            //         Birthdate = new DateTime(1964, 07, 03),
            //         AddressMaster = new AddressMaster { Line = "100 Main", City = "Miami", State = "FL", PostalCode = "12345" }
            //     });
        }
    }
}
