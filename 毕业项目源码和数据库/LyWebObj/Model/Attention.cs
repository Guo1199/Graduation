using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Attention:UserInfo
    {
        //关注类
        public int attentionid { get; set; } //关注id
        public int attentionuser { get; set; } //关注者id
        public int isattention { get; set; } //是否关注(0否，1是)
    }
}
