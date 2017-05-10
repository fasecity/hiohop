using hiophop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static hiophop.Models.CarMake;

namespace hiophop.Controllers
{
    public class CarController : Controller
    {
        List<Category> lstCat = new List<Category>()
        {
            new Category() { CategoryID = 1, CategoryName = "Dairy" },
            new Category() { CategoryID = 2, CategoryName = "Meat" },
            new Category() { CategoryID = 3, CategoryName = "Vegetable" }
        };

        List<Product> lstProd = new List<Product>()
        {
            new Product() { ProductID = 1, ProductName = "Cheese", CategoryID = 1 },
            new Product() { ProductID = 2, ProductName = "Milk", CategoryID = 1 },
            new Product() { ProductID = 3, ProductName = "Yogurt", CategoryID = 1 },
            new Product() { ProductID = 4, ProductName = "Beef", CategoryID = 2 },
            new Product() { ProductID = 5, ProductName = "Lamb", CategoryID = 2 },
            new Product() { ProductID = 6, ProductName = "Pork", CategoryID = 2 },
            new Product() { ProductID = 7, ProductName = "Broccoli", CategoryID = 3 },
            new Product() { ProductID = 8, ProductName = "Cabbage", CategoryID = 3 },
            new Product() { ProductID = 9, ProductName = "Pepper", CategoryID = 3 }
        };

        public ActionResult GetCategories()
        {
            return Json(lstCat, JsonRequestBehavior.AllowGet);
           
        }

        public ActionResult GetProducts(int intCatID)
        {
           
            var products = lstProd.Where(p => p.CategoryID == intCatID);
            return Json(products, JsonRequestBehavior.AllowGet);

        }
        [HttpGet]
        public ActionResult Index()
        {
           
            return View();
        }

        [HttpPost]
        public ActionResult Index(string c ,string p)
        {

            
            ViewBag.x ="Product:"+ p;
            ViewBag.y = "category" + c;
            return View();
        }
      
    }
}