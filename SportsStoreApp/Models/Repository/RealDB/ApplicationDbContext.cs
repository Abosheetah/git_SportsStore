using Microsoft.EntityFrameworkCore;

namespace SportsStoreApp.Models.Repository.RealDB{
    public class ApplicationDbContext : DbContext{
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

         protected override void OnModelCreating(ModelBuilder modelBuilder){
            
            // modelBuilder.Entity<Category>(entity =>
            // {
            //     entity.Property(e => e.Name).IsRequired();
            // });

            modelBuilder.Entity<Category>().HasData(new Category {ID = 1 , Name = "MAM" , Description = "MAM"});
        }
        
        public DbSet<Product> Products {get;set;}
        public DbSet<Category> Categories{get;set;}
        
    }
}