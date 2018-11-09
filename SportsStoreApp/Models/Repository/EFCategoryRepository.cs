using System.Linq;
using SportsStoreApp.Models.Repository.RealDB;

namespace SportsStoreApp.Models.Repository{
    public class EFCategoryRepository : ICategoryRepository
    {
        private ApplicationDbContext _db;
        public IQueryable<Category> Categories => _db.Categories;

        public void AddCategory(Category category)
        {
            _db.Categories.Add(category);
        }
    }
}