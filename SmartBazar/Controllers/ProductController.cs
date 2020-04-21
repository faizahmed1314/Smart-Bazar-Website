using SmartBazar.Models;
using SmartBazar.Models.Repository;
using SmartBazar.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartBazar.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository _productRepository = new ProductRepository();
        // GET: Product

        public ActionResult Index()
        {
            List<Product> products = _productRepository.ViewProduct().ToList();
            ViewBag.productList = products;
            return View();
        }

        public ActionResult Product(int? id)
        {
            ProductRepository _productRepository = new ProductRepository();

            List<Product> products = _productRepository.ViewProduct().Where(x => x.pro_fk_Cat_id == id).ToList();
            ViewBag.productList = products;
            return View();
        }
        public ActionResult Create()
        {
            var dataList = _productRepository.CategoryList();
            ViewBag.categoryList = new SelectList(dataList, "cat_id", "cat_name");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Product product,HttpPostedFileBase imgFile)
        {
            var dataList = _productRepository.CategoryList();
            ViewBag.categoryList = new SelectList(dataList, "cat_id", "cat_name");

            string path = UploadImageFile(imgFile);
            if (path.Equals("-1"))
            {
                ViewBag.ErrorMessage = "File could not be uploaded......";
            }
            else
            {
                product.pro_image1 = path;
                _productRepository.InsertProduct(product);
                ViewBag.SuccessMessage = "Successfull";
                return RedirectToAction("Index");
               
            }
            
            return View();
        }

        [NonAction]
        public string UploadImageFile(HttpPostedFileBase file)
        {
            Random r = new Random();
            string path = "-1";
            int random = r.Next();
            if (file != null && file.ContentLength > 0)
            {
                string extension = Path.GetExtension(file.FileName);
                if (extension.ToLower().Equals(".jpg") || extension.ToLower().Equals(".jpeg") || extension.ToLower().Equals(".png"))
                {
                    try
                    {
                        path = Path.Combine(Server.MapPath("~/Content/upload"), random + Path.GetFileName(file.FileName));
                        file.SaveAs(path);

                        path = "~/Content/upload/" + random + Path.GetFileName(file.FileName);
                    }
                    catch (Exception ex)
                    {
                        path = "-1";
                    }
                }
                else
                {
                    Response.Write("<script>alert('Only jpg jpeg and png file format are acceptable.....');</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('Please select a file.....');</script>");
                path = "-1";
            }
            return path;
        }

    }
}