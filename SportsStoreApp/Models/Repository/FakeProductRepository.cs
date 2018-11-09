using System.Collections.Generic;
using System.Linq;

namespace SportsStoreApp.Models.Repository{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>{
            new Product{ID = 1 , Name = "Cap" , CategoryID = 1, Price = 56, Description ="for Football players"},
            new Product{ID = 2 , Name = "Gloves" , CategoryID = 1, Price = 156, Description =""},
            new Product{ID = 3 , Name = "Shoes" , CategoryID = 1, Price = 250, Description =""},
            new Product{ID = 4 , Name = "Towels" , CategoryID = 1, Price = 102, Description =""},
            new Product{ID = 5 , Name = "Golf bag" , CategoryID = 1, Price = 630, Description =""}
            
        }.AsQueryable();

        public void AddProduct(Product product)
        {
            throw new System.Exception("Not fount");
        }
    }
}