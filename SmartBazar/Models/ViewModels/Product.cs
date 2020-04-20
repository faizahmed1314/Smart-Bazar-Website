using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartBazar.Models.ViewModels
{
    public class Product
    {
        public int pro_id { get; set; }
        public string pro_name { get; set; }
        public string pro_image1 { get; set; }
        public string pro_image2 { get; set; }
        public string pro_image3 { get; set; }
        public string pro_des { get; set; }
        public Nullable<double> pro_price { get; set; }
        public Nullable<int> pro_fk_Cat_id { get; set; }
    }
}