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
    
    public partial class dd_qrcode_printaudit
    {
        public int id { get; set; }
        public Nullable<int> batchkey { get; set; }
        public Nullable<sbyte> state { get; set; }
        public string receivedate { get; set; }
        public string audittime { get; set; }
        public string audituser { get; set; }
        public string userid { get; set; }
        public string getqrtime { get; set; }
        public Nullable<int> getqruser { get; set; }
    }
}