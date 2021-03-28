using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSEcommerce.Data;

namespace WSEcommerce.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly WSEcommerceDbContext _wSEcommercedbContext;

        public ProductRepository(WSEcommerceDbContext wSEcommerceDbContext)
        {
            _wSEcommercedbContext = wSEcommerceDbContext; 
        }
        public IEnumerable<Products> GetAllProducts     
        {
            get 
            { return _wSEcommercedbContext.Products.Include(p => p.Catergory); }
        }

        public IEnumerable<Products> GetProductsOnSale
        {
            get { return _wSEcommercedbContext.Products.Include(p => p.Catergory).Where(p => p.OnSale); }
        }

        public Products GetProductById(int productId)
        {
            return _wSEcommercedbContext.Products.FirstOrDefault(p => p.Product_Id == productId);
        }
    }
}
