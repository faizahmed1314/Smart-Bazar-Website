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
    
    public partial class tbl_Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_Order()
        {
            this.tbl_ProductsOrdered = new HashSet<tbl_ProductsOrdered>();
        }
    
        public int o_id { get; set; }
        public string o_username { get; set; }
        public string o_phoneNo { get; set; }
        public string o_email { get; set; }
        public Nullable<System.DateTime> o_createdOn { get; set; }
        public Nullable<bool> o_approved { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ProductsOrdered> tbl_ProductsOrdered { get; set; }
    }
}
