using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SportsStoreApp.Models;
using SportsStoreApp.Models.Repository;

namespace SportsStoreApp.Controllers{
    public class ProductController : Controller{
        private IProductRepository _repo;
        public int PageSize = 4;
        
        public ProductController(IProductRepository repo){
            _repo = repo;
        }
        public ViewResult List(int productPage = 1){
            return View(_repo.Products);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product){
            _repo.AddProduct(product);
            return RedirectToAction(nameof(List));
        }
    }
}