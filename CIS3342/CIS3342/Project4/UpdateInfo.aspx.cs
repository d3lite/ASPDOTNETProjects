using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Project4WebService;


namespace Project4
{
    public partial class UpdateInfo : System.Web.UI.Page
    {
        DataSet ds;
        CreditCardSvc.CreditCard pxy = new CreditCardSvc.CreditCard();
        int id = 0;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnFindInfo_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {

                gvCardInformation.Visible = true;
                ds = pxy.GetCreditInformation(txtSSN.Text, txtUserName.Text, 123);
                gvCardInformation.DataSource = ds;
                gvCardInformation.DataBind();


            }
        }

        protected void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            //Test t = new Test();
            CreditCardSvc.CreditCard pxy = new CreditCardSvc.CreditCard();

            TextBox txtBillingAddress = (TextBox)gvCardInformation.Rows[0].FindControl("txtAddress");
            string BillingAddress = txtBillingAddress.Text;

            TextBox txtCity = (TextBox)gvCardInformation.Rows[0].FindControl("txtCity");
            string BillingCity = txtCity.Text;

            TextBox txtState = (TextBox)gvCardInformation.Rows[0].FindControl("txtState");
            string BillingState = txtState.Text;

            TextBox txtZip = (TextBox)gvCardInformation.Rows[0].FindControl("txtZip");
            string BillingZipCode = txtZip.Text;

            string[] array = new string[6];

            array[0] = txtSSN.Text;
            array[1] = txtUserName.Text;
            array[2] = txtBillingAddress.Text;
            array[3] = txtCity.Text;
            array[4] = txtState.Text;
            array[5] = txtZip.Text;

           // t.UpdateCreditInformation(array);
            pxy.UpdateCreditInformation(array, 123);

            lblEmployeeFilledOut.Visible = true;

            if (txtEmployeeName.Text != "")
            {
                lblEmployeeFilledOut.Text = "Application has been updated by Employee: " + txtEmployeeName.Text;
            }
            else
                lblEmployeeFilledOut.Text = "Thank you for updating " + txtUserName.Text;



        }

        protected void btnEmployee_Click(object sender, EventArgs e)
        {
            lblEmployee.Visible = true;
            rbEmployee.Visible = true;

            lblEmpName.Visible = true;
            txtEmployeeName.Visible = true;
        }

        protected void gvCardInformation_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            if(e.CommandName == "Deactivate")
            {
                gvCardInformation.Rows[rowIndex].Cells[0].Enabled = false;
                

            }
            else if (e.CommandName == "Activate")
            {
                gvCardInformation.Rows[rowIndex].Cells[0].Enabled = true;
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