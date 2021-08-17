using DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class Menu : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            gvbind();
        }

        protected void ddCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void gvbind()
        {
            DataTable dt = new DAOCategory().getTableCategory();

            GridView1.DataSource = dt;
            GridView1.DataBind();




        }
    }
}