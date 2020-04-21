using SmartBazar.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SmartBazar.Models.Repository
{
    public class AdminRepository:IAdmin
    {
        SmartBazarEntities _db = new SmartBazarEntities();

        public bool InsertAdmin(Admin admin)
        {
            bool isAdded = false;
            tbl_Admin p = new tbl_Admin();
            p.ad_id = admin.ad_id;
            p.ad_username = admin.ad_username;
            p.ad_createdOn = DateTime.Now;
            p.ad_password = admin.ad_password;
            p.ad_email = admin.ad_email;
            
            

            _db.tbl_Admin.Add(p);
            int rowAffected=_db.SaveChanges();
            if (rowAffected > 0)
            {
                isAdded = true;
            }
            return isAdded;
        }

        public tbl_Admin AdminLogin(Admin admin)
        {
            
            tbl_Admin person = _db.tbl_Admin.Where(x => x.ad_username == admin.ad_username && x.ad_password == admin.ad_password).SingleOrDefault();

            return person;
            
        }
    }
}