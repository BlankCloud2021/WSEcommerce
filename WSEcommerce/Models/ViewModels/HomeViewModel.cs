using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSEcommerce.Models;

namespace WSEcommerce.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Products> productsOnSale { get; set; }
    }
}
