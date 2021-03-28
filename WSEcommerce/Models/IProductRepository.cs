using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSEcommerce.Models
{
    public interface IProductRepository
    {
        IEnumerable<Products> GetAllProducts { get; }
        IEnumerable<Products> GetProductsOnSale { get; }
        Products GetProductById(int productId);
    }
}
