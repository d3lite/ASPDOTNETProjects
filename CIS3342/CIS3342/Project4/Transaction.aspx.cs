using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Utilities;
using Project4WebService;

namespace Project4
{
    public partial class Transaction : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        DataSet ds;
       // Test t = new Test();

        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        protected void btnFindTransaction_Click(object sender, EventArgs e)
        { CreditCardSvc.CreditCard pxy = new CreditCardSvc.CreditCard();


            if (txtUserName.Text == "")
                {
                    lblError.Visible = true;
                    lblError.Text = "Please enter valid username";
                }
            
                if (IsPostBack)
            {
                gvCardInfo.Visible = true;
                ds = pxy.GetTransactionByUserName(txtUserName.Text, 123);
                gvCardInfo.DataSource = ds;
                gvCardInfo.DataBind();

            }
            
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            Response.Redirect("Apply.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateInfo.aspx");
        }

        protected void btnPayment_Click(object sender, EventArgs e)
        {
            Response.Redirect("Payment.aspx");
        }

        protected void btnTransaction_Click(object sender, EventArgs e)
        {
            Response.Redirect("Transaction.aspx");
        }

        protected void btnPurchase_Click(object sender, EventArgs e)
        {
            Response.Redirect("Purchase.aspx");
        }
    }
}