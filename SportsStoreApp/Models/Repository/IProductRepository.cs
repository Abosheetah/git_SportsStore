using System.Linq;

namespace SportsStoreApp.Models.Repository{
    public interface IProductRepository
    {
        IQueryable<Product> Products{get;}
        void AddProduct(Product product);
        Product GetProduct(int key);
        void UpdateProduct(Product product);
    }
}