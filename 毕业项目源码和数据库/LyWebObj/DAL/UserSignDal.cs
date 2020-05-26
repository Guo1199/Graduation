using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace DAL
{
   public class UserSignDal
    {
        //登录查询是否有数据
        public static DataTable FindUserCheck(UserInfo user)
        {
            string sql = string.Format("select * from UserInfo where useraccount='{0}' and userpwd='{1}'", user.useraccount, user.userpwd);
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
        //添加用户
        public static bool AddUser(UserInfo user)
        {
            //定义SQL语
            string sql = string.Format("insert into UserInfo(useraccount,userpwd,username,usercard,useremile) values('{0}','{1}','{2}','{3}','{4}') ", user.useraccount, user.userpwd, user.username, user.usercard, user.useremile);
            //调用DBHelper类执行添加，接收返回的bool值
            bool result = DBHelper.GetExecuteNonQuery(sql);
            //返回结果给上一层BLL
            return result;
        }
       //修改
        public static bool SetNewPassword(UserInfo user)
        {
            //定义SQL语
            string sql = string.Format("uppdate UserInfo set userpwd='{0} '", user.userpwd);
            //调用DBHelper类执行添加，接收返回的bool值
            bool result = DBHelper.GetExecuteNonQuery(sql);
            //返回结果给上一层BLL
            return result;
        }
        public static DataTable FindUserByUserName(string userName)
        {
            string sql = string.Format("select * from UserInfo where userName='{0}'", userName);
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
       //验证是否存在
        public static DataTable FindUserforget(string useraccount)
        {
            string sql = string.Format("select * from UserInfo where useraccount='{0}'",useraccount);
            DataTable dt = DBHelper.GetDataTable(sql);
            return dt;
        }
    }
}
