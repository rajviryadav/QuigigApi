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
    
    public partial class OrderFormQuestion
    {
        public long ID { get; set; }
        public long OrderFormID { get; set; }
        public long QuestionID { get; set; }
        public Nullable<int> OrderNo { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string CreatedByID { get; set; }
        public string UpdatedByID { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual OrderForm OrderForm { get; set; }
        public virtual QuestionMaster QuestionMaster { get; set; }
    }
}
