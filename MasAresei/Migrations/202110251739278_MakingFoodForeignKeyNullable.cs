namespace MasAresei.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MakingFoodForeignKeyNullable : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Foods", "FoodCategoryId", "dbo.FoodCategories");
            DropIndex("dbo.Foods", new[] { "FoodCategoryId" });
            AlterColumn("dbo.Foods", "FoodCategoryId", c => c.Int());
            CreateIndex("dbo.Foods", "FoodCategoryId");
            AddForeignKey("dbo.Foods", "FoodCategoryId", "dbo.FoodCategories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Foods", "FoodCategoryId", "dbo.FoodCategories");
            DropIndex("dbo.Foods", new[] { "FoodCategoryId" });
            AlterColumn("dbo.Foods", "FoodCategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Foods", "FoodCategoryId");
            AddForeignKey("dbo.Foods", "FoodCategoryId", "dbo.FoodCategories", "Id", cascadeDelete: true);
        }
    }
}
