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
    
    public partial class Message
    {
        public long ID { get; set; }
        public string FromID { get; set; }
        public string ToID { get; set; }
        public long JobID { get; set; }
        public bool IsRead { get; set; }
        public long GroupId { get; set; }
        public string MessageText { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual Job Job { get; set; }
        public virtual MessageGroup MessageGroup { get; set; }
    }
}
