//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SoftBBM.Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class SoftReturnSupplier
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SoftReturnSupplier()
        {
            this.SoftReturnSupplierDetails = new HashSet<SoftReturnSupplierDetail>();
        }
    
        public int Id { get; set; }
        public Nullable<int> BranchId { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> TotalQuantity { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<bool> Status { get; set; }
    
        public virtual ApplicationUser ApplicationUser { get; set; }
        public virtual ApplicationUser ApplicationUser1 { get; set; }
        public virtual SoftBranch SoftBranch { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoftReturnSupplierDetail> SoftReturnSupplierDetails { get; set; }
        public virtual SoftSupplier SoftSupplier { get; set; }
    }
}
