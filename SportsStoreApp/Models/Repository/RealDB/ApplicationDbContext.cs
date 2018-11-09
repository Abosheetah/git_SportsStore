using Microsoft.EntityFrameworkCore;

namespace SportsStoreApp.Models.Repository.RealDB{
    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}
        public DbSet<Product> Products {get;set;}
        public DbSet<Category> Categories{get;set;}
    }
}