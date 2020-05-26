using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class UserCommentaryBll
    {
        //查询某个动态所有评论（按点赞数排序，动态id查询）
        public static List<UserCommentary> SeelctPlHot(int stateid) {
            return UserCommentaryDal.SelectPlHot(stateid);
        }

        //某个动态新增评论
        public static bool AddPl(UserCommentary com) {
            return UserCommentaryDal.AddPl(com);
        }

        //查询某个用户评论（用户id查询）
        public static List<UserCommentary> SelectBuUserId(int userid) {
            return UserCommentaryDal.SelectBuUserId(userid);
        }
    }
}
