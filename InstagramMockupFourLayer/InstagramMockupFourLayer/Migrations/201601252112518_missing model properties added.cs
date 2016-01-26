namespace InstagramMockupFourLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class missingmodelpropertiesadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Owner_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.AspNetUsers", "ApplicationUser_Id", c => c.String(maxLength: 128));
            CreateIndex("dbo.Posts", "Owner_Id");
            CreateIndex("dbo.AspNetUsers", "ApplicationUser_Id");
            AddForeignKey("dbo.AspNetUsers", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Posts", "Owner_Id", "dbo.AspNetUsers", "Id");
            DropColumn("dbo.AspNetUsers", "Friends");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AspNetUsers", "Friends", c => c.String());
            DropForeignKey("dbo.Posts", "Owner_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetUsers", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.Posts", new[] { "Owner_Id" });
            DropColumn("dbo.AspNetUsers", "ApplicationUser_Id");
            DropColumn("dbo.Posts", "Owner_Id");
        }
    }
}
