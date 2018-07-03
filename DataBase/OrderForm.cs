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
    
    public partial class OrderForm
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderForm()
        {
            this.OrderFormQuestions = new HashSet<OrderFormQuestion>();
        }
    
        public long ID { get; set; }
        public string SectionTitle { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public long ServiceID { get; set; }
        public int OrderNo { get; set; }
        public bool IsActive { get; set; }
        public bool IsDelete { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public string UpdatedByID { get; set; }
        public string CreatedByID { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual AspNetUser AspNetUser1 { get; set; }
        public virtual Service Service { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderFormQuestion> OrderFormQuestions { get; set; }
    }
}
