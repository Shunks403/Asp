﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopProjectMVC.Core.Interfaces;
using ShopProjectMVC.Core.Models;

namespace ShopProjectMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public  ProductController(IProductService productService)
        {
            _productService = productService;
        }

        

        public IActionResult Products()
        {
            IEnumerable<Product> products = _productService.GetAll();
            return View(products); 
        }

       
    }
}
