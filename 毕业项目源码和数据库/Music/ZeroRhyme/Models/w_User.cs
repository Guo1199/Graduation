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
    
    public partial class w_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public w_User()
        {
            this.list_Song = new HashSet<list_Song>();
            this.Notice = new HashSet<Notice>();
            this.StoreUp = new HashSet<StoreUp>();
            this.UserCommentary = new HashSet<UserCommentary>();
            this.w_Song = new HashSet<w_Song>();
        }
    
        public int userID { get; set; }
        public string useraccount { get; set; }
        public string userpwd { get; set; }
        public string username { get; set; }
        public string userimg { get; set; }
        public Nullable<int> userage { get; set; }
        public string usersex { get; set; }
        public string useremile { get; set; }
        public Nullable<System.DateTime> userbirthdays { get; set; }
        public Nullable<int> uaerIsAdmin { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<list_Song> list_Song { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notice> Notice { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StoreUp> StoreUp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserCommentary> UserCommentary { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<w_Song> w_Song { get; set; }
    }
}
