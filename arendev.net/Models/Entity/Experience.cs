//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace arendev.net.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Experience
    {
        public int Id { get; set; }
        public string Employer { get; set; }
        public string JobTitle { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public short Status { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
    }
}
