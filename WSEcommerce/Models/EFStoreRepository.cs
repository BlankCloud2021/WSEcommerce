using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSEcommerce.Data;

namespace WSEcommerce.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private WSEcommerceDbContext _context;

        public EFStoreRepository(WSEcommerceDbContext ctx)
        {
            _context = ctx;
        }

        public IQueryable<Products> Products => _context.Products;
    }
}
