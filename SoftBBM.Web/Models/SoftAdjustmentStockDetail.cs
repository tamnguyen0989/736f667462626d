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
    
    public partial class SoftAdjustmentStockDetail
    {
        public int AdjustmentId { get; set; }
        public int ProductId { get; set; }
        public Nullable<int> Quantity { get; set; }
    
        public virtual SoftAdjustmentStock SoftAdjustmentStock { get; set; }
        public virtual shop_sanpham shop_sanpham { get; set; }
    }
}
