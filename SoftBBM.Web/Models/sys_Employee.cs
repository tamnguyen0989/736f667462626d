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
    
    public partial class sys_Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Pwd { get; set; }
        public string Roles { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int EmployeeCreate { get; set; }
        public System.DateTime DateCreate { get; set; }
        public Nullable<int> EmployeeUpdate { get; set; }
        public Nullable<System.DateTime> DateUpdate { get; set; }
    }
}
