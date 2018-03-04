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
    public partial class Purchase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnPurchaseItem_Click(object sender, EventArgs e)
        {
            //Test test = new Test();
            
            CreditCardSvc.CreditCard pxy = new CreditCardSvc.CreditCard();

            string[] array = new string[8];

            
           if (ValidateString(txtCardNumber.Text) == false)
            {
                lblError.Visible = true;
                lblError.Text = "Please only enter numeric value for CreditCard Number";
            }

            else if (ValidateString(txtCVVNum.Text) == false)
            {
                lblError.Visible = true;
                lblError.Text = "Please only enter numeric value for CVV Number";
            }
            else if (ValidateString(txtMonthYear.Text) == false)
            {
                lblError.Visible = true;
                lblError.Text = "Please only enter correct format for MonthYear";
            }
            else if (ValidateString(txtAddress.Text) == false)
            {
                lblError.Visible = true;
                lblError.Text = "Please enter correct format for address for example: 123 abc street";
            }
            else if (ValidateString(txtCity.Text) == false)
            {
                lblError.Visible = true;
                lblError.Text = "Please enter correct format for city for example: Philadelphia";
            }
            else if (ValidateString(txtState.Text) == false)
            {
                lblError.Visible = true;
                lblError.Text = "Please enter correct format for state for example: PA";
            }
            else if (ValidateString(txtZip.Text) == false)
            {
                lblError.Visible = true;
                lblError.Text = "Please enter correct format for zipcode for example: 19001";
            }

            else
            
                lblError.Visible = false;
                array[0] = txtCardNumber.Text;
                array[1] = txtCVVNum.Text;
                array[2] = txtAddress.Text;
                array[3] = txtCity.Text;
                array[4] = txtState.Text;
                array[5] = txtZip.Text;
                array[6] = txtItemPrice.Text;
                array[7] = txtMonthYear.Text;

                int[] verify = pxy.VerifyInformation(array, 123); // test.VerifyInformation(array);


            if (verify[0] == 2)
            {
                lblError.Visible = true;
                lblError.Text = "Transaction Declined: invalid cc number";
            }
            else if (verify[1] == 4)
            {
                lblError.Visible = true;
                lblError.Text = "Transaction Declined: invalid cvv";
            }

            else if (verify[2] == 6)
            {
                lblError.Visible = true;
                lblError.Text = "Transaction Declined: invalid address";
            }

            else if (verify[3] == 50)
            {
                lblError1.Visible = true;
                lblError1.Text = "Transaction Declined: credit limit error";
            }
            else if (verify[4] == 20)
            {
                lblError.Visible = true;
                lblError.Text = "Transaction Declined: invalid entry";
            }
            else
                lblError.Visible = false;
                pxy.AddToBalance(array, 123);    
                //test.AddToBalance(array);
                string[] mytransaction = new string[8];
                mytransaction[0] = txtUserName.Text;
                mytransaction[1] = txtItemName.Text;
                mytransaction[2] = txtItemPrice.Text;
            mytransaction[3] = txtCardNumber.Text;
            mytransaction[4] = txtCVVNum.Text;
            string str = null;
            if (str == "Transaction Declined: credit limit error")
            {
                mytransaction[5] = lblError1.Text;
            }
            else mytransaction[5] = "Transaction Approve";
            DateTime today = DateTime.Today;
            string transactionday = today.ToShortDateString();
            mytransaction[6] = transactionday;
            mytransaction[7] = txtMonthYear.Text;
            pxy.AddTransaction(mytransaction, 123);
            //test.AddTransaction(mytransaction);
            lblError1.Text = "Transaction Approved!";
                              





        }

        protected void btnPaymentInfo_Click(object sender, EventArgs e)
        {


            if (txtItemPrice.Text == "")
            {
                lblError2.Visible = true;
                lblError2.Text = "Please only enter numeric value for Item Price";
              
            }
            else if (txtItemName.Text == "")
            {
                lblError2.Visible = true;
                lblError2.Text = "Please only enter numeric value for Item ";
               
            }
            else 
            {

                lblUserName.Visible = true; lblCreditCardNumber.Visible = true; lblCVVNumber.Visible = true; lblMonthYear.Visible = true;
                lblBill.Visible = true; lbladdress.Visible = true; lblCity.Visible = true; lblbillstate.Visible = true; lblzipcode.Visible = true;
                txtCardNumber.Visible = true; txtCVVNum.Visible = true; txtMonthYear.Visible = true; txtAddress.Visible = true; txtCity.Visible = true;
                txtState.Visible = true; txtZip.Visible = true; btnPurchaseItem.Visible = true; txtUserName.Visible = true;
            }

        }

        public bool ValidateString(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return false;
            }

            foreach (char item in str)
            {
                if (char.IsLetter(item) == true)
                {
                    return false;
                }
            }

            return true;


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