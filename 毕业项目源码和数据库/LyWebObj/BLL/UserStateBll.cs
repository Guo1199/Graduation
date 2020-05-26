using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class UserStateBll
    {
        //查询最热门的动态
        public static List<UserState> SelectHotBll(int num,int index) {
            return UserStateDal.SelectHotDal(num,index);
        }

        //查询某个用户的动态
        public static List<UserState> SelectById(int userid) {
            return UserStateDal.SelectById(userid);
        }

        //查询所有动态
        public static List<UserState> SelectAll()
        {
            return UserStateDal.SelectAll();
        }

        //查询动态（动态id查询）
        public static UserState SelectByStateId(int stateid)
        {
            return UserStateDal.SelectByStateId(stateid);
        }

        //根据动态类型查询动态(动态类型id)
        public static List<UserState> SelectByStateTypeId(int statetypeid) {
            return UserStateDal.SelectByStateTypeId(statetypeid);
        }

        //查询用户关注的动态
        public static List<UserState> SelectUserGz(int userid) {
            return UserStateDal.SelectUserGz(userid);
        }
    }
}
