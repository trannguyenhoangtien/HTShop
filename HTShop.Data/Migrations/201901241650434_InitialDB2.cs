namespace HTShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDB2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "CreatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Products", "UpdatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Products", "MetaKeyword", c => c.String(maxLength: 256));
            AlterColumn("dbo.Products", "MetaDescripstion", c => c.String(maxLength: 256));
            AlterColumn("dbo.Pages", "CreatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Pages", "UpdatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Pages", "MetaKeyword", c => c.String(maxLength: 256));
            AlterColumn("dbo.Pages", "MetaDescripstion", c => c.String(maxLength: 256));
            AlterColumn("dbo.PostCategories", "CreatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.PostCategories", "UpdatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.PostCategories", "MetaKeyword", c => c.String(maxLength: 256));
            AlterColumn("dbo.PostCategories", "MetaDescripstion", c => c.String(maxLength: 256));
            AlterColumn("dbo.Posts", "CreatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Posts", "UpdatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.Posts", "MetaKeyword", c => c.String(maxLength: 256));
            AlterColumn("dbo.Posts", "MetaDescripstion", c => c.String(maxLength: 256));
            AlterColumn("dbo.ProductCategories", "CreatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.ProductCategories", "UpdatedBy", c => c.String(maxLength: 256));
            AlterColumn("dbo.ProductCategories", "MetaKeyword", c => c.String(maxLength: 256));
            AlterColumn("dbo.ProductCategories", "MetaDescripstion", c => c.String(maxLength: 256));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ProductCategories", "MetaDescripstion", c => c.String());
            AlterColumn("dbo.ProductCategories", "MetaKeyword", c => c.String());
            AlterColumn("dbo.ProductCategories", "UpdatedBy", c => c.String());
            AlterColumn("dbo.ProductCategories", "CreatedBy", c => c.String());
            AlterColumn("dbo.Posts", "MetaDescripstion", c => c.String());
            AlterColumn("dbo.Posts", "MetaKeyword", c => c.String());
            AlterColumn("dbo.Posts", "UpdatedBy", c => c.String());
            AlterColumn("dbo.Posts", "CreatedBy", c => c.String());
            AlterColumn("dbo.PostCategories", "MetaDescripstion", c => c.String());
            AlterColumn("dbo.PostCategories", "MetaKeyword", c => c.String());
            AlterColumn("dbo.PostCategories", "UpdatedBy", c => c.String());
            AlterColumn("dbo.PostCategories", "CreatedBy", c => c.String());
            AlterColumn("dbo.Pages", "MetaDescripstion", c => c.String());
            AlterColumn("dbo.Pages", "MetaKeyword", c => c.String());
            AlterColumn("dbo.Pages", "UpdatedBy", c => c.String());
            AlterColumn("dbo.Pages", "CreatedBy", c => c.String());
            AlterColumn("dbo.Products", "MetaDescripstion", c => c.String());
            AlterColumn("dbo.Products", "MetaKeyword", c => c.String());
            AlterColumn("dbo.Products", "UpdatedBy", c => c.String());
            AlterColumn("dbo.Products", "CreatedBy", c => c.String());
        }
    }
}
