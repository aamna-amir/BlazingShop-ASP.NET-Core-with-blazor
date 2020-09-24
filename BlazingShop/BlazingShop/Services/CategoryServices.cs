using BlazingShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Services
{
    public class CategoryServices
    {
        private readonly ApplicationDbContext _db;
        public CategoryServices(ApplicationDbContext db)
        {
            _db = db;
        }

        public Category GetCategory(int categoryId)
        {
            Category obj = new Category();
            return _db.Categories.FirstOrDefault(u => u.Id == categoryId);
        }

        public List<Category> GetCategories(int categoryId)
        {
            return _db.Categories.ToList();
        }

        public bool CreateCategory(Category objCategory)
        {
            _db.Categories.Add(objCategory);
            _db.SaveChanges();
            return true;
        }

        public bool UpdateCategory(Category objCategory)
        {
            var existingCategory = _db.Categories.FirstOrDefault(u => u.Id == objCategory.Id);
            if(existingCategory != null)
            {
                existingCategory.Name = objCategory.Name;
                _db.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool DeleteCategory(Category objCategory)
        {
            var existingCategory = _db.Categories.FirstOrDefault(u => u.Id == objCategory.Id);
            if (existingCategory != null)
            {
                _db.Categories.Remove(existingCategory);
                _db.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
