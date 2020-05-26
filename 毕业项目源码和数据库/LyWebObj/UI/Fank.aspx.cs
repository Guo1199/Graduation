using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using Model;
using BLL;

namespace UI
{
    public partial class Fank : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //第一次加载
            if (!this.IsPostBack)
            {
                this.TextBox1.ForeColor = Color.Gray;
                this.TextBox1.Text = "请输入您的意见（80字以内）";
            }
            if (FankBll.SelectById(1) == null)
            {
                this.Label1.Text = "您还没有反馈，请提出您宝贵的意见吧！";
            }
            else {
                this.RepeaterFank.DataSource = FankBll.SelectById(1);
                this.RepeaterFank.DataBind();
            }
        }

        protected void addfank(object sender, EventArgs e)
        {
            if (this.TextBox1.Text.Trim() != "" && this.TextBox1.Text != "请输入您的意见（80字以内）")
            {
                if (this.TextBox1.Text.Length > 10)
                {
                    Response.Write("<script>alert('反馈内容不能超过80字！');</script>");
                }
                else {
                    UserFeedback userfk = new UserFeedback();
                    userfk.userid = 1;//用户id
                    userfk.content=this.TextBox1.Text.Trim();
                    //调用bll层方法
                    if (FankBll.AddFank(userfk))
                    {
                        Response.Write("<script>alert('提交成功！');</script>");
                        //清空文本
                        this.TextBox1.Text = "";
                    }
                    else {
                        Response.Write("<script>alert('提交失败！');</script>");
                    }
                }
            }
            else {
                Response.Write("<script>alert('反馈内容不能为空！');</script>");
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //获取要删除的id
            int id = Convert.ToInt32(((LinkButton)sender).CommandArgument.ToString());
            if (FankBll.DeleteFank(id))
            {
                Response.Write("<script>alert('删除成功！');</script>");
                Response.Redirect("Fank.aspx");
            }
            else {
                Response.Write("<script>alert('删除失败！');</script>");
            }
        }
    }
}