using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class FankBll
    {
        //查询用户反馈(id)
        public static List<UserFeedback> SelectById(int userid) {
            return FankDal.SelectById(userid);
        }

        //添加反馈
        public static bool AddFank(UserFeedback fank) {
            return FankDal.AddFank(fank);
        }

        //删除反馈
        public static bool DeleteFank(int id)
        {
            return FankDal.DeleteFank(id);
        }
    }
}
