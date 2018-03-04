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
    public partial class Home : System.Web.UI.Page
    {
        CreditCardSvc.CreditCard pxy = new CreditCardSvc.CreditCard();
        double balance = 0;
        double limit = 1000;


        protected void Page_Load(object sender, EventArgs e)
        {



        }

        protected void btnApplyForCreditCard_Click(object sender, EventArgs e)
        {

            if ((txtFirstName.Text == "") || (txtLastName.Text == "") || (txtUserName.Text == "") || (txtSSN.Text == "") || (txtAddress.Text == "") || (txtCity.Text == "") || (txtState.Text == "") || (txtZip.Text == "") || (txtCardNumber.Text == "") || (txtCVVNumber.Text == "") || (txtMonthYear.Text == ""))
            {
                lblError.Visible = true;
                lblError.Text = "Please enter all the information above";
            }
            else
            {
                string[] cardholder = new string[14];
                cardholder[0] = txtSSN.Text;
                cardholder[1] = txtUserName.Text;
                cardholder[2] = txtCardNumber.Text;
                cardholder[3] = txtCVVNumber.Text;
                cardholder[4] = txtMonthYear.Text;
                cardholder[5] = ddlCardType.SelectedItem.Value;
                cardholder[6] = txtFirstName.Text;
                cardholder[7] = txtLastName.Text;

                cardholder[8] = balance.ToString();
                cardholder[9] = limit.ToString();
                cardholder[10] = txtAddress.Text;
                cardholder[11] = txtCity.Text;
                cardholder[12] = txtState.Text;
                cardholder[13] = txtZip.Text;


                pxy.AddCreditCard(cardholder, 123);


                lblApprovalMessage.Visible = true;
                lblcrednum.Visible = true;
                lblcredtypemessage.Visible = true;
                lblcvvnum.Visible = true;
                lblcredlimit.Visible = true;
                lblexp.Visible = true;
                lblEmployeeFilledOut.Visible = true;

                lblApprovalMessage.Text = "Congrats! You have been approved, see below for your creditcard infromation:";
                lblcrednum.Text = " Your Credit Card Number:  " + txtCardNumber.Text;
                lblcredtypemessage.Text = " Your Credit Card Type:  " + ddlCardType.SelectedItem.Value;
                lblcredlimit.Text = "Your Credit Limit:  " + limit.ToString();
                lblcvvnum.Text = "Your CVV Number:  " + txtCVVNumber.Text;
                lblexp.Text = "Your Expiration Month and Year: " + txtMonthYear.Text;
            }
            if (txtEmployeeName.Text != "")
            {
                lblEmployeeFilledOut.Text = "Application has been filled out by Employee: " + txtEmployeeName.Text;
            }
            else
                lblEmployeeFilledOut.Text = "Thank you for applying Customer: " + txtFirstName.Text + " " + txtLastName.Text;

            txtAddress.Text = " ";
            txtSSN.Text = " ";
            txtUserName.Text = " ";
            txtFirstName.Text = " ";
            txtLastName.Text = " ";
            txtCardNumber.Text = " ";
            txtCVVNumber.Text = " ";
            txtMonthYear.Text = " ";
            txtAddress.Text = " ";
            txtCity.Text = " ";
            txtState.Text = " ";
            txtZip.Text = " ";

            

        }

        protected void btnEmployee_Click(object sender, EventArgs e)
        {
            
            lblEmployee.Visible = true;
            rbEmployee.Visible = true;

            lblEmpName.Visible = true;
            txtEmployeeName.Visible = true;

           

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