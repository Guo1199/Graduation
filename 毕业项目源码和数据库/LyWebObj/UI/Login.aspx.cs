using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Model;
using BLL;

namespace UI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Sign_ServerClick(object sender, EventArgs e)
        {
            var userName = this.txtUser.Value;
            var pwd = this.txtPwd.Value;
            if (userName != "" && pwd != "")
            {
                UserInfo info = new UserInfo();
                info.useraccount = userName;
                info.userpwd = pwd;

                UserSignBLL bll = new UserSignBLL();
                DataTable dt = bll.CheckUser(info);
                if (dt.Rows.Count > 0)
                {
                    Session["userCount"] = dt.Rows[0]["useraccount"].ToString();
                    Response.Redirect("Index.aspx");

                    //Session["UserName"] = userName;

                }
                else
                {
                    Response.Write("<script>alert('账号密码不正确或用户不存在！请重新输入');</script>");
                }
            }

        }
    }
}