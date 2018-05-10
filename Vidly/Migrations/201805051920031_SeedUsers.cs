namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3e29c522-3e0e-45ca-89f7-4824e4b5b9b9', N'guest@vidly.com', 0, N'ALE9+fpDkQ+FGnLamHz9+E2RbceG3WOg6fdr11FW6CTcxCCO3pbUdIOsYBCCeM8gLg==', N'8e7f9b71-cf9e-4af7-9cea-953e30d87d88', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c4f60f37-4ea0-488f-af5e-fdd08a970a3f', N'admin@vidly.com', 0, N'AAyV6c57VczbGfhVdnbe5aI/D1idDI7uhvLH7Vn0Q6gnOqY3QSleeFboyi7MGZSYKw==', N'7e46175b-2582-4c5b-8560-e75575a689f0', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7ee78144-4834-4f53-b62a-2b37eb8aa0a7', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c4f60f37-4ea0-488f-af5e-fdd08a970a3f', N'7ee78144-4834-4f53-b62a-2b37eb8aa0a7')
");
            
        }
        
        public override void Down()
        {
        }
    }
}
