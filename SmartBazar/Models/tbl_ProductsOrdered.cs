//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartBazar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_ProductsOrdered
    {
        public int op_id { get; set; }
        public Nullable<int> op_fk_Pro_id { get; set; }
        public Nullable<int> op_qty { get; set; }
        public Nullable<double> op_unitPrice { get; set; }
        public Nullable<double> op_total { get; set; }
        public Nullable<int> op_fk_O_id { get; set; }
    
        public virtual tbl_Order tbl_Order { get; set; }
        public virtual tbl_Product tbl_Product { get; set; }
    }
}