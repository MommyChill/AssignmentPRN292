using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class Customer : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {


            }
            gvbind();
        }

        public void gvbind()
        {
            DAOCustomer dao = new DAOCustomer();

            gvCustomer.DataSource = dao.getTableCustomer();
            gvCustomer.DataBind();
        }
    }
}