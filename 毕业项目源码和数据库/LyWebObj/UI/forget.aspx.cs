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
    public partial class forget : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void check_ServerClick(object sender, EventArgs e)
        {
            var useraccount = this.Phone.Value;
            var useremail = this.Email.Value;
            if (useremail != "" && useraccount != "") {
                UserInfo info = new UserInfo();
                info.useremile = useremail;
                info.useraccount = useraccount;
                UserSignBLL uib = new UserSignBLL();
                string result = uib.Forget(info);
                if (result == "0")
                {
                    Response.Redirect("Set-new.aspx");
                }
                else
                {
                    Response.Write("<script>alert('该用户不存在！请重新输入')</script>");
                }
            }
        }
    }
}