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
    
    public partial class dd_order_refund
    {
        public int id { get; set; }
        public string reorderno { get; set; }
        public string orderno { get; set; }
        public string addtime { get; set; }
        public Nullable<bool> status { get; set; }
        public string successtime { get; set; }
        public Nullable<decimal> refund_fee { get; set; }
        public Nullable<int> paytype { get; set; }
        public string cfmealkey { get; set; }
    }
}