using System.Data;
using System.Data.SqlClient;

namespace Assignment
{
    public class DBConnection
    {
        static string connectionString = "";

        public static string ConnectionString { get => connectionString; set => connectionString = value; }

        public static SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            return conn;
        }
        public void executeNonQuery(SqlCommand comm)
        {
            if (comm.Connection != null)
            {
                comm.ExecuteNonQuery();
            }
            else
            {
                using (SqlConnection conn = getConnection())
                {
                    comm.Connection = conn;
                    comm.ExecuteNonQuery();
                }
            }
        }
        public static DataTable getData(SqlCommand command)
        {
            if (command.Connection != null)
            {
                using (DataSet ds = new DataSet())
                {
                    using (SqlDataAdapter da = new SqlDataAdapter())
                    {
                        da.SelectCommand = command;
                        da.Fill(ds);
                        return ds.Tables[0];
                    }
                }
            }
            else
            {
                using (SqlConnection conn = getConnection())
                {
                    using (DataSet ds = new DataSet())
                    {
                        using (SqlDataAdapter da = new SqlDataAdapter())
                        {
                            command.Connection = conn;
                            da.SelectCommand = command;
                            da.Fill(ds);
                            return ds.Tables[0];
                        }
                    }
                }
            }
        }
    }
}