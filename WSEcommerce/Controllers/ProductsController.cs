using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WSEcommerce.Models;
using WSEcommerce.ViewModels;

namespace WSEcommerce.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductsController(IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var productIndexViewModel = new ProductsIndexViewModel();
            productIndexViewModel.Products = _productRepository.GetAllProducts;
            productIndexViewModel.CurrentCategory = "Best Sellers";

            return View(productIndexViewModel);
        }
        public IActionResult ItemPage(int id)
        {
            var Product = _productRepository.GetProductById(id);
            if (Product == null)
                return NotFound();

            return View(Product);
        }
        public IActionResult PreviousWork()
        {
            var productIndexViewModel = new ProductsIndexViewModel();
            productIndexViewModel.Products = _productRepository.GetAllProducts;

            return View(productIndexViewModel);
        }
    }
}
