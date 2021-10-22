namespace MasAresei.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingForeignKeyOfFoodClass : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Foods", "FoodCategoryId", "dbo.FoodCategories");
            DropIndex("dbo.Foods", new[] { "FoodCategoryId" });
            RenameColumn(table: "dbo.Foods", name: "FoodCategoryId", newName: "FoodCategory_Id");
            AddColumn("dbo.Foods", "FoodCategoryName", c => c.String());
            AlterColumn("dbo.Foods", "FoodCategory_Id", c => c.Int());
            CreateIndex("dbo.Foods", "FoodCategory_Id");
            AddForeignKey("dbo.Foods", "FoodCategory_Id", "dbo.FoodCategories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Foods", "FoodCategory_Id", "dbo.FoodCategories");
            DropIndex("dbo.Foods", new[] { "FoodCategory_Id" });
            AlterColumn("dbo.Foods", "FoodCategory_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Foods", "FoodCategoryName");
            RenameColumn(table: "dbo.Foods", name: "FoodCategory_Id", newName: "FoodCategoryId");
            CreateIndex("dbo.Foods", "FoodCategoryId");
            AddForeignKey("dbo.Foods", "FoodCategoryId", "dbo.FoodCategories", "Id", cascadeDelete: true);
        }
    }
}
