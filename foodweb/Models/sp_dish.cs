//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace foodweb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class sp_dish
    {
        public int dishid { get; set; }
        public string dishname { get; set; }
        public Nullable<int> catid { get; set; }
        public string details { get; set; }
        public Nullable<int> price { get; set; }
        public string img { get; set; }
    
        public virtual category category { get; set; }
    }
}
