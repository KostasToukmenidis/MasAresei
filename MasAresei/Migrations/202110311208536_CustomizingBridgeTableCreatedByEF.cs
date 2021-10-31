namespace MasAresei.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CustomizingBridgeTableCreatedByEF : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.IngredientFoods", newName: "FoodIngredients");
            RenameColumn(table: "dbo.FoodIngredients", name: "Ingredient_Id", newName: "IngredientId");
            RenameColumn(table: "dbo.FoodIngredients", name: "Food_Id", newName: "FoodId");
            RenameIndex(table: "dbo.FoodIngredients", name: "IX_Food_Id", newName: "IX_FoodId");
            RenameIndex(table: "dbo.FoodIngredients", name: "IX_Ingredient_Id", newName: "IX_IngredientId");
            DropPrimaryKey("dbo.FoodIngredients");
            AddPrimaryKey("dbo.FoodIngredients", new[] { "FoodId", "IngredientId" });
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.FoodIngredients");
            AddPrimaryKey("dbo.FoodIngredients", new[] { "Ingredient_Id", "Food_Id" });
            RenameIndex(table: "dbo.FoodIngredients", name: "IX_IngredientId", newName: "IX_Ingredient_Id");
            RenameIndex(table: "dbo.FoodIngredients", name: "IX_FoodId", newName: "IX_Food_Id");
            RenameColumn(table: "dbo.FoodIngredients", name: "FoodId", newName: "Food_Id");
            RenameColumn(table: "dbo.FoodIngredients", name: "IngredientId", newName: "Ingredient_Id");
            RenameTable(name: "dbo.FoodIngredients", newName: "IngredientFoods");
        }
    }
}
