namespace HL7MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitModel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientMasters", "Gender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PatientMasters", "Gender");
        }
    }
}
