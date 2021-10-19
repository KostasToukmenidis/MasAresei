using System;
using System.Data.Entity;
using System.Linq;
using MasAresei.Models;

namespace MasAresei
{
    public class MasAreseiDbContext : DbContext
    {
        // Your context has been configured to use a 'MasAreseiDbContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'MasAresei.MasAreseiDbContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'MasAreseiDbContext' 
        // connection string in the application configuration file.
        public MasAreseiDbContext()
            : base("name=MasAreseiDbConStr")
        {
        }
        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Order> Orders { get; set; }

        public virtual DbSet<FoodCategory> FoodCategories { get; set; }

        public virtual DbSet<Food> Foods { get; set; }

        public virtual DbSet<Ingridient> Ingridients { get; set; }


        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}