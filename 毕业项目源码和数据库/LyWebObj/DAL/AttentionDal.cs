using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;

namespace DAL
{
    public class AttentionDal
    {
        //新增关注(当前用户id，关注者id)
        public static bool AddGz(Attention att)
        {
            string sql = "insert into Attention values("+att.userid+","+att.attentionuser+",1)";
            return DBHelper.GetExecuteNonQuery(sql);
        }

        //用户取消关注
        public static bool UpdateGz(Attention att,int isatt)
        {
            string sql = "";
            if (isatt == 0)
            {
                sql += "update Attention set isattention=" + isatt + " where userid=" + att.userid + " and attentionuser=" + att.attentionuser + " and isattention=1";
            }
            else {
                sql += "update Attention set isattention=" + isatt + " where userid=" + att.userid + " and attentionuser=" + att.attentionuser + " and isattention=0";
            }
            return DBHelper.GetExecuteNonQuery(sql);
        }

        //查询当前用户是否关注该用户
        public static bool SelectIs(Attention att,bool isatt) {
            string sql = "select * from Attention where userid=" + att.userid + " and attentionuser=" + att.attentionuser;
            if (isatt == true)
            {
                sql += " and isattention=1";
            }
            DataTable dt=DBHelper.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
