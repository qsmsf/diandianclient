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
    
    public partial class income_record
    {
        public int incomerecordkey { get; set; }
        public Nullable<int> shopkey { get; set; }
        public Nullable<double> price { get; set; }
        public Nullable<System.DateTime> createDate { get; set; }
        public Nullable<System.DateTime> clearingDate { get; set; }
        public Nullable<int> state { get; set; }
        public string isxingye { get; set; }
        public Nullable<sbyte> issever { get; set; }
    
        public virtual shop shop { get; set; }
    }
}
