using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace Assignment
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack){

            }

            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if(username.Trim()=="" || username==null && password.Trim()=="" || password == null)
            {
                MessageBox.Show("Username and Password can't empty");

            }
            else
            {
                DataTable account = new DAOAccount().login(username, password);
                if (account.Rows.Count > 0)
                {
                    Session["customer"] = account;
                    Session["username"] = username;
                    Response.Redirect("Home.aspx");
                }

            }

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            Response.Redirect("Register.aspx");
        }

        protected void btnAdminLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (username.Trim() == "" || username == null && password.Trim() == "" || password == null)
            {
                MessageBox.Show("Username and Password can't empty");

            }
            else
            {
                DataTable account = new DAOAccount().AdminLogin(username, password);
                if (account.Rows.Count > 0)
                {
                    Session["admin"] = username;
                    Response.Redirect("ManagerWeb.aspx");
                }

            }
        }
    }
}