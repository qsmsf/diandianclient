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
    
    public partial class dd_mem_coupons
    {
        public int id { get; set; }
        public Nullable<int> couponid { get; set; }
        public string addtime { get; set; }
        public Nullable<bool> isuse { get; set; }
        public Nullable<int> userid { get; set; }
        public string mealkey { get; set; }
        public string usetime { get; set; }
        public string orderno { get; set; }
    }
}