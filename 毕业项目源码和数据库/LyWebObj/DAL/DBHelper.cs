using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DBHelper
    {
        //创建字符串连接数据库
        private static string connstring = "server=.;database=LywebDB;uid=sa;pwd=0210;";
        private static SqlConnection conn = null;
        private static void Init() {
            if (conn == null)
            {
                conn = new SqlConnection(connstring);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            else if (conn.State == ConnectionState.Broken)
            {
                conn.Close();
                conn.Open();
            }
        }

        /// <summary>
        /// 查询(断开式连接)
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static DataTable GetDataTable(string sql) {
            try
            {
                Init();
                DataTable dt = new DataTable();
                SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
                dap.Fill(dt);
                conn.Close();
                return dt;
            }
            catch (Exception em)
            {
                throw em;
            }
        }

        /// <summary>
        /// 查询（非断开时连接）
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static SqlDataReader GetDataReader(string sql)
        {
            Init();
            SqlCommand cmd = new SqlCommand(sql,conn);
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// 增删改
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        public static bool GetExecuteNonQuery(string sql)
        {
            try
            {
                Init();
                SqlCommand cmd = new SqlCommand(sql, conn);
                int result = cmd.ExecuteNonQuery();
                conn.Close();
                if (result > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception em)
            {
                throw em;
            }
        }
    }
}
