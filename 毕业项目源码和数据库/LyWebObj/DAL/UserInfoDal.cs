using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace DAL
{
    public class UserInfoDal
    {
        /// <summary>
        /// 查询所有用户
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public static List<UserInfo> SelectUserAll() {
            string sql = "select * from UserInfo";
            DataTable dt=DBHelper.GetDataTable(sql);
            //创建集合
            List<UserInfo> list = new List<UserInfo>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    UserInfo userinfo = new UserInfo();
                    userinfo.userid = Convert.ToInt32(item["userid"]);
                    userinfo.useraccount = item["useraccount"].ToString();
                    userinfo.userpwd = item["userpwd"].ToString();
                    userinfo.username = item["username"].ToString();
                    userinfo.usercard = item["usercard"].ToString();
                    userinfo.userimg = item["userimg"].ToString();
                    userinfo.userage = Convert.ToInt32(item["userage"]);
                    userinfo.usersex = item["usersex"].ToString();
                    userinfo.useremile = item["useremile"].ToString();
                    userinfo.userbirthdays = Convert.ToDateTime(item["useremile"]);
                    //添加到集合
                    list.Add(userinfo);
                }
            }
            //返回值
            return list;
        }

        //按用户id查询某个用户
        public static UserInfo SelectUserById(int userid) {
            string sql = "select * from UserInfo where userid="+userid;
            DataTable dt=DBHelper.GetDataTable(sql);
            UserInfo userinfo = null;
            if (dt.Rows.Count > 0)
            {
                userinfo = new UserInfo();
                userinfo.userid = Convert.ToInt32(dt.Rows[0]["userid"]);
                userinfo.useraccount = dt.Rows[0]["useraccount"].ToString();
                userinfo.userpwd = dt.Rows[0]["userpwd"].ToString();
                userinfo.username = dt.Rows[0]["username"].ToString();
                userinfo.usercard = dt.Rows[0]["usercard"].ToString();
                userinfo.userimg = dt.Rows[0]["userimg"].ToString();
                userinfo.userage = Convert.ToInt32(dt.Rows[0]["userage"]);
                userinfo.usersex = dt.Rows[0]["usersex"].ToString();
                userinfo.useremile = dt.Rows[0]["useremile"].ToString();
                userinfo.userbirthdays = DateTime.Parse(dt.Rows[0]["userbirthdays"].ToString());
            }
            return userinfo;
        }

        //修改用户信息
        public static bool UpdateUser(UserInfo user)
        {
            string sql = "update UserInfo set username='"+user.username+"',usercard='"+user.usercard+"',userage='"+user.userage+"',usersex='"+user.usersex+"',useremile='"+user.useremile+"' where userid="+user.userid;
            return DBHelper.GetExecuteNonQuery(sql);
        }

        //修改头像
        public static bool UpdateUserImg(int userid,string filename)
        {
            string sql = "update UserInfo set userimg='"+filename+"' where userid="+userid;
            return DBHelper.GetExecuteNonQuery(sql);
        }
    }
}
