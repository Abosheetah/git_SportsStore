using System.Linq;
using Microsoft.EntityFrameworkCore;
using SportsStoreApp.Models.Repository.RealDB;

namespace SportsStoreApp.Models.Repository{
    public class EFProductRepository : IProductRepository
    {
        private ApplicationDbContext dBContext;
        public EFProductRepository(ApplicationDbContext ctx){
            dBContext = ctx;
            
        }
        public IQueryable<Product> Products => dBContext.Products;

        public void AddProduct(Product product)
        {
            dBContext.Products.Add(product);
            dBContext.SaveChanges();            
        }

        public Product GetProduct(int key)
        {
            return dBContext.Products.Find(key);
        }

        public void UpdateProduct(Product product)
        {
            dBContext.Products.Update(product);            
            dBContext.SaveChanges();
        }
    }
}