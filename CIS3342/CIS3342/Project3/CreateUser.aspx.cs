using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utilities;
using System.Data;
using System.Data.SqlClient;

namespace Project3
{
    public partial class CreateUser : System.Web.UI.Page

    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {




        }

        public void createUser( string userName, string myName, string userType)
        {
            

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CreateUser";
           

            SqlParameter inputPar = new SqlParameter("@userName", userName);
            inputPar.Direction = ParameterDirection.Input;
            inputPar.SqlDbType = SqlDbType.VarChar;
            inputPar.Size = 50;
            objCommand.Parameters.Add(inputPar);


            inputPar = new SqlParameter("@name", myName);
            inputPar.Direction = ParameterDirection.Input;
            inputPar.SqlDbType = SqlDbType.VarChar;
            inputPar.Size = 50;
            objCommand.Parameters.Add(inputPar);

            inputPar = new SqlParameter("@userType", userType);
            inputPar.Direction = ParameterDirection.Input;
            inputPar.SqlDbType = SqlDbType.VarChar;
            inputPar.Size = 50;
            objCommand.Parameters.Add(inputPar);

            objDB.DoUpdateUsingCmdObj(objCommand);
       









        }

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            createUser(txtUsername.Text, txtName.Text, ddlTypeSignUp.SelectedValue);
            Response.Redirect("Login.aspx");
        }
    }
}