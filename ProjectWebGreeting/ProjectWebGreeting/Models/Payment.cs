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
    
    public partial class Payment
    {
        public string accountUsername { get; set; }
        public int serviceId { get; set; }
        public Nullable<decimal> amount { get; set; }
        public Nullable<System.DateTime> expiryDate { get; set; }
        public Nullable<int> paymentNumber { get; set; }
        public string ssuerName { get; set; }
    
        public virtual Account Account { get; set; }
        public virtual Service Service { get; set; }
    }
}