using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodOrder
{
    class DataAccess
    {
        public string connstr = "server=LAPTOP-6OF73R39\\MSMADHAV;integrated security = true;database = olfdordr";
        public DataTable GetDataTable(String sql)
        {
            DataTable dt = new DataTable();
            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public object GetScalar(String sql)
        {
            object obj = null;
            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                obj = cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                return null;
            }
            finally
            {
                conn.Close();
            }
            return obj;
        }
        public int InsUpDel(string sql)
        {
            int rows = 0;
            SqlConnection conn = new SqlConnection(connstr);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return -1;
            }
            finally
            {
                conn.Close();
            }
            return rows;
        }
    }
}
