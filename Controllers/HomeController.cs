using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using PetStore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace PetStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Create
            /*
            Product prod = Product.Create("Kitty Litter", 13.95m);
            return Content($"{prod.id} {prod.Name} {prod.Price}");
            */

            //Update
            /*
            Product prod = Product.Read(2);
            prod.Price = 19.00m;
            prod.Save();
            return Content($"{prod.id} {prod.Name} {prod.Price}");
            */

            return View();

        }
        public IActionResult Add()
        {
            
            return View();
        }

        public IActionResult Admin()
        {

            return View();
        }

        public IActionResult EditName()
        {


            return View();
        }
        public IActionResult EditPrice()
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
