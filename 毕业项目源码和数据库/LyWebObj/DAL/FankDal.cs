using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace DAL
{
    public class FankDal
    {
        //查询某个用户的反馈内容(用户id查询)
        public static List<UserFeedback> SelectById(int userid)
        {
            string sql = "select * from UserFeedback where userid=" + userid;
            DataTable dt = DBHelper.GetDataTable(sql);
            List<UserFeedback> list = null;
            if (dt.Rows.Count > 0)
            {
                list = new List<UserFeedback>();
                foreach (DataRow item in dt.Rows)
                {
                    UserFeedback fank = new UserFeedback();
                    fank.id = Convert.ToInt32(item["id"]);
                    fank.userid = Convert.ToInt32(item["userid"]);
                    fank.content = item["content"].ToString();
                    fank.feedbackTime = Convert.ToDateTime(item["feedbackTime"]);
                    fank.acceptancestatus = item["acceptancestatus"].ToString();
                    list.Add(fank);
                }
            }
            return list;
        }

        //用户添加反馈
        public static bool AddFank(UserFeedback fank) {
            string sql = "insert into UserFeedback(userid,content) values("+fank.userid+",'"+fank.content+"')";
            return DBHelper.GetExecuteNonQuery(sql);
        }

        //删除指定id的反馈
        public static bool DeleteFank(int id)
        {
            string sql = "delete from UserFeedback where id="+id;
            return  DBHelper.GetExecuteNonQuery(sql);
        }
    }
}
