using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Data.SqlClient;
using RestaurantReview;


namespace Project3
{
    public partial class Login : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

       
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateUser.aspx");

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserLogin userLog = new UserLogin(objDB, objCommand);
                if (userLog.verifyUser(txtUsername.Text, ddlUserTypeLogIn.SelectedItem.Value))//user exists
                {
                    if (ddlUserTypeLogIn.SelectedItem.Value == "Reviewer")
                    {
                        Session["UserName"] = txtUsername.Text;
                        Session["UserType"] = ddlUserTypeLogIn.SelectedItem.Value;
                        // Server.Transfer("SellerPage.aspx");
                        Response.Redirect("Manage_Restaurant.aspx", false);

                    }
                    else if (ddlUserTypeLogIn.SelectedItem.Value == "Representative")
                    {
                        Session["UserName"] = txtUsername.Text;
                        Session["UserType"] = ddlUserTypeLogIn.SelectedItem.Value;

                        Server.Transfer("Manage_Restaurant.aspx");

                    }
                }
                else
                {//user doesnt exists
                    lblUserError.Text = "User Does not Exists";
                    lblUserError.Visible = true;
                    txtUsername.Text = "";


                }
            }
            catch (Exception ex) { }
        }

       
    }
}