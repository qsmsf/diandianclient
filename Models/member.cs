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
    
    public partial class member
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public member()
        {
            this.cf_member = new HashSet<cf_member>();
            this.item_comment = new HashSet<item_comment>();
            this.item_recomment = new HashSet<item_recomment>();
            this.member_role = new HashSet<member_role>();
            this.redpacket_record = new HashSet<redpacket_record>();
            this.member_notice = new HashSet<member_notice>();
            this.table_member = new HashSet<table_member>();
            this.print_main = new HashSet<print_main>();
            this.shop_oper_log = new HashSet<shop_oper_log>();
            this.pay_bill = new HashSet<pay_bill>();
            this.sys_oper_log = new HashSet<sys_oper_log>();
        }
    
        public int memberkey { get; set; }
        public Nullable<int> shopkey { get; set; }
        public Nullable<int> postkey { get; set; }
        public Nullable<int> memberLevel { get; set; }
        public Nullable<int> type { get; set; }
        public string name { get; set; }
        public string loginName { get; set; }
        public string pwd { get; set; }
        public string secpwd { get; set; }
        public string icon { get; set; }
        public string tel { get; set; }
        public string email { get; set; }
        public Nullable<int> score { get; set; }
        public Nullable<double> balance { get; set; }
        public string WebSite1Uid { get; set; }
        public string WebSite2Uid { get; set; }
        public string WebSite3Uid { get; set; }
        public Nullable<int> enable { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<int> provinceId { get; set; }
        public Nullable<int> cityId { get; set; }
        public Nullable<int> areaId { get; set; }
        public string code { get; set; }
        public Nullable<int> parentMemberkey { get; set; }
        public Nullable<int> isDel { get; set; }
        public string token { get; set; }
        public decimal lat { get; set; }
        public decimal lng { get; set; }
        public Nullable<int> role { get; set; }
        public Nullable<int> agentid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cf_member> cf_member { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<item_comment> item_comment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<item_recomment> item_recomment { get; set; }
        public virtual shop shop { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<member_role> member_role { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<redpacket_record> redpacket_record { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<member_notice> member_notice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<table_member> table_member { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<print_main> print_main { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<shop_oper_log> shop_oper_log { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pay_bill> pay_bill { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sys_oper_log> sys_oper_log { get; set; }
    }
}