using Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class DAOCategory
    {
        //get DataTable Category
        public DataTable getTableCategory()
        {
            DataTable dt = new DataTable();
            using (SqlConnection sqlcon = new DbConnection().getConnectt())
            {
                sqlcon.Open();
                string sql = "select * from Category";
                using (SqlDataAdapter da = new SqlDataAdapter(sql, sqlcon))
                {
                    da.Fill(dt);
                }
            }
            return dt;
        }

        //get List Category
        //public List<Category> getListCategory()
        //{



        //}



    }
}




