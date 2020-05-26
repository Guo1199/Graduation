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
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //加载时显示用户个人信息
            List<UserInfo> list = new List<UserInfo>();
            list.Add(UserInfoBll.SelectUserById(1));
            this.RepeaterUserInfo.DataSource = list;
            this.RepeaterUserInfo.DataBind();
            this.uimg.Src = "~/Images/" + list[0].userimg;
            this.uname.InnerText = list[0].username;
            //显示个人信息
            this.txtname.Value = list[0].username;
            this.txtsex.Value = list[0].usersex;
            this.txtem.Value = list[0].useremile;
            this.txtsfz.Value = list[0].usercard;
            //绑定数据
            this.RepeaterMyState.DataSource = UserStateBll.SelectById(1);//用户id
            this.RepeaterMyState.DataBind();
            //显示我的评论
            this.RepeaterMyPl.DataSource = UserCommentaryBll.SelectBuUserId(1);//用户id
            this.RepeaterMyPl.DataBind();
            //加载时显示我的关注等信息
            UserOther userother = UserOtherBll.SelectOther(1);//当前的用户id
            this.mygz.InnerText = userother.Mygznums.ToString();
            this.gzmy.InnerText = userother.Gzmynums.ToString();
            this.mydt.InnerText = userother.Mydtnums.ToString();
            this.mypl.InnerText = userother.Myplnums.ToString();
        }

        protected void updateclick(object sender, EventArgs e)
        {
            string username = this.txtname.Value;
            string usercard = this.txtsfz.Value;
            string usersex = this.txtsex.Value;
            string userem = this.txtem.Value;
            if (username.Trim() == "" || usercard.Trim() == "" || usersex.Trim() == "" || userem.Trim() == "")
            {
                Response.Write("<script>alert('信息不能为空！');</script>");
            }
            else if (username.Trim().Length > 10)
            {
                Response.Write("<script>alert('用户名长度不能超过10！');</script>");
            }
            else
            {
                //修改操作
                UserInfo user = new UserInfo();
                user.username = username;
                user.usercard = usercard;
                user.usersex = usersex;
                user.useremile = userem;
                user.userid = 1;//用户id
                if (UserInfoBll.UpdateUser(user))
                {
                    Response.Write("<script>alert('修改成功！');</script>");
                }
                else
                {
                    Response.Write("<script>alert('修改失败！');</script>");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //点击事件
            if (this.FileUpload1.HasFile)
            {
                string filename = this.FileUpload1.FileName;
                string fileFix = filename.Substring(filename.LastIndexOf('.') + 1).ToLower();
                if (fileFix != "png" && fileFix != "jpg" && fileFix != "jpeg" && fileFix != "pic")
                {
                    Response.Write("<script>alert('上传的文件不是图片文件！');</script>");
                }
                else
                {
                    FileUpload1.SaveAs(Server.MapPath("~/Images/") + filename);
                    //调用BLL层方法
                    if (UserInfoBll.UpdateUserImg(1, filename))
                    {
                        Response.Write("<script>alert('头像更改成功！');</script>");
                        Response.Redirect("User.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('头像更改失败！');</script>");
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('请选择你要更换的头像！');</script>");
            }
        }
    }
}