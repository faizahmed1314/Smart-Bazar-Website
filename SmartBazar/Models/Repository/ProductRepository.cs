using SmartBazar.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartBazar.Models.Repository
{
    public class ProductRepository : IProduct
    {
        SmartBazarEntities _db = new SmartBazarEntities();
        public void EditProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public void InsertProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> ViewProduct()
        {

            List<tbl_Product> dataList = _db.tbl_Product.ToList();

            List<Product> productlist = new List<Product>();

            foreach (var item in dataList)
            {
                Product c = new Product();
                c.pro_id = item.pro_id;
                c.pro_name = item.pro_name;
                c.pro_image1 = item.pro_image1;
                c.pro_image2 = item.pro_image2;
                c.pro_image3 = item.pro_image3;
                c.pro_des = item.pro_des;
                c.pro_price = item.pro_price;
                c.pro_fk_Cat_id = item.pro_fk_Cat_id;

                productlist.Add(c);
            }
            return productlist;
        }
    }
}