namespace HL7MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Line = c.String(nullable: false),
                        City = c.String(nullable: false),
                        State = c.String(nullable: false),
                        PostalCode = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Patients", "AddressId", c => c.Byte(nullable: false));
            AddForeignKey("dbo.Patients", "AddressId", "dbo.Addresses", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Patients", "Address_Id", "dbo.Addresses");
            DropIndex("dbo.Patients", new[] { "Address_Id" });
            DropColumn("dbo.Patients", "Address_Id");
            DropColumn("dbo.Patients", "AddressId");
            DropTable("dbo.Addresses");
        }
    }
}
