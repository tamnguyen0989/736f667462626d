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
    
    public partial class sys_Banner
    {
        public int Id { get; set; }
        public string Banner { get; set; }
        public string Banner_us { get; set; }
        public string BannerDescription { get; set; }
        public string BannerDescription_us { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<bool> Hide { get; set; }
        public string Link { get; set; }
        public string Link_us { get; set; }
        public Nullable<int> DisplayOrder { get; set; }
    }
}
