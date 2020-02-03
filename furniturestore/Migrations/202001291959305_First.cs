namespace furniturestore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        price = c.Double(nullable: false),
                        description = c.String(),
                        manufacturername = c.String(),
                        length = c.Int(nullable: false),
                        height = c.Int(nullable: false),
                        width = c.Int(nullable: false),
                        fooditem = c.String(),
                        qty = c.Int(nullable: false),
                        itemURL = c.String(maxLength: 1024),
                        FoodGroups_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.FoodGroups", t => t.FoodGroups_id)
                .Index(t => t.FoodGroups_id);
            
            CreateTable(
                "dbo.FoodGroups",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        desc = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "FoodGroups_id", "dbo.FoodGroups");
            DropIndex("dbo.Products", new[] { "FoodGroups_id" });
            DropTable("dbo.FoodGroups");
            DropTable("dbo.Products");
        }
    }
}
