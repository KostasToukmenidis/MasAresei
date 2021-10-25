namespace MasAresei.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangingForeignKeeBackToInteger : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Foods", "FoodCategory_Id", "dbo.FoodCategories");
            DropIndex("dbo.Foods", new[] { "FoodCategory_Id" });
            RenameColumn(table: "dbo.Foods", name: "FoodCategory_Id", newName: "FoodCategoryId");
            AlterColumn("dbo.Foods", "FoodCategoryId", c => c.Int(nullable: true));
            CreateIndex("dbo.Foods", "FoodCategoryId");
            AddForeignKey("dbo.Foods", "FoodCategoryId", "dbo.FoodCategories", "Id", cascadeDelete: true);
            DropColumn("dbo.Foods", "FoodCategoryName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Foods", "FoodCategoryName", c => c.String());
            DropForeignKey("dbo.Foods", "FoodCategoryId", "dbo.FoodCategories");
            DropIndex("dbo.Foods", new[] { "FoodCategoryId" });
            AlterColumn("dbo.Foods", "FoodCategoryId", c => c.Int());
            RenameColumn(table: "dbo.Foods", name: "FoodCategoryId", newName: "FoodCategory_Id");
            CreateIndex("dbo.Foods", "FoodCategory_Id");
            AddForeignKey("dbo.Foods", "FoodCategory_Id", "dbo.FoodCategories", "Id");
        }
    }
}
