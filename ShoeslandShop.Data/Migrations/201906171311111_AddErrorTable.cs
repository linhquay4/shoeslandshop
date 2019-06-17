namespace ShoeslandShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddErrorTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        StackTrace = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Products", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.ProductCategories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Pages", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.PostCategories", "CreatedDate", c => c.DateTime());
            AddColumn("dbo.Posts", "CreatedDate", c => c.DateTime());
            DropColumn("dbo.Products", "CreatedData");
            DropColumn("dbo.ProductCategories", "CreatedData");
            DropColumn("dbo.Pages", "CreatedData");
            DropColumn("dbo.PostCategories", "CreatedData");
            DropColumn("dbo.Posts", "CreatedData");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Posts", "CreatedData", c => c.DateTime());
            AddColumn("dbo.PostCategories", "CreatedData", c => c.DateTime());
            AddColumn("dbo.Pages", "CreatedData", c => c.DateTime());
            AddColumn("dbo.ProductCategories", "CreatedData", c => c.DateTime());
            AddColumn("dbo.Products", "CreatedData", c => c.DateTime());
            DropColumn("dbo.Posts", "CreatedDate");
            DropColumn("dbo.PostCategories", "CreatedDate");
            DropColumn("dbo.Pages", "CreatedDate");
            DropColumn("dbo.ProductCategories", "CreatedDate");
            DropColumn("dbo.Products", "CreatedDate");
            DropTable("dbo.Errors");
        }
    }
}
