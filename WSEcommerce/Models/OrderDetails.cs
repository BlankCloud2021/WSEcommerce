using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WSEcommerce.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetails_Id { get; set; }
        public int Order_Id { get; set; }
        public int Product_Id { get; set; }
        public List<Products> Products { get; set; }


    }
}
