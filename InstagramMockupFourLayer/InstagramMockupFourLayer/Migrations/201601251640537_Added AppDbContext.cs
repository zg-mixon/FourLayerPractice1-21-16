namespace InstagramMockupFourLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedAppDbContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        Active = c.Boolean(nullable: false),
                        Location_Id = c.Int(),
                        Picture_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Locations", t => t.Location_Id)
                .ForeignKey("dbo.Pictures", t => t.Picture_Id)
                .Index(t => t.Location_Id)
                .Index(t => t.Picture_Id);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        State = c.String(),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PostCategories",
                c => new
                    {
                        Post_Id = c.Int(nullable: false),
                        Category_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Post_Id, t.Category_Id })
                .ForeignKey("dbo.Posts", t => t.Post_Id, cascadeDelete: true)
                .ForeignKey("dbo.Categories", t => t.Category_Id, cascadeDelete: true)
                .Index(t => t.Post_Id)
                .Index(t => t.Category_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Picture_Id", "dbo.Pictures");
            DropForeignKey("dbo.Posts", "Location_Id", "dbo.Locations");
            DropForeignKey("dbo.PostCategories", "Category_Id", "dbo.Categories");
            DropForeignKey("dbo.PostCategories", "Post_Id", "dbo.Posts");
            DropIndex("dbo.PostCategories", new[] { "Category_Id" });
            DropIndex("dbo.PostCategories", new[] { "Post_Id" });
            DropIndex("dbo.Posts", new[] { "Picture_Id" });
            DropIndex("dbo.Posts", new[] { "Location_Id" });
            DropTable("dbo.PostCategories");
            DropTable("dbo.Locations");
            DropTable("dbo.Posts");
            DropTable("dbo.Categories");
        }
    }
}
