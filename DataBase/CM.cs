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
    
    public partial class CM
    {
        public long ID { get; set; }
        public string PageName { get; set; }
        public string UniqueCode { get; set; }
        public string MetaTitle { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaContent { get; set; }
        public string MetaAuthor { get; set; }
        public string MetaOwner { get; set; }
        public string PageContent { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string UpdatedByID { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
