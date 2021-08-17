using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

            }
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                string service = Request["service"];
                if (service == null) service = "Product";
                switch (service)
                {
                    case "Product":
                        loadContent.Controls.Add(LoadControl("Product.ascx"));
                        break;
                    case "cart":
                        loadContent.Controls.Add(LoadControl("viewCart.ascx"));
                        break;
                }
            }

        }






    }
}