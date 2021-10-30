namespace MasAresei.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovingIngredientEntity : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Ingredients", "FoodId", "dbo.Foods");
            DropIndex("dbo.Ingredients", new[] { "FoodId" });
            DropTable("dbo.Ingredients");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        FoodId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Ingredients", "FoodId");
            AddForeignKey("dbo.Ingredients", "FoodId", "dbo.Foods", "Id", cascadeDelete: true);
        }
    }
}
