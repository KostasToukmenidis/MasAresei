namespace MasAresei.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingBridgeTableFoodIngredientsToTryAutoPopulateByEF : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FoodIngredients", "FoodId", "dbo.Foods");
            DropForeignKey("dbo.FoodIngredients", "IngredientId", "dbo.Ingredients");
            DropIndex("dbo.FoodIngredients", new[] { "FoodId" });
            DropIndex("dbo.FoodIngredients", new[] { "IngredientId" });
            CreateTable(
                "dbo.IngredientFoods",
                c => new
                    {
                        Ingredient_Id = c.Int(nullable: false),
                        Food_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ingredient_Id, t.Food_Id })
                .ForeignKey("dbo.Ingredients", t => t.Ingredient_Id, cascadeDelete: true)
                .ForeignKey("dbo.Foods", t => t.Food_Id, cascadeDelete: true)
                .Index(t => t.Ingredient_Id)
                .Index(t => t.Food_Id);
            
            DropTable("dbo.FoodIngredients");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.FoodIngredients",
                c => new
                    {
                        FoodId = c.Int(nullable: false),
                        IngredientId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.FoodId, t.IngredientId });
            
            DropForeignKey("dbo.IngredientFoods", "Food_Id", "dbo.Foods");
            DropForeignKey("dbo.IngredientFoods", "Ingredient_Id", "dbo.Ingredients");
            DropIndex("dbo.IngredientFoods", new[] { "Food_Id" });
            DropIndex("dbo.IngredientFoods", new[] { "Ingredient_Id" });
            DropTable("dbo.IngredientFoods");
            CreateIndex("dbo.FoodIngredients", "IngredientId");
            CreateIndex("dbo.FoodIngredients", "FoodId");
            AddForeignKey("dbo.FoodIngredients", "IngredientId", "dbo.Ingredients", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FoodIngredients", "FoodId", "dbo.Foods", "Id", cascadeDelete: true);
        }
    }
}
