using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class UserStateDal
    {
        //根据点赞数查询最热门的动态
        public static List<UserState> SelectHotDal(int num,int index) {
            string sql;
            if (index == 0)
            {
                sql = "select top (5+" + num + ") * from UserState t1,StateType t2 where t1.statetypeid=t2.id and ispass=1 order by stategoodnums desc ";
            }
            else {
                sql = "select top (5+" + num + ") * from UserState t1,StateType t2 where t1.statetypeid=t2.id and t2.id="+index+" and ispass=1 order by stategoodnums desc ";
            }
            //调用DBHelper类
            DataTable dt=DBHelper.GetDataTable(sql);
            //定义集合
            List<UserState> list = new List<UserState>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    UserState userstate = new UserState();
                    userstate.stateid = Convert.ToInt32(item["stateid"].ToString());
                    userstate.userid = Convert.ToInt32(item["userid"].ToString());
                    userstate.statetypeid = Convert.ToInt32(item["statetypeid"].ToString());
                    userstate.statetime = DateTime.Parse(item["statetime"].ToString());
                    userstate.stategoodnums = Convert.ToInt32(item["stategoodnums"].ToString());
                    userstate.statebadnums = Convert.ToInt32(item["statebadnums"].ToString());
                    userstate.statecontent = item["statecontent"].ToString();
                    if (item["statephoto"].ToString() != "" && item["statephoto"].ToString() != null)
                    {
                        userstate.statephoto = "Images/" + item["statephoto"].ToString();
                    }
                    userstate.ispass = Convert.ToInt32(item["ispass"].ToString());
                    userstate.statetype = item["statetype"].ToString();
                    string sql1 = "select count(*) from UserCommentary where stateid="+userstate.stateid;
                    DataTable dt1=DBHelper.GetDataTable(sql1);
                    userstate.plnum=Convert.ToInt32(dt1.Rows[0][0].ToString());
                    //添加到集合
                    list.Add(userstate);
                }
            }
            //返回一个集合
            return list;
        }


        //查询某个用户的动态(用户id查询)
        public static List<UserState> SelectById(int userid) {
            string sql = " select * from UserState where ispass=1 and userid="+userid;
            //调用DBHelper类
            DataTable dt = DBHelper.GetDataTable(sql);
            //定义集合
            List<UserState> list = new List<UserState>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    UserState userstate = new UserState();
                    userstate.stateid = Convert.ToInt32(item["stateid"].ToString());
                    userstate.userid = Convert.ToInt32(item["userid"].ToString());
                    userstate.statetypeid = Convert.ToInt32(item["statetypeid"].ToString());
                    userstate.statetime = DateTime.Parse(item["statetime"].ToString());
                    userstate.stategoodnums = Convert.ToInt32(item["stategoodnums"].ToString());
                    userstate.statebadnums = Convert.ToInt32(item["statebadnums"].ToString());
                    userstate.statecontent = item["statecontent"].ToString();
                    if (item["statephoto"].ToString() != "" && item["statephoto"].ToString() != null)
                    {
                        userstate.statephoto = "Images/" + item["statephoto"].ToString();
                    }
                    userstate.ispass = Convert.ToInt32(item["ispass"].ToString());
                    string sql1 = "select count(*) from UserCommentary where stateid=" + userstate.stateid;
                    DataTable dt1 = DBHelper.GetDataTable(sql1);
                    userstate.plnum = Convert.ToInt32(dt1.Rows[0][0].ToString()); //获取评论数
                    //添加到集合
                    list.Add(userstate);
                }
            }
            //返回一个集合
            return list;
        }

        //查询所有动态
        public static List<UserState> SelectAll() {
            string sql = "select * from UserState";
            //调用DBHelper类
            DataTable dt = DBHelper.GetDataTable(sql);
            //定义集合
            List<UserState> list = new List<UserState>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    UserState userstate = new UserState();
                    userstate.stateid = Convert.ToInt32(item["stateid"].ToString());
                    userstate.userid = Convert.ToInt32(item["userid"].ToString());
                    userstate.statetypeid = Convert.ToInt32(item["statetypeid"].ToString());
                    userstate.statetime = DateTime.Parse(item["statetime"].ToString());
                    userstate.stategoodnums = Convert.ToInt32(item["stategoodnums"].ToString());
                    userstate.statebadnums = Convert.ToInt32(item["statebadnums"].ToString());
                    userstate.statecontent = item["statecontent"].ToString();
                    userstate.statephoto = item["statephoto"].ToString();
                    userstate.ispass = Convert.ToInt32(item["ispass"].ToString());
                    //添加到集合
                    list.Add(userstate);
                }
            }
            //返回一个集合
            return list;
        }

        //查询动态（动态id）
        public static UserState SelectByStateId(int stateid) {
            string sql = "select * from UserState where stateid="+stateid;
            DataTable dt=DBHelper.GetDataTable(sql);
            UserState userstate = null;
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    userstate=new UserState();
                    userstate.stateid = Convert.ToInt32(item["stateid"].ToString());
                    userstate.userid = Convert.ToInt32(item["userid"].ToString());
                    userstate.statetypeid = Convert.ToInt32(item["statetypeid"].ToString());
                    userstate.statetime = DateTime.Parse(item["statetime"].ToString());
                    userstate.stategoodnums = Convert.ToInt32(item["stategoodnums"].ToString());
                    userstate.statebadnums = Convert.ToInt32(item["statebadnums"].ToString());
                    userstate.statecontent = item["statecontent"].ToString();
                    userstate.statephoto = item["statephoto"].ToString();
                    userstate.ispass = Convert.ToInt32(item["ispass"].ToString());
                }
            }
            return userstate;
        }

        //根据动态类型查询动态(动态类型id)
        public static List<UserState> SelectByStateTypeId(int statetypeid) {
            string sql = "select * from UserState t1,StateType t2 where t1.statetypeid=t2.id and t2.id=" + statetypeid;
            //调用DBHelper类
            DataTable dt = DBHelper.GetDataTable(sql);
            //定义集合
            List<UserState> list = new List<UserState>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    UserState userstate = new UserState();
                    userstate.stateid = Convert.ToInt32(item["stateid"].ToString());
                    userstate.userid = Convert.ToInt32(item["userid"].ToString());
                    userstate.statetypeid = Convert.ToInt32(item["statetypeid"].ToString());
                    userstate.statetime = DateTime.Parse(item["statetime"].ToString());
                    userstate.stategoodnums = Convert.ToInt32(item["stategoodnums"].ToString());
                    userstate.statebadnums = Convert.ToInt32(item["statebadnums"].ToString());
                    userstate.statecontent = item["statecontent"].ToString();
                    if (item["statephoto"].ToString() != "" && item["statephoto"].ToString() != null)
                    {
                        userstate.statephoto = "Images/" + item["statephoto"].ToString();
                    }
                    userstate.ispass = Convert.ToInt32(item["ispass"].ToString());
                    string sql1 = "select count(*) from UserCommentary where stateid=" + userstate.stateid;
                    DataTable dt1 = DBHelper.GetDataTable(sql1);
                    userstate.plnum = Convert.ToInt32(dt1.Rows[0][0].ToString()); //获取评论数
                    userstate.statetype = item["statetype"].ToString();
                    //添加到集合
                    list.Add(userstate);
                }
            }
            //返回一个集合
            return list;
        }

        //查询用户关注的动态
        public static List<UserState> SelectUserGz(int userid)
        {
            string sql = " select * from (select * from UserState where userid in (select attentionuser from Attention where userid=" + userid + " and isattention=1))t1,StateType t2 where t1.statetypeid=t2.id";
            //调用DBHelper类
            DataTable dt = DBHelper.GetDataTable(sql);
            //定义集合
            List<UserState> list = new List<UserState>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow item in dt.Rows)
                {
                    UserState userstate = new UserState();
                    userstate.stateid = Convert.ToInt32(item["stateid"].ToString());
                    userstate.userid = Convert.ToInt32(item["userid"].ToString());
                    userstate.statetypeid = Convert.ToInt32(item["statetypeid"].ToString());
                    userstate.statetime = DateTime.Parse(item["statetime"].ToString());
                    userstate.stategoodnums = Convert.ToInt32(item["stategoodnums"].ToString());
                    userstate.statebadnums = Convert.ToInt32(item["statebadnums"].ToString());
                    userstate.statecontent = item["statecontent"].ToString();
                    if (item["statephoto"].ToString() != "" && item["statephoto"].ToString() != null)
                    {
                        userstate.statephoto = "Images/" + item["statephoto"].ToString();
                    }
                    userstate.ispass = Convert.ToInt32(item["ispass"].ToString());
                    string sql1 = "select count(*) from UserCommentary where stateid=" + userstate.stateid;
                    DataTable dt1 = DBHelper.GetDataTable(sql1);
                    userstate.plnum = Convert.ToInt32(dt1.Rows[0][0].ToString()); //获取评论数
                    userstate.statetype = item["statetype"].ToString();//获取动态类型
                    //添加到集合
                    list.Add(userstate);
                }
            }
            //返回一个集合
            return list;
        }
    }
}
