using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //用户类
    public class UserInfo
    {
        public int userid { get; set; }//用户ID
        public string useraccount { get; set; }//用户账号
        public string userpwd { get; set; }//用户密码
        public string username { get; set; }//用户名
        public string usercard { get; set; }//用户身份证
        public string userimg { get; set; }//用户头像路径
        public int userage { get; set; }//用户年龄
        public string usersex { get; set; }//用户性别
        public string useremile { get; set; }//用户邮箱
        public DateTime userbirthdays { get; set; }//用户生日

    }
}
