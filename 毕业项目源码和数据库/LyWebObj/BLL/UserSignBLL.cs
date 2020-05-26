using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using DAL;

namespace BLL
{
   
   public class UserSignBLL
    {
       
        public DataTable CheckUser(UserInfo user)
        {
            return UserSignDal.FindUserCheck(user);
        }
        public bool SetNewPassword(UserInfo user)
        {
            return UserSignDal.SetNewPassword(user);
        }
        public bool AddUser(UserInfo user)
        {
            return UserSignDal.AddUser(user);
        }
        public string PlayUserInfo(UserInfo user)
        {
            DataTable dt = UserSignDal.FindUserByUserName(user.username);
            string flag;
            if (dt.Rows.Count > 0)
            {
                //提示用户已存在
                flag = "0";
            }
            else
            {
                //调用新增
                bool result = UserSignDal.AddUser(user);
                if (result)
                {
                    //提示用户注册成功！
                    flag = "1";
                }
                else
                {
                    //用户注册失败！
                    flag = "-1";
                }
            }

            return flag;
        }
       //用户是否存在
        public string Forget(UserInfo user)
        {
            DataTable dt = UserSignDal.FindUserforget(user.username);
            string flag;
            if (dt.Rows.Count > 0)
            {
                //提示用户已存在
                flag = "0";
            }
            else {
                flag = "-1";
            }
             return flag;
           
        }
    }
}
