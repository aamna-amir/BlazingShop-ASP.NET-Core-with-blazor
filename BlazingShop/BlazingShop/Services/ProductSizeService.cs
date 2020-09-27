using BlazingShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingShop.Services
{
    public class ProductSizeService
    {
        private readonly ApplicationDbContext _db;
        public ProductSizeService(ApplicationDbContext db)
        {
            _db = db;
        }

        public ProductSize GetProductSize(int productSizeId)
        {
            ProductSize obj = new ProductSize();
            return _db.ProductSize.FirstOrDefault(u => u.Id == productSizeId);
        }

        public List<ProductSize> GetProductsSizes()
        {
            return _db.ProductSize.ToList();
        }

        public bool CreateProductSize(ProductSize objProductSize)
        {
            _db.ProductSize.Add(objProductSize);
            _db.SaveChanges();
            return true;
        }

        public bool UpdateProductSize(ProductSize objProductSize)
        {
            var existingProductSize = _db.ProductSize.FirstOrDefault(u => u.Id == objProductSize.Id);
            if (existingProductSize != null)
            {
                existingProductSize.Size = objProductSize.Size;
                _db.SaveChanges();
            }
            else
            {
                return false;
            }
            return true;
        }

        public bool DeleteProductSize(ProductSize objProductSize)
        {
            var existingProductSize = _db.ProductSize.FirstOrDefault(u => u.Id == objProductSize.Id);
            if (existingProductSize != null)
            {
                _db.ProductSize.Remove(existingProductSize);
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
}
