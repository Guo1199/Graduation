using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;

namespace UI
{
    public partial class Index : System.Web.UI.Page
    {
        private static int index;
        protected void Page_Load(object sender, EventArgs e)
        {
            index = Convert.ToInt32(Request.QueryString["index"]);
            //如果为第一次加载
            if (!this.IsPostBack)
            {
                this.RepeaterState.DataSource = UserStateBll.SelectHotBll(0,0);
                this.RepeaterState.DataBind();
                //调用bll方法
                UserInfo user= UserInfoBll.SelectUserById(1);
                this.contentimg.Src = "~/Images/" + user.userimg;
                this.username.InnerText = user.username;
                Session["num"] = 0;
                //用户关注的动态
                List<UserState> list = UserStateBll.SelectUserGz(1);//当前用户id
                if (list.Count>0)
                {
                    this.span1.InnerText = "";
                    this.RepeaterGzDt.DataSource = list;
                    this.RepeaterGzDt.DataBind();
                }
                else {
                    this.span1.InnerText = "您还没有关注，赶快去关注吧！";
                    this.RepeaterGzDt.DataSource = null;
                    this.RepeaterGzDt.DataBind();
                }
            }
            if (index!=0)
            {
                List<UserState> list=UserStateBll.SelectByStateTypeId(index);
                if (list.Count > 0)
                {
                    this.span.InnerText = "";
                    this.RepeaterState.DataSource = list;
                    this.RepeaterState.DataBind();
                }
                else {
                    this.span.InnerText="空空如也！";
                    this.RepeaterState.DataSource = null;
                    this.RepeaterState.DataBind();
                }
            }
        }

        protected bool New() {
            int num = Convert.ToInt32(Session["num"]);
            int lenght=UserStateBll.SelectAll().Count;
            if (num < lenght)
            {
                Session["num"] = Convert.ToInt32(Session["num"]) + 5;
                this.RepeaterState.DataSource = UserStateBll.SelectHotBll(Convert.ToInt32(Session["num"]),index);
                this.RepeaterState.DataBind();
                return true;
            }
            else {
                return false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //更多点击事件
            if (!New())
            {
                Response.Write("<script>alert('没有更多内容了！');</script>");
            }
        }
    }
}