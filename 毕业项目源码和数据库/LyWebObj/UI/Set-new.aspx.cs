using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using BLL;
using System.Data;

namespace UI
{
    public partial class Set_new : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void setsign_ServerClick(object sender, EventArgs e)
        {
            var Password = this.Password.Value;
            var newpwd = this.newPassword.Value;
            if (Password == newpwd)
            {
                UserInfo info = new UserInfo();
                info.userpwd = newpwd;
                UserSignBLL bll = new UserSignBLL();
                bool result = bll.SetNewPassword(info);

                Response.Redirect("Login.aspx");

                //Session["UserName"] = userName;
            }
            else {
                Response.Write("<script>alert('密码不一致，请重新输入！')</script>");
            }
        }
    }
}