using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using System.Drawing;

namespace UI
{
    public partial class Detailed : System.Web.UI.Page
    {
        int stateid;
        protected void Page_Load(object sender, EventArgs e)
        {
            stateid= Convert.ToInt32(Request.QueryString["stateid"]);
            //第一次加载
            if (!this.IsPostBack)
            {
                UserState state = UserStateBll.SelectByStateId(stateid);

                if (state != null)
                {
                    //查询用户信息
                    UserInfo user = UserInfoBll.SelectUserById(state.userid);
                    if (state.statephoto != null && state.statephoto != "")
                    {
                        this.stateimg.InnerHtml = "<img src='Images/" + state.statephoto + "'/>";
                    }
                    this.userimg.Src = "~/Images/" + user.userimg;
                    this.username.InnerText = user.username;
                    this.usercon.InnerText = state.statecontent;
                    this.dc.InnerText = state.statebadnums.ToString();
                    this.dz.InnerText = state.stategoodnums.ToString();
                    if (state.userid == 1)//等于自己的id
                    {
                        this.Button3.Enabled = false;
                    }
                }
                //绑定数据
                this.RepeaterPl.DataSource = UserCommentaryBll.SeelctPlHot(stateid);
                this.RepeaterPl.DataBind();
                //加载时判断当前用户是否关注了该动态发布者
                Attention att = new Attention();
                att.userid = 1;//当前用户
                att.attentionuser = state.userid;
                if (AttentionBll.SelectIs(att, true))
                {
                    this.Button3.Text = "已关注";
                    this.Button3.BackColor = Color.Red;
                }
                else {
                    this.Button3.Text = "+关注";
                    this.Button3.BackColor = Color.Blue;
                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //清空的点击事件
            this.bot_txt.InnerText = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //确认的点击事件,判断是否为用户
            string pltxt = this.bot_txt.InnerText.Trim();
            if (pltxt != "" && pltxt.Length <= 40)
            {
                int stateid = Convert.ToInt32(Request.QueryString["stateid"]);
                UserCommentary com = new UserCommentary();
                com.userid = 1;
                com.stateid = stateid;
                com.commentarycontent = pltxt;
                if (UserCommentaryBll.AddPl(com))
                {
                    Response.Write("<script>alert('提交成功！');</script>");
                    //绑定数据
                    this.RepeaterPl.DataSource = UserCommentaryBll.SeelctPlHot(stateid);
                    this.RepeaterPl.DataBind();
                    this.bot_txt.InnerText = "";
                }
                else
                {
                    Response.Write("<script>alert('提交失败！');</script>");
                }
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
             UserState state = UserStateBll.SelectByStateId(stateid);
            Attention att = new Attention();
            att.userid = 1;//当前的用户id
            att.attentionuser = state.userid;
            //关注按钮点击事件
            if (this.Button3.Text == "+关注")
            {
                //判断数据库中是否存在两个用户的关注关系
                if (AttentionBll.SelectIs(att,false))
                {
                    //如果有,调用修改的方法
                    if (AttentionBll.UpdateGz(att, 1))
                    {
                        this.Button3.Text = "已关注";
                        this.Button3.BackColor = Color.Red;
                    }
                }
                else
                {
                    //如果没有，调用新增的方法
                    if (AttentionBll.AddGz(att))
                    {
                        this.Button3.Text = "已关注";
                        this.Button3.BackColor = Color.Red;
                    }
                }
            }
            else
            {
                //取消关注
                if(AttentionBll.UpdateGz(att,0))
                {
                    this.Button3.Text = "+关注";
                    this.Button3.BackColor = Color.Blue;
                }
            }
        }
    }
}