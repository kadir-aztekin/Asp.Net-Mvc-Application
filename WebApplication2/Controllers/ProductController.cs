using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrnekUygulama1.Models;
using OrnekUygulama1.Models.ViewModels;
using System.Collections.Generic;

namespace OrnekUygulama1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetProducts()
        {
            return View();
        }
        public IActionResult VeriAl( )
        {
            return View();
        }
        [HttpPost]
        public IActionResult VeriAl(string id,string a,string b)
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
            return View();
        }
       
    }
    

}

