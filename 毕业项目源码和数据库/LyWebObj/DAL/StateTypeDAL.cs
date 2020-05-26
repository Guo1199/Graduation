using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlClient;
using System.Data;
namespace DAL
{
    /// <summary>
    /// 动态类型表
    /// </summary>
    public class StateTypeDAL
    {
        /// <summary>
        /// 查询所有类型
        /// </summary>
        /// <returns></returns>
        public static DataTable select()
        {
            string sql=string.Format("select * from StateType");
            DataTable dt= DBHelper.GetDataTable(sql);
            return dt;
        }
    }
}
