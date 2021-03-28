using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace WSEcommerce.Models
{
    public class Products
    {
        [Key]
        public int Product_Id { get; set; }

        [Display(Name = "Product Name")]
        [StringLength(50)]
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        public int? Weight { get; set; }
        public string Description { get; set; }

        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        [DataType(DataType.ImageUrl)]
        public string ImageThumbnailUrl { get; set; }

        public int Stock { get; set; }
        public bool InStock { get; set; }
        public bool OnSale { get; set; }
        
        public int Category_Id { get; set; }

        public Categories Catergory { get; set; }
    }
}
