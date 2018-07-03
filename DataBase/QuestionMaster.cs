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
    
    public partial class QuestionMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuestionMaster()
        {
            this.FileUploadSettings = new HashSet<FileUploadSetting>();
            this.OrderFormQuestions = new HashSet<OrderFormQuestion>();
            this.QuestionOptions = new HashSet<QuestionOption>();
        }
    
        public long ID { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionDescription { get; set; }
        public string Image { get; set; }
        public bool IsRequired { get; set; }
        public long QuestionTypeID { get; set; }
        public string LinerScaleLabel { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string CreatedByID { get; set; }
        public string UpdatedByID { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FileUploadSetting> FileUploadSettings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderFormQuestion> OrderFormQuestions { get; set; }
        public virtual QuestionType QuestionType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<QuestionOption> QuestionOptions { get; set; }
    }
}
