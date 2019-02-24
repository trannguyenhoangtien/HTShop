namespace HTShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameTableIdentity : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.IdentityRoles", newName: "ApplicationRole");
            RenameTable(name: "dbo.IdentityUserRoles", newName: "ApplicationUserRole");
            RenameTable(name: "dbo.IdentityUserClaims", newName: "ApplicationUserClaim");
            RenameTable(name: "dbo.IdentityUserLogins", newName: "ApplicationUserLogin");
            DropPrimaryKey("dbo.ApplicationUserClaim");
            AlterColumn("dbo.ApplicationUserClaim", "Id", c => c.Int(nullable: false));
            AlterColumn("dbo.ApplicationUserClaim", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.ApplicationUserClaim", "UserId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ApplicationUserClaim");
            AlterColumn("dbo.ApplicationUserClaim", "UserId", c => c.String());
            AlterColumn("dbo.ApplicationUserClaim", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.ApplicationUserClaim", "Id");
            RenameTable(name: "dbo.ApplicationUserLogin", newName: "IdentityUserLogins");
            RenameTable(name: "dbo.ApplicationUserClaim", newName: "IdentityUserClaims");
            RenameTable(name: "dbo.ApplicationUserRole", newName: "IdentityUserRoles");
            RenameTable(name: "dbo.ApplicationRole", newName: "IdentityRoles");
        }
    }
}
