using SmartBazar.Models.Repository;
using SmartBazar.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartBazar.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            CategoryRepository _categoryRepository = new CategoryRepository();
            List<Category> categories= _categoryRepository.ViewCategory();
            ViewBag.categoryList = categories;

            return View();
        }

        public ActionResult Product(int? id)
        {
            ProductRepository _productRepository = new ProductRepository();

            List<Product> products = _productRepository.ViewProduct().Where(x => x.pro_fk_Cat_id == id).ToList();
            ViewBag.productList = products;
            return View();
        }



    }
}