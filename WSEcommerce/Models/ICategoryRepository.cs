using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSEcommerce.Models
{
    public interface ICategoryRepository
    {
        public IEnumerable<Categories> GetAllCategories { get; }
    }
}
