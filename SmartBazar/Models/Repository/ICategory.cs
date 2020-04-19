using SmartBazar.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBazar.Models.Repository
{
    interface ICategory
    {
        void InsertCategory(Category category);
        void EditCategory(Category category);
        void ViewCategory();
        void GetCategoryById(int id);
    }
}
