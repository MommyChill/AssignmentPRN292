using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class DAOProduct
    {
        //get DataTable Product
        public DataTable getTableProduct(String cid)
        {
            DataTable dt = new DataTable();
            String sql = "";
            using (SqlConnection SqlConn = new DbConnection().getConnectt())
            {
                if (cid != null)
                {

                    sql = "select pid, pname,quantity,price,description,a.status,cateName " +
                                 "from Product as a inner join Category as b on a.cateID=b.cateID where b.cateID = " +cid;
                }
                else
                {

                    sql = "select pid, pname,quantity,price,description,a.status,cateName " +
                                 "from Product as a inner join Category as b on a.cateID=b.cateID";
                }

                using (SqlDataAdapter da = new SqlDataAdapter(sql, SqlConn))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }
    }
}
