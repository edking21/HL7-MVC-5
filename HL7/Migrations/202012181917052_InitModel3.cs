namespace HL7MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitModel3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PatientMasters", "AddressId", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PatientMasters", "AddressId");
        }
    }
}
