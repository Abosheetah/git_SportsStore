using System.Linq;
using Microsoft.EntityFrameworkCore;
using SportsStoreApp.Models.Repository.RealDB;

namespace SportsStoreApp.Models.Repository{
    public class EFCategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext _db;
        public EFCategoryRepository(ApplicationDbContext db){
            _db = db;           
        }                
        public IQueryable<Category> Categories => _db.Categories;

        public void AddCategory(Category category)
        {
            _db.Categories.Add(category);
            _db.SaveChanges();
        }

        public void UpdateCategory(Category category){
            _db.Categories.Update(category);
            _db.SaveChanges();
        }

        public void DeleteCategory(Category category){
            _db.Categories.Remove(category);
            _db.SaveChanges();
        }

    }
}