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
    
    public partial class reservation
    {
        public int rid { get; set; }
        public string email { get; set; }
        public Nullable<long> phone { get; set; }
        public Nullable<System.DateTime> r_date { get; set; }
        public string r_time { get; set; }
        public Nullable<int> person { get; set; }
        public string msg { get; set; }
        public string person_name { get; set; }
    }
}
