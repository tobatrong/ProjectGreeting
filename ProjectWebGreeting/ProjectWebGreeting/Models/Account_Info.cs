//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectWebGreeting.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account_Info
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string Country { get; set; }
        public string State { get; set; }
        public Nullable<int> mobile { get; set; }
        public string email { get; set; }
        public string username { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
