using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class AttentionBll
    {
        //新增关注(当前用户id，关注者id)
        public static bool AddGz(Attention att)
        {
            return AttentionDal.AddGz(att);
        }

         //用户取消关注
        public static bool UpdateGz(Attention att, int isatt)
        {
            return AttentionDal.UpdateGz(att,isatt);
        }

        //查询当前用户是否关注该用户
        public static bool SelectIs(Attention att,bool isatt)
        {
            return AttentionDal.SelectIs(att,isatt);
        }
    }
}
