using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class ManagerWeb : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            if (Session["admin"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                string service = Request["service"];
                if (service == null) service = "Bill";
                switch (service)
                {
                    case "Bill":
                        PlaceHolder1.Controls.Add(LoadControl("Bill.ascx"));
                        break;
                    case "Customer":
                        PlaceHolder1.Controls.Add(LoadControl("Customer.ascx"));
                        break;
                    case "BillDetail":
                        PlaceHolder1.Controls.Add(LoadControl("BillDetail.ascx"));
                        break;
                }
            }
        }
    }
}