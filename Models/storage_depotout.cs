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
    
    public partial class storage_depotout
    {
        public int depotoutid { get; set; }
        public string createdate { get; set; }
        public Nullable<int> depotid { get; set; }
        public string dutyperson { get; set; }
        public Nullable<int> shopkey { get; set; }
        public Nullable<int> itemkey { get; set; }
        public Nullable<decimal> salemoney { get; set; }
        public Nullable<sbyte> type { get; set; }
    }
}