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
    
    public partial class sys_role
    {
        public long sysroleid { get; set; }
        public Nullable<long> superroleid { get; set; }
        public string rolename { get; set; }
        public string descb { get; set; }
        public string state { get; set; }
        public string createtime { get; set; }
        public Nullable<int> shopkey { get; set; }
        public string isdel { get; set; }
        public Nullable<int> agentid { get; set; }
        public string rtype { get; set; }
    }
}