using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class DAOCustomer
    {
        public DataTable getTableCustomer()
        {
            DataTable dt = new DataTable();
            String sql = "";
            using (SqlConnection SqlConn = new DbConnection().getConnectt())
            {
                    sql = "Select * from Customer";
                

                using (SqlDataAdapter da = new SqlDataAdapter(sql, SqlConn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }


    }
}
