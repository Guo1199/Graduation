using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //评论类
    public class UserCommentary:UserInfo
    {
        public int id { get; set; }//评论id
        public int userid { get; set; }//评论者id
        public int stateid { get; set; }//动态id
        public string commentarycontent { get; set; }//评论内容
        public int plgoodnums { get; set; }//评论点赞数
        public int plbadnums { get; set; }//评论点踩数
        public string pltime { get; set; }//用户评论时间
    }
}
