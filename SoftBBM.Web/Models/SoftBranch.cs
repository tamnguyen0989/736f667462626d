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
    
    public partial class SoftBranch
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SoftBranch()
        {
            this.ApplicationUserSoftBranches = new HashSet<ApplicationUserSoftBranch>();
            this.donhangs = new HashSet<donhang>();
            this.SoftAdjustmentStocks = new HashSet<SoftAdjustmentStock>();
            this.SoftBranchProductStocks = new HashSet<SoftBranchProductStock>();
            this.SoftNotifications = new HashSet<SoftNotification>();
            this.SoftNotifications1 = new HashSet<SoftNotification>();
            this.SoftOrders = new HashSet<SoftOrder>();
            this.SoftReturnSuppliers = new HashSet<SoftReturnSupplier>();
            this.SoftStockIns = new HashSet<SoftStockIn>();
            this.SoftStockIns1 = new HashSet<SoftStockIn>();
            this.SoftStockIns2 = new HashSet<SoftStockIn>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> Priority { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApplicationUserSoftBranch> ApplicationUserSoftBranches { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<donhang> donhangs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoftAdjustmentStock> SoftAdjustmentStocks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoftBranchProductStock> SoftBranchProductStocks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoftNotification> SoftNotifications { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoftNotification> SoftNotifications1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoftOrder> SoftOrders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoftReturnSupplier> SoftReturnSuppliers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoftStockIn> SoftStockIns { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoftStockIn> SoftStockIns1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoftStockIn> SoftStockIns2 { get; set; }
    }
}