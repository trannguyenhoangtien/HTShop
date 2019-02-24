namespace HTShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTableIdentity1 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.ApplicationRole", newName: "ApplicationRoles");
            RenameTable(name: "dbo.ApplicationUserRole", newName: "ApplicationUserRoles");
            RenameTable(name: "dbo.ApplicationUserClaim", newName: "ApplicationUserClaims");
            RenameTable(name: "dbo.ApplicationUserLogin", newName: "ApplicationUserLogins");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ApplicationUserLogins", newName: "ApplicationUserLogin");
            RenameTable(name: "dbo.ApplicationUserClaims", newName: "ApplicationUserClaim");
            RenameTable(name: "dbo.ApplicationUserRoles", newName: "ApplicationUserRole");
            RenameTable(name: "dbo.ApplicationRoles", newName: "ApplicationRole");
        }
    }
}
