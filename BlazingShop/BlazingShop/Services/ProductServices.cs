using BlazingShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace BlazingShop.Services
{
    public class ProductServices
    {
        private readonly ApplicationDbContext _db;
        public ProductServices(ApplicationDbContext db)
        {
            _db = db;
        }

        public Product GetProduct(int productId)
        {
            Product obj = new Product();
            return _db.Products.Include(u => u.Category).Include(u => u.ProductSize).FirstOrDefault(u => u.Id == productId);
        }

        public List<Product> GetProducts()
        {
            return _db.Products.Include(u => u.Category).Include(u => u.ProductSize).ToList();
        }

        public List<Category> GetCategoryList()
        {
            return _db.Categories.ToList();
        }

        public List<ProductSize> GetProductSizeList()
        {
            return _db.ProductSize.ToList();
        }

        public bool CreateProduct(Product objProduct)
        {
            _db.Products.Add(objProduct);
            _db.SaveChanges();
            return true;
        }

        public bool UpdateProduct(Product objProduct)
        {
            var existingProduct = _db.Products.FirstOrDefault(u => u.Id == objProduct.Id);

            if (objProduct.Image == null)
            {
                objProduct.Image = existingProduct.Image;
            }
            if (existingProduct != null)
            {
                _db.Products.Update(objProduct);
                _db.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool DeleteProduct(Product objProduct)
        {
            var existingProduct = _db.Products.FirstOrDefault(u => u.Id == objProduct.Id);
            if (existingProduct != null)
            {
                _db.Products.Remove(existingProduct);
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
