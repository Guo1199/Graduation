using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //用户其他信息（评论数，动态数等）
    public class UserOther
    {
        public int Myplnums { get; set; }//我的评论数
        public int Mydtnums { get; set; }//我的动态数
        public int Mygznums { get; set; }//我的关注数
        public int Gzmynums { get; set; }//关注我的人数
    }
}
