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
            List<Category> categories = _categoryRepository.ViewCategory();
            ViewBag.categoryList = categories;

            return View();
        }

        public ActionResult CreateCategory()
        {
            if (Session["ad_id"] == null)
            {
                return RedirectToAction("AdminLogin");
            }
            return View();
        }

        [HttpPost]
        public ActionResult CreateCategory(Category category)
        {
            category.cat_fk_Ad_id = Convert.ToInt32(Session["ad_id"].ToString());

            CategoryRepository _categoryRepository = new CategoryRepository();
            bool isAdded=_categoryRepository.InsertCategory(category);
            if (isAdded)
            {
                return RedirectToAction("Index");
            }



            ViewBag.ErrorMessage = "Create category unsuccessfull!";
            return View();
        }




        public ActionResult AdminSignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminSignUp(Admin admin)
        {
            if (ModelState.IsValid)
            {
                AdminRepository _adminRepository = new AdminRepository();
                bool isAdded=_adminRepository.InsertAdmin(admin);
                if (isAdded)
                {
                    return RedirectToAction("index");
                }
                
            }


            return View(admin);
        }

        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(Admin admin)
        {
            if (admin.ad_username != null && admin.ad_password != null)
            {
                AdminRepository _adminRepository = new AdminRepository();
                var person = _adminRepository.AdminLogin(admin);
                if (person != null)
                {
                    Session["ad_id"] = person.ad_id.ToString();
                    Session["ad_username"] = person.ad_username.ToString();
                    return RedirectToAction("CreateCategory");
                }





            }
            return View();

        }



    }
}