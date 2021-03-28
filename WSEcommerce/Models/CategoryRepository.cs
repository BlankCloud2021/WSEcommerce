using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSEcommerce.Data;

namespace WSEcommerce.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly WSEcommerceDbContext _wSEcommercedbContext;

        public CategoryRepository(WSEcommerceDbContext wSEcommerceDbContext) 
        {
            _wSEcommercedbContext = wSEcommerceDbContext;

        }
        public IEnumerable<Categories> GetAllCategories => _wSEcommercedbContext.Categories;
        
    }
}
