//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuiGigAPI.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class PlanRole
    {
        public long ID { get; set; }
        public string RoleID { get; set; }
        public long PlanID { get; set; }
    
        public virtual AspNetRole AspNetRole { get; set; }
        public virtual SubscriptionPlan SubscriptionPlan { get; set; }
    }
}
