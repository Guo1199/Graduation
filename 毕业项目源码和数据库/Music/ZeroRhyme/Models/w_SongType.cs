//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZeroRhyme.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class w_SongType
    {
        public int typeID { get; set; }
        public string typeName { get; set; }
        public Nullable<int> songID { get; set; }
    
        public virtual w_Song w_Song { get; set; }
    }
}
