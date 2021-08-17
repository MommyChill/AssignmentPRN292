using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DAO
{
    public class DAOAccount
    {
        public DataTable login(string username, string password)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new DbConnection().getConnectt())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Customer where username = '" + username + "' and password = '" + password + "'", con);
                SqlDataReader rs = cmd.ExecuteReader();
                dt.Load(rs);
            }

            return dt;
        }

        public DataTable AdminLogin(String username, String password)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new DbConnection().getConnectt())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from admin where username = '" + username + "' and password = '" + password + "'", con);
                SqlDataReader rs = cmd.ExecuteReader();
                dt.Load(rs);
            }
            return dt;
        }

        public int Register(String name, String phone, String address, String username, String password)
        {
            using (SqlConnection con = new DbConnection().getConnectt())
            {
                con.Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("Insert into Customer(cname,cphone,cAddress,username,password,status)values('" + name + "','" + phone + "','" + address + "','" + username + "','" + password + "','" + true + "')", con);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {

                }
                return 1;
            }
        }


    }
}
