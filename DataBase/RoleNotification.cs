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
    
    public partial class RoleNotification
    {
        public long ID { get; set; }
        public string RoleID { get; set; }
        public long NotificationID { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string UpdatedByID { get; set; }
    
        public virtual AspNetRole AspNetRole { get; set; }
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Notification Notification { get; set; }
    }
}