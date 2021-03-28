using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WSEcommerce.Models;
using System.Data.SqlClient;

using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using WSEcommerce.ViewModels;

namespace WSEcommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly IConfiguration configuration;
        private readonly IProductRepository _productRepository;
        public HomeController(IConfiguration config, IProductRepository product)
        {
            this.configuration = config;
            _productRepository = product;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel()
            {
                productsOnSale = _productRepository.GetProductsOnSale
            };

            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
