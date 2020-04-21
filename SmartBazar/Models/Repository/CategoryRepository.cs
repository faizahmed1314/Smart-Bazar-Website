using SmartBazar.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartBazar.Models.Repository
{
    public class CategoryRepository : ICategory
    {
        SmartBazarEntities _db = new SmartBazarEntities();
        public void EditCategory(Category item)
        {
            tbl_Category c = _db.tbl_Category.Where(x => x.cat_id == item.cat_id).SingleOrDefault();
            c.cat_id = item.cat_id;
            c.cat_name = item.cat_name;
            c.cat_createdOn = DateTime.Now;
            c.cat_icon = item.cat_icon;
            c.cat_color = item.cat_color;
            c.cat_fk_Ad_id = item.cat_fk_Ad_id;

           
            _db.SaveChanges();
        }

        public Category GetCategoryById(int id)
        {
            tbl_Category item = _db.tbl_Category.Where(x => x.cat_id == id).SingleOrDefault();

            Category c = new Category();
            c.cat_id = item.cat_id;
            c.cat_name = item.cat_name;
            c.cat_createdOn = DateTime.Now;
            c.cat_icon = item.cat_icon;
            c.cat_color = item.cat_color;
            c.cat_fk_Ad_id = item.cat_fk_Ad_id;

            return c;

           
        }

        public bool InsertCategory(Category category)
        {
            bool isAdded = false;
            tbl_Category c = new tbl_Category();
            c.cat_id = category.cat_id;
            c.cat_name = category.cat_name;
            c.cat_createdOn = DateTime.Now;
            c.cat_icon = category.cat_icon;
            c.cat_color = category.cat_color;
            c.cat_fk_Ad_id = category.cat_fk_Ad_id;

            _db.tbl_Category.Add(c);
            int rowAffected=_db.SaveChanges();
            if (rowAffected > 0)
            {
                isAdded = true;
            }
            return isAdded;
        }

        public List<Category> ViewCategory()
        {
            List<tbl_Category> dataList= _db.tbl_Category.ToList();

            List<Category> categorylist = new List<Category>();

            foreach(var item in dataList)
            {
                Category c = new Category();
                c.cat_id = item.cat_id;
                c.cat_name = item.cat_name;
                c.cat_createdOn = item.cat_createdOn;
                c.cat_icon = item.cat_icon;
                c.cat_color = item.cat_color;
                c.cat_fk_Ad_id = item.cat_fk_Ad_id;

                categorylist.Add(c);
            }
            return categorylist;
        }
    }
}