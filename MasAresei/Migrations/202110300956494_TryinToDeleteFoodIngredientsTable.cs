namespace MasAresei.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TryinToDeleteFoodIngredientsTable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FoodIngredients", "FoodId", "dbo.Foods");
            DropForeignKey("dbo.FoodIngredients", "IngredientId", "dbo.Ingredients");
            DropIndex("dbo.FoodIngredients", new[] { "FoodId" });
            DropIndex("dbo.FoodIngredients", new[] { "IngredientId" });
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
            
            CreateIndex("dbo.FoodIngredients", "IngredientId");
            CreateIndex("dbo.FoodIngredients", "FoodId");
            AddForeignKey("dbo.FoodIngredients", "IngredientId", "dbo.Ingredients", "Id", cascadeDelete: true);
            AddForeignKey("dbo.FoodIngredients", "FoodId", "dbo.Foods", "Id", cascadeDelete: true);
        }
    }
}
