namespace HL7MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitModel2 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PatientMasters", "AddressId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PatientMasters", "AddressId", c => c.Byte(nullable: false));
        }
    }
}
