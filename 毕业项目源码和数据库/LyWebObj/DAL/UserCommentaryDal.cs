using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace DAL
{
    public class UserCommentaryDal
    {
        //查询某个动态所有评论（按点赞数排序，动态id查询）
        public static List<UserCommentary> SelectPlHot(int stateid)
        {
            string sql = "select * from UserCommentary t1,UserInfo t2 where t1.userid=t2.userid  and stateid=" + stateid + " order by plgoodnums desc";
            DataTable dt=DBHelper.GetDataTable(sql);
            List<UserCommentary> list = null;
            if (dt.Rows.Count>0)
            {
                list = new List<UserCommentary>();
                foreach (DataRow item in dt.Rows)
                {
                    UserCommentary com = new UserCommentary();
                    com.id =Convert.ToInt32(item["id"]);
                    com.userid = Convert.ToInt32(item["userid"]);
                    com.stateid = Convert.ToInt32(item["stateid"]);
                    com.commentarycontent = item["commentarycontent"].ToString();
                    com.plgoodnums = Convert.ToInt32(item["plgoodnums"]);
                    com.plbadnums = Convert.ToInt32(item["plbadnums"]);
                    com.username = item["username"].ToString();
                    com.userimg = item["userimg"].ToString();
                    com.pltime = item["pltime"].ToString().Substring(0, 10);
                    list.Add(com);
                }
            }
            return list;
        }

        //某个动态新增评论
        public static bool AddPl(UserCommentary com) {
            string sql = "insert into UserCommentary(userid,stateid,commentarycontent) values("+com.userid+","+com.stateid+",'"+com.commentarycontent+"')";
            return DBHelper.GetExecuteNonQuery(sql);
        }

        //查询某个用户的评论（用户id查询）
        public static List<UserCommentary> SelectBuUserId(int userid)
        {
            string sql = "select * from UserCommentary where userid="+userid;
            DataTable dt = DBHelper.GetDataTable(sql);
            List<UserCommentary> list = null;
            if (dt.Rows.Count > 0)
            {
                list = new List<UserCommentary>();
                foreach (DataRow item in dt.Rows)
                {
                    UserCommentary com = new UserCommentary();
                    com.id = Convert.ToInt32(item["id"]);
                    com.userid = Convert.ToInt32(item["userid"]);
                    com.stateid = Convert.ToInt32(item["stateid"]);
                    com.commentarycontent = item["commentarycontent"].ToString();
                    com.plgoodnums = Convert.ToInt32(item["plgoodnums"]);
                    com.plbadnums = Convert.ToInt32(item["plbadnums"]);
                    com.pltime = item["pltime"].ToString().Substring(0,10);
                    list.Add(com);
                }
            }
            return list;
        }
    }
}
