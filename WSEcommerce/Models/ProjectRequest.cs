using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WSEcommerce.Models
{
    public class ProjectRequest
    {
        [Key]
        public int ProjectRequestId { get; set; }

        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Breif Discription")]
        public string Discription { get; set; }

        [Display(Name = "Images")]
        [DataType(DataType.ImageUrl)]
        public int? ImageURl { get; set; }
    } 
}
