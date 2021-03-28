using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WSEcommerce.Models
{
    public class Orders
    {
        [Key]
        public int Order_Id { get; set; }   

        [Display(Name = "Items Ordered")]
        public int NumberOfItemsOrdered { get; set; }

        [Display(Name = "Shipping Address")]
        public string ShippingAddress { get; set; }

        [DataType(DataType.EmailAddress)]
        public string OrderEmail { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        public bool OrderCompleted { get; set; }

        public int Customer_Id { get; set; }
        public Customers Customers { get; set; }

    }
}
