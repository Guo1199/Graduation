using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace UI.Main
{
    public partial class MainHome : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //母版加载信息
            if (!this.IsPostBack)
            {
                //调用bll层方法
                UserInfo user= UserInfoBll.SelectUserById(1);
                if (user != null)
                {
                    this.userimg.Src = "~/Images/"+user.userimg;
                }
            }
        }
    }
}