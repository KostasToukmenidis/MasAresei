using System;
using System.Data.Entity;
using System.Linq;
using MasAresei.Models;

namespace MasAresei
{
    public class MasAreseiDbContext : DbContext
    {
        public MasAreseiDbContext()
            : base("name=MasAreseiDbConStr")
        {
        }
        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<FoodCategory> FoodCategories { get; set; }

        public virtual DbSet<Food> Foods { get; set; }

        public virtual DbSet<Ingredient> Ingridients { get; set; }


        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Food>()
        //        .HasMany<Ingredient>(f => f.Ingredients)
        //        .WithMany(i => i.Foods)
        //        .Map(fi =>
        //        {
        //            fi.MapLeftKey("FoodId");
        //            fi.MapRightKey("IngredientId");
        //            fi.ToTable("FoodIngredients");
        //        });
        //}
    }
}