using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Assignment
{
    public class DAOBill
    {
        public DAOBill()
        {
            DBConnection.ConnectionString =
    ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString;
        }

        public void insertBillFromCart(DataTable dt)
        {
            
            Random random = new Random();
            

            DataTable customer = (DataTable)System.Web.HttpContext.Current.Session["customer"];


            String oID = random.Next(1000, 10000).ToString();           
            String dateCreate = DateTime.Now.ToString();
            String cname = customer.Rows[0]["cname"].ToString();
            String cphone = customer.Rows[0]["cphone"].ToString();
            String cAddress = customer.Rows[0]["cAddress"].ToString();
            double Total = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Total += double.Parse(dt.Rows[i]["Total"].ToString());
            }

            String status = "0";
            String cid = customer.Rows[0]["cid"].ToString();

            insertBill(oID, dateCreate, cname, cphone, cAddress, Total.ToString(), status, cid);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string pid = dt.Rows[i]["Pid"].ToString();
                
                string quantity = dt.Rows[i]["Quantity"].ToString();
                string price = dt.Rows[i]["Price"].ToString();
                string total = dt.Rows[i]["Total"].ToString();
                insertProductBill(pid, oID, quantity, price, total);
            }


        }

        public void insertProductBill(String pid, String oID, String Quantity, String price, String total)
        {
            SqlCommand cmd = new SqlCommand("Insert into BillDetail(pid,oID,quantity,price,total)values('" + pid + "','" + oID + "','" + Quantity + "','" + price + "','" + total + "')");
            DBConnection dao = new DBConnection();
            dao.executeNonQuery(cmd);

        }

        public void insertBill(String oID,String dateTime,String cname,String cphone, String cAddress, String total, String status,String cid)
        {
            SqlCommand cmd = new SqlCommand("Insert into Bill(oID,dateCreate,cname,cphone,cAddress,total,status,cid)" +
                "values('"+oID+"','"+dateTime+"','"+cname+"','"+cphone+"','"+cAddress+"','"+total+"','"+status+"','"+cid+"')");
            DBConnection dao = new DBConnection();
            dao.executeNonQuery(cmd);

        }




    }
}