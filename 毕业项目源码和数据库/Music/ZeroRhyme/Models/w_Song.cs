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
    
    public partial class w_Song
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public w_Song()
        {
            this.list_Song = new HashSet<list_Song>();
            this.StoreUp1 = new HashSet<StoreUp>();
            this.UserCommentary = new HashSet<UserCommentary>();
            this.w_SongType = new HashSet<w_SongType>();
        }
    
        public int songID { get; set; }
        public string songName { get; set; }
        public Nullable<int> typeID { get; set; }
        public string songGeci { get; set; }
        public string songerimg { get; set; }
        public string songFile { get; set; }
        public Nullable<int> StoreUp { get; set; }
        public Nullable<int> userID { get; set; }
        public Nullable<int> singerID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<list_Song> list_Song { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreUp> StoreUp1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserCommentary> UserCommentary { get; set; }
        public virtual w_Singer w_Singer { get; set; }
        public virtual w_User w_User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<w_SongType> w_SongType { get; set; }
    }
}
