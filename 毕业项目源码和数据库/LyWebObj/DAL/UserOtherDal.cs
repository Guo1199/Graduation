using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace DAL
{
    public class UserOtherDal
    {
        //查询当前用户的其他信息
        public static UserOther SelectOther(int userid)
        {
            DataTable dt = null;
            UserOther userother = new UserOther();
            //查询我的关注数
            string mygzsql = "select count(*) from Attention where userid="+userid;
            dt = DBHelper.GetDataTable(mygzsql);
            userother.Mygznums = Convert.ToInt32(dt.Rows[0][0].ToString());
            //查询关注我的人数
            string gzmysql = "select count(*) from Attention where attentionuser="+userid;
            dt = DBHelper.GetDataTable(gzmysql);
            userother.Gzmynums = Convert.ToInt32(dt.Rows[0][0].ToString());
            //查询我的动态数量
            string mydtsql = " select count(*) from UserState where userid="+userid;
            dt = DBHelper.GetDataTable(mydtsql);
            userother.Mydtnums = Convert.ToInt32(dt.Rows[0][0].ToString());
            //查询我的评论数量
            string myplsql = " select count(*) from UserCommentary where userid=" + userid;
            dt = DBHelper.GetDataTable(myplsql);
            userother.Myplnums = Convert.ToInt32(dt.Rows[0][0].ToString());
            return userother;
        }
    }
}
