//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DianDianClient.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class interaction_record
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public interaction_record()
        {
            this.cf_detail = new HashSet<cf_detail>();
            this.cf_detail1 = new HashSet<cf_detail>();
        }
    
        public int interactionrecordkey { get; set; }
        public string cfmealkey { get; set; }
        public string cfmealkeyTarget { get; set; }
        public Nullable<int> direct { get; set; }
        public Nullable<int> type { get; set; }
        public string introduce { get; set; }
        public string remark { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<int> memberkey { get; set; }
        public string flagMemberkey { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cf_detail> cf_detail { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cf_detail> cf_detail1 { get; set; }
    }
}
