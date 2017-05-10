using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace hiophop.Models
{
    public class UserModel
    {
        [Key]
        [Required]
        //[EmailAddress]
        //[Display(Name = "Email")]
        public int userId { get; set; }

        [Required]
        //[EmailAddress]
        //[Display(Name = "Email")]
        public string email { get; set; }
        /// <summary>
        /// new stuff
        /// </summary>
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(100)]
        public string Proffession { get; set; }
        [Required]
        [StringLength(100)]
        public string FavGenre { get; set; }
        [Required]
        [StringLength(100)]
        public string FutureGenre { get; set; }

    }
}