using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class Bill : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String oiD = Request["oID"];
            if (!IsPostBack)
            {
                if (oiD != null)
                {
                    Session["oID"] = oiD;
                    Response.Redirect("ManagerWeb.aspx?service=BillDetail");
                }
            }
            gvBind();
        }

        public void gvBind()
        {

            gvBill.DataSource = new DAOBillDeatail().getDataBill();
            gvBill.DataBind();
        }

        protected void gvBill_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Response.Redirect("ManagerWeb.aspx?service=BillDetail");
        }
    }
}