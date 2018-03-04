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
    public partial class Payment : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new  SqlCommand();

        DataSet ds;
        //Test t = new Test();



        protected void Page_Load(object sender, EventArgs e)
        {


            string[] names = new string[1];
            names[0] = "CreditCardNumber";
            gvPaymentInfo.DataKeyNames = names;
            gvPaymentInfo.DataBind();
        }

        protected void btnApply_Click(object sender, EventArgs e)
        {
            Response.Redirect("Apply.aspx");

        }

      
        protected void btnUpdate_Click1(object sender, EventArgs e)
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

        protected void btnEmployee_Click(object sender, EventArgs e)
        {
            lblEmployee.Visible = true;
            rbEmployee.Visible = true;

            lblEmpName.Visible = true;
            txtEmployeeName.Visible = true;
        }

        protected void btnGetAccountInfo_Click(object sender, EventArgs e)
        {
            CreditCardSvc.CreditCard pxy = new CreditCardSvc.CreditCard();

            if ((txtCardNumber.Text == "") || (txtCVVNumber.Text == ""))
            {
                lblError.Visible = true;
                lblError.Text = "Please enter valid card name or valid cvv number";
            }

            if (IsPostBack)
            {
                gvPaymentInfo.Visible = true;
                ds = pxy.GetPaymentDetails(txtCardNumber.Text, txtCVVNumber.Text, 123);
                gvPaymentInfo.DataSource = ds;
                gvPaymentInfo.DataBind();

                Label16.Visible = true;
                txtPaymentAmount.Visible = true;
                btnMakePayment.Visible = true;
            }
        }

        protected void btnMakePayment_Click(object sender, EventArgs e)
        {

            CreditCardSvc.CreditCard pxy = new CreditCardSvc.CreditCard();
            pxy.MakePayment(txtPaymentAmount.Text, txtCardNumber.Text, 123);
            gvPaymentInfo.DataBind();

            Label16.Visible = false;
            txtPaymentAmount.Visible = false; 
            btnMakePayment.Visible = false;
        }
    }
}