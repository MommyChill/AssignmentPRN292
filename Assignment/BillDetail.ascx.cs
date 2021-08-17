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
    public partial class BillDetail : System.Web.UI.UserControl
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {

            }
            gvBind();
        }

        public void gvBind()
        {
            String oID = Session["oID"].ToString();
            gvBillDetail.DataSource = new DAOBillDeatail().getBillDetail(oID);
            gvBillDetail.DataBind();

            DataTable dt = new DAOBillDeatail().getCustomerNameByoID(oID);

            lblCustomerName.Text = dt.Rows[0]["cname"].ToString();

        }

        protected void btnAccept_Click(object sender, EventArgs e)
        {
            String oID = Session["oID"].ToString();
            DAOBillDeatail dao = new DAOBillDeatail();
            dao.acceptBill(oID);
        }
    }
}