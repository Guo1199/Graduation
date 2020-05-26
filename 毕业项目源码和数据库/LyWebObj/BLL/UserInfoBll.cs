using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class UserInfoBll
    {
        //按id查询用户信息
        public static UserInfo SelectUserById(int userid)
        {
            //调用Dal层方法
            return UserInfoDal.SelectUserById(userid);
        }
        //修改用户信息
        public static bool UpdateUser(UserInfo user)
        {
            return UserInfoDal.UpdateUser(user);
        }

        //修改头像
        public static bool UpdateUserImg(int userid, string filename)
        {
            return UserInfoDal.UpdateUserImg(userid,filename);
        }
    }
}
