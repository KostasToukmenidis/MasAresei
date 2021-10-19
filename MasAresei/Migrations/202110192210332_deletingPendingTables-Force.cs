namespace MasAresei.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deletingPendingTablesForce : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ingridients", "FoodId", "dbo.Foods");
            DropForeignKey("dbo.Foods", "FoodCategoryId", "dbo.FoodCategories");
            DropIndex("dbo.Foods", new[] { "FoodCategoryId" });
            DropIndex("dbo.Ingridients", new[] { "FoodId" });
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Ingridients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FoodId = c.Int(nullable: false),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FoodCategoryId = c.Int(nullable: false),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.FoodCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Ingridients", "FoodId");
            CreateIndex("dbo.Foods", "FoodCategoryId");
            AddForeignKey("dbo.Foods", "FoodCategoryId", "dbo.FoodCategories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Ingridients", "FoodId", "dbo.Foods", "Id", cascadeDelete: true);
        }
    }
}
