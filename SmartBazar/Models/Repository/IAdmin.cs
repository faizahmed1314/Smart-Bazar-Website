using SmartBazar.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBazar.Models.Repository
{
    interface IAdmin
    {
        bool InsertAdmin(Admin admin);
    }
}
