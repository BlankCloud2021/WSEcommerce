using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSEcommerce.PayPalHelper;

namespace WSEcommerce.Controllers
{
   

   

    [Route("cart")]
    public class PaymentController : Controller
    {
        public IConfiguration Configuration { get; }

        public PaymentController(IConfiguration configuration)
        {
            Configuration = configuration;
        }


       
        [HttpPost]
        [Route("checkout")]
        public async Task<IActionResult> Checkout(double total)
        {
            var payPalAPI = new PayPalAPI(Configuration);
            string url = await payPalAPI.getRedirectURLToPayPal(total, "USD");
            return Redirect(url);
        }
    }
}

