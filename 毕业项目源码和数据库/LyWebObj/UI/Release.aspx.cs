using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Model;

namespace UI
{
    public partial class Release : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            List<StateType> list = StateTypeBLL.SelectAll();
            DropDownList1.DataSource = list;
            DropDownList1.DataTextField = "StateType";
            DropDownList1.DataValueField = "id";
            DropDownList1.DataBind();
            
        }

        protected void Submit1_ServerClick()
        {
            UserInfo user = new UserInfo();
            int userid = user.userid;
            string text = this.text1.ToString();


        }
    }
}