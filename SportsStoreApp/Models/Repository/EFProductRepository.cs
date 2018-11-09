using System.Linq;
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
    }
}