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
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void subsign_ServerClick(object sender, EventArgs e)
        {
            
            var useraccount = this.Phone.Value;
            var userName = this.Username.Value;
            var pwd = this.Password.Value;
            var useremail = this.Email.Value;
            var idcard = this.IDcard.Value;



            if (userName != "" && pwd != "" && useremail != "" && useraccount != ""&&idcard!="")
            {
                UserInfo info = new UserInfo();
                info.username = userName;
                info.userpwd = pwd;
                info.useremile = useremail;
                info.useraccount = useraccount;
                info.usercard = idcard;
                UserSignBLL uib = new UserSignBLL();
                string result = uib.PlayUserInfo(info);
                if (result == "0")
                {
                    Response.Write("<script>alert('该用户已注册！')</script>");
                }
                else if (result == "1")
                {
                    Response.Write("<script>alert('用户注册成功！')</script>");
                    Response.Redirect("Login.aspx");
                }
                else
                {
                    Response.Write("<script>alert('用户注册失败！')</script>");
                }
            }
        }
    }
}