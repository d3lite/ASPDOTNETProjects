using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using Utilities;
using RestaurantReview;

namespace Project3
{
    public partial class Edit_Restaurant : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        DataSet ds;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Category cat = new Category(objDB, objCommand);
                ds = objDB.GetDataSetUsingCmdObj(cat.GetCategory());
                ddlCategory.DataSource = ds;
                ddlCategory.DataTextField = "CategoryName";
                ddlCategory.DataValueField = "CategoryName";
                ddlCategory.DataBind();
            }
        }

        protected void btnUpdateRestaurant_Click(object sender, EventArgs e)
        {
            Restaurant rest = new Restaurant(objDB, objCommand);
            string restid = Session["RestID"].ToString();
            string category = ddlCategory.SelectedItem.Value;

            if ((txtRestName.Text == "") || (txtCity.Text == "") || (txtState.Text == ""))
            {
                lblError.Visible = true;
                lblError.Text = "Cannot Leave Any of These Fields Blank";
            }
            else
            {
                rest.UpdateRestaurant(int.Parse(restid.ToString()), txtRestName.Text, category, txtCity.Text, txtState.Text);
                Response.Redirect("Manage_Restaurant.aspx");
            }

        }
    }
}