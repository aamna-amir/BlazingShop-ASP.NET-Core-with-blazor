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
    }
}
