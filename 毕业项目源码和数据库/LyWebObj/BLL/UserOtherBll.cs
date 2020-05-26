using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class UserOtherBll
    {
        //查询当前用户的其他信息
        public static UserOther SelectOther(int userid) {
            return UserOtherDal.SelectOther(userid);
        }
    }
}
