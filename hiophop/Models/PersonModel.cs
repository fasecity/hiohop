using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace hiophop.Models
{
    public class PersonModel
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string taste { get; set; }
      
    }
}