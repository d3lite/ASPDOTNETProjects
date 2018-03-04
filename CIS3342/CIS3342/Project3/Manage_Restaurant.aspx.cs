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
    public partial class Manage_Restaurant : System.Web.UI.Page
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

                gvMyRestaurant.Visible = false;
                string[] names = new string[1];
                names[0] = "RestaurantID";
                gvMyRestaurant.DataKeyNames = names;
                gvMyRestaurant.DataBind();
            }

        }

        protected void btnManageRestaurant_Click(object sender, EventArgs e)
        {
            Response.Redirect("Manage_Restaurant.aspx");
        }

        protected void btnManageReviews_Click(object sender, EventArgs e)
        {
            Response.Redirect("Manage_Reviews.aspx");
        }

        protected void btnManageReservation_Click(object sender, EventArgs e)
        {
            Response.Redirect("Manage_Reservation.aspx");
        }

        protected void btnManageLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void btnAddRestaurant_Click(object sender, EventArgs e)
        {
            Restaurant rest = new Restaurant(objDB, objCommand);
            rest.InsertRestaurant(txtRestName.Text,ddlCategory.SelectedItem.Value, txtCity.Text, txtState.Text, Session["UserName"].ToString());
            txtRestName.Text = "";
            txtCity.Text = "";
            txtState.Text = "";


        }

       

        public void ShowSearchResult()
        {
            Restaurant rest = new Restaurant(objDB, objCommand);
            ds = objDB.GetDataSetUsingCmdObj(rest.SearchRestaurant(txtSearchRest.Text));
            gvSearchRest.DataSource = ds;
            gvSearchRest.DataBind();
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                ShowSearchResult();
            }
        }

        protected void btnShowMyRest_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                gvMyRestaurant.Visible = true;
                Restaurant rest = new Restaurant(objDB, objCommand);
                ds = objDB.GetDataSetUsingCmdObj(rest.GetRestaurantByUser(Session["UserName"].ToString()));
                gvMyRestaurant.DataSource = ds;
                gvMyRestaurant.DataBind();
            }
        }

        protected void gvMyRestaurant_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            string restid = gvMyRestaurant.DataKeys[rowIndex].Value.ToString();


            if (e.CommandName == "EditRestaurant")
            {
                if (Session["UserType"].ToString() == "Representative")
                {
                    
                    Session["RestID"] = restid;

                    Response.Redirect("Edit_Restaurant.aspx");

                }
                else
                    lblMessage.Visible = true;
                lblMessage.Text = "Sorry only Representative can edit restaurants";
            }
            else if (e.CommandName == "DeleteRestaurant")
            {
                if (IsPostBack)
                {
                    if (Session["UserType"].ToString() == "Representative")
                    {

                        Restaurant rest = new Restaurant(objDB, objCommand);
                        rest.DeleteRestByID(int.Parse(restid));
                        gvMyRestaurant.DataBind();

                    }
                }
                else lblMessage.Visible = true;
                lblMessage.Text = "Sorry only a Representative can delete a restaurant";
            }
                    
        }
    }
}