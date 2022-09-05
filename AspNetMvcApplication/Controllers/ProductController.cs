using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AspNetMvcApplication.Models;
using AspNetMvcApplication.Models.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace AspNetMvcApplication.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            return View();
        }
        public IActionResult VeriAl()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VeriAl(string id, string a, string b)
        {
            var values = Request.RouteValues;
            return View();
        }
        public IActionResult Create()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product)
        {
            var inc = product;
            if (!ModelState.IsValid)
            {
                var message = ModelState.ToList();
                
                return View(product);
            }
            return View();
        }
       
    }
    

}

