using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WSEcommerce.Models
{
    public class Categories
    {
        [Key]
        public int Categories_Id { get; set; }

        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Description")]
        public string CategoryDescription { get; set; }
        public List<Products> Products { get; set; }

    }
}
