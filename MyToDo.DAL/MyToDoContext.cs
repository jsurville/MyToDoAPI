using MyToApp.Models;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace MyToDoApp.DAL
{
    public class MyToDoContext : DbContext
    {
        public MyToDoContext() : base("Amellia")
        { }
        public DbSet<Price> Prices { get; set; }

    }

    public class Configuration : DbMigrationsConfiguration<MyToDoContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }
    }
}
