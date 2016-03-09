using Ecommerce.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Ecommerce.Repository.Configurations
{
    public class DefaultContext : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Add(new ForeignKeyNamingConvention());
        }

        public DbSet<Users> UsersSet { get; set; }
        public DbSet<Client> ClientsSet { get; set; }
        public DbSet<Category> CategoriesSet { get; set; }
        public DbSet<Movie> MoviesSet { get; set; }
        public DbSet<Sales> SalesSet { get; set; }
        public DbSet<MovieSales> MovieSalesSet { get; set; }
    }
}