namespace HL7MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddMembershipType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MembershipTypes",
                c => new
                {
                    Id = c.Byte(nullable: false),
                    SignUpFee = c.Short(nullable: false),
                    DurationInMonths = c.Byte(nullable: false),
                    DiscountRate = c.Byte(nullable: false),
                })
                .PrimaryKey(t => t.Id);

            AddForeignKey("dbo.Patients", "MembershipTypeId", "dbo.MembershipTypes", "Id", cascadeDelete: true);

        }

        public override void Down()
        {
        }
    }
}
