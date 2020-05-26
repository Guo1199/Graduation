using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Data;
namespace BLL
{
    /// <summary>
    /// 类型
    /// </summary>
    public  class StateTypeBLL
    {
        public static List<StateType> SelectAll()
        {
            DataTable dt = StateTypeDAL.select();
            List<StateType> list = new List<StateType>();
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    StateType st = new StateType();
                    st.id = Convert.ToInt32(dr["id"].ToString());
                    st.statetype = dr["statetype"].ToString();
                    list.Add(st);
                }
            }
            return list;
        }
    }
}
