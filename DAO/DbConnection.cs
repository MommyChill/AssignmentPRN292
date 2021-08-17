using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class DbConnection
    {
        //Connect to Database    11-41
        SqlConnection sql = new SqlConnection("server=localhost; database=DBDemo;user=sa; password=123");

        public SqlConnection Sqlconn = null;

        public SqlConnection getConnectt()
        {
            return Sqlconn;
        }

        public DbConnection(string server, string database, string user, string password)
        {
            string sqlConnect = "server = " + server + ";database = " + database + ";user=" + user + ";password=" + password;

            try
            {
                if(Sqlconn == null)
                {
                    Sqlconn = new SqlConnection(sqlConnect);
                }
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public DbConnection() : this("localhost","DBDemo","sa","123")
        {
            Console.WriteLine("Connected");
        }


        //get sql DataReader
        public SqlDataReader getDataFromSql(string sql)
        {
            SqlDataReader reader = null;
            if(Sqlconn.State == System.Data.ConnectionState.Closed)
            {
                Sqlconn.Open();
            }
            using (SqlCommand command = Sqlconn.CreateCommand())
            {
                command.CommandText = sql;
                reader = command.ExecuteReader();
            }
            return reader;
        }
        


    }
}
