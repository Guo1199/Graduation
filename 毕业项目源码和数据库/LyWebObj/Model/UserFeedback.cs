using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //反馈类
    public class UserFeedback:UserInfo
    {
        public int id { get; set; }//反馈id
        public string content { get; set; }//反馈内容
        public DateTime feedbackTime { get; set; }//反馈时间
        public string acceptancestatus { get; set; }//受理状态
    }
}
