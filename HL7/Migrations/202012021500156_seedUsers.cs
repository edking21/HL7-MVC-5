namespace HL7MVC5.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            {
                Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) 
VALUES 
  (N'409516ab-86fb-4b8c-9820-e7da070727f4', N'drgray@gmail.com', 0, N'AGaDUU4OWgCMhjIR6y5ibBASb85rFoLUPxEP3ZZflq/oM7uznoHmiUwZFExLh+c++Q==', N'0f391fc2-f4fb-4a90-ae9d-1b331e8d2a6b', NULL, 0, 0, NULL, 1, 0, N'drgray@gmail.com')

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) 
VALUES
 (N'8a79e096-052b-4057-9683-7a7443aa305a', N'admin@HL7.com',0,N'AGaDUU4OWgCMhjIR6y5ibBASb85rFoLUPxEP3ZZflq/oM7uznoHmiUwZFExLh+c++Q==', N'0f391fc2-f4fb-4a90-ae9d-1b331e8d2a6b', NULL, 0, 0, NULL, 1, 0, N'admin@HL7.com')

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) 
VALUES
 (N'b38fafbd-3156-440a-88ab-851b2433fefc', N'guest@HL7.com', 0, N'AGaDUU4OWgCMhjIR6y5ibBASb85rFoLUPxEP3ZZflq/oM7uznoHmiUwZFExLh+c++Q==', N'bb97d846-7e91-4b40-a1cd-94e996ffa47c', NULL, 0, 0, NULL, 1, 0, N'guest@HL7.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f5f8ead2-533d-42f1-baa1-7cb018b1ebf5', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8a79e096-052b-4057-9683-7a7443aa305a', N'f5f8ead2-533d-42f1-baa1-7cb018b1ebf5')

");
            }
        }

        public override void Down()
        {
        }
    }
}
