using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WSEcommerce.Models
{
    public interface IStoreRepository
    {
        IQueryable<Products> Products { get; }
    }
}
