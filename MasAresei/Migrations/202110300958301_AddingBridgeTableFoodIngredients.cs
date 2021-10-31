namespace MasAresei.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingBridgeTableFoodIngredients : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FoodIngredients",
                c => new
                    {
                        FoodId = c.Int(nullable: false),
                        IngredientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FoodId, t.IngredientId })
                .ForeignKey("dbo.Foods", t => t.FoodId, cascadeDelete: true)
                .ForeignKey("dbo.Ingredients", t => t.IngredientId, cascadeDelete: true)
                .Index(t => t.FoodId)
                .Index(t => t.IngredientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FoodIngredients", "IngredientId", "dbo.Ingredients");
            DropForeignKey("dbo.FoodIngredients", "FoodId", "dbo.Foods");
            DropIndex("dbo.FoodIngredients", new[] { "IngredientId" });
            DropIndex("dbo.FoodIngredients", new[] { "FoodId" });
            DropTable("dbo.FoodIngredients");
        }
    }
}
