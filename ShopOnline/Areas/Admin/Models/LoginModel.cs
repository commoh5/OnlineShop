using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShopOnline.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Mời nhập User Name")]
        public string userName { get; set; }

        [Required(ErrorMessage = "Mời nhập Password")]
        public string passWord { get; set; }
        public bool rememberMe { get; set; }
    }
}