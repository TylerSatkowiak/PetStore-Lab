using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dapper;
using PetStore.Models;
using Dapper.Contrib.Extensions;

namespace PetStore.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            IDbConnection db = new SqlConnection("Server=9QP7Q13\\SQLEXPRESS;Database=devbuildjoin;user id=sa;password=abc123");
            db.Open();
            
            
            db.Close();

            List<Product> cats = Product.ListAll();
            return View(cats);
        }

        [HttpPost]
        public void Update()
        {


        }


    }
}
