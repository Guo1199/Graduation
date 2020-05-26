using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //用户动态
    public class UserState
    {
        public int stateid { get; set; } //用户动态ID
        public int userid { get; set; }//用户ID
        public int statetypeid { get; set; }//动态类型ID
        public DateTime statetime { get; set; }//动态发布时间
        public int stategoodnums { get; set; }//点赞数
        public int statebadnums { get; set; }//点踩数
        public string statecontent { get; set; }//文字内容
        public string statephoto { get; set; }//图片路径
        public int ispass { get; set; }//是否通过
        public string statetype { get; set; }//动态类型
        public int plnum { get; set; }//评论数
    }
}
