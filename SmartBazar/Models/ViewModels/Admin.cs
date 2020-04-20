using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SmartBazar.Models.ViewModels
{
    public class Admin
    {
        public int ad_id { get; set; }
        public string ad_username { get; set; }
        
        public string ad_password { get; set; }

        [Compare("ad_password",ErrorMessage ="Your password is incorrect!")]
        public string ad_confirmPassword { get; set; }
        public Nullable<System.DateTime> ad_createdOn { get; set; }
        public string ad_email { get; set; }
    }
}