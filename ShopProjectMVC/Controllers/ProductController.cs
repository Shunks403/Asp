using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopProjectMVC.Core.Interfaces;

namespace ShopProjectMVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Products()
        {
            return View(); 
        }

       
    }
}
