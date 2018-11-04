using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportsStoreApp.Models.Repository;

namespace SportsStoreApp.Controllers{
    public class ProductController : Controller{
        private IProductRepository _repo;
        public int PageSize = 4;
        
        public ProductController(IProductRepository repo){
            _repo = repo;
        }
        public ViewResult List(int productPage = 1) => View(_repo.Products
        .OrderBy(p => p.ID)
        .Skip((productPage - 1) * PageSize)
        .Take(PageSize));
    }
}