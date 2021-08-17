using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class DAOBillDeatail
    {
        public DataTable getDataBill()
        {
            DataTable dt = new DataTable();
            String sql = "";
            using (SqlConnection SqlConn = new DbConnection().getConnectt())
            {


                sql = "Select * from Bill";



                using (SqlDataAdapter da = new SqlDataAdapter(sql, SqlConn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public DataTable getBillDetail(String oID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection Sqlcon = new DbConnection().getConnectt())
            {
                String sql = "Select * from BillDetail where oID = '" + oID + "'";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, Sqlcon))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        public void acceptBill(String oID)
        {
            using(SqlConnection Sqlcon = new DbConnection().getConnectt())
            {
                Sqlcon.Open();
                String sql = "UPDATE [dbo].[Bill] SET [status] = 1 WHERE [oID] = '"+oID+"'";
                using(SqlCommand cmd = new SqlCommand(sql, Sqlcon))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable getCustomerNameByoID(String oID)
        {
            DataTable dt = new DataTable();
            using (SqlConnection Sqlcon = new DbConnection().getConnectt())
            {
                String sql = "Select cname from Bill where oID = '"+oID+"'";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, Sqlcon))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }


    }


}
