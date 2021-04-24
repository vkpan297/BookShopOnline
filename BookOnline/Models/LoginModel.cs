using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookOnline.Models
{
    public class LoginModel
    {
        [Required]
        public string username { get; set; }

        public string pass { get; set; }
        public bool rememberme { get; set; }
    }
}