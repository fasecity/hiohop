using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace hiophop.Models
{
    public class CarMake
    {
        public class Category
        {
            public int CategoryID { get; set; }
            public string CategoryName { get; set; }

        }

        public class Product
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public int CategoryID { get; set; }
        }
    }
}