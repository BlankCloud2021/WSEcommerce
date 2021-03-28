using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WSEcommerce.Models
{
    public class Customers
    {
        [Key]
        public int Customer_Id { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Billing Adress")]
        public string BillingAddress { get; set; }

        public string DefaultShippingAddress { get; set; }
        public string Country { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int PhoneNumber { get; set; }


    }
}
