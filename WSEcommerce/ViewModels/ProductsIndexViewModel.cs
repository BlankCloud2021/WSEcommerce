using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSEcommerce.Models;

namespace WSEcommerce.ViewModels
{
    public class ProductsIndexViewModel
    {
        public IEnumerable<Products> Products { get; set; }
        public string CurrentCategory { get; set; }
    }
}
