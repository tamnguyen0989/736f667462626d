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
    
    public partial class donhang_ct
    {
        public long Id { get; set; }
        public long Sodh { get; set; }
        public long IdPro { get; set; }
        public double Soluong { get; set; }
        public Nullable<int> Dongia { get; set; }
        public int PriceAvg { get; set; }
    
        public virtual donhang donhang { get; set; }
        public virtual shop_bienthe shop_bienthe { get; set; }
    }
}
