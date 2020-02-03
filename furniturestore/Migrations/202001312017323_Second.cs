namespace furniturestore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "FoodGroups_id", "dbo.FoodGroups");
            DropIndex("dbo.Products", new[] { "FoodGroups_id" });
            AddColumn("dbo.Products", "FoodGroupID", c => c.Int(nullable: false));
            AddColumn("dbo.FoodGroups", "name", c => c.String());
            DropColumn("dbo.Products", "FoodGroups_id");
            DropColumn("dbo.FoodGroups", "desc");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FoodGroups", "desc", c => c.String());
            AddColumn("dbo.Products", "FoodGroups_id", c => c.Int());
            DropColumn("dbo.FoodGroups", "name");
            DropColumn("dbo.Products", "FoodGroupID");
            CreateIndex("dbo.Products", "FoodGroups_id");
            AddForeignKey("dbo.Products", "FoodGroups_id", "dbo.FoodGroups", "id");
        }
    }
}
