namespace HL7MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removePhoneRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "Phone", c => c.String(maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AspNetUsers", "Phone", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
