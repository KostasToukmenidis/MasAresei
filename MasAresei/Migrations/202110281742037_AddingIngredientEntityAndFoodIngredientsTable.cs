namespace MasAresei.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingIngredientEntityAndFoodIngredientsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
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
            DropTable("dbo.Ingredients");
        }
    }
}
