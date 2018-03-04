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
    public partial class Manage_Reservation : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Restaurant rev = new Restaurant(objDB, objCommand);
                ds = objDB.GetDataSetUsingCmdObj(rev.GetRestaurant());

                string[] restid = new string[1];
                restid[0] = "RestaurantID";
                gvReserveRest.DataKeyNames = restid;
                gvReserveRest.DataBind();
                gvReserveRest.DataSource = ds;
                gvReserveRest.DataBind();

                string[] revid = new string[1];
                revid[0] = "ReservationID";
                gvMyReservation.DataKeyNames = revid;
                gvMyReservation.DataBind();

            }



        }

        protected void btnManageReviews_Click(object sender, EventArgs e)
        {
            Response.Redirect("Manage_Reviews.aspx");
        }

        protected void btnManageRestaurant_Click(object sender, EventArgs e)
        {
            Response.Redirect("Manage_Restaurant.aspx");
        }

        protected void btnManageReservation_Click(object sender, EventArgs e)
        {
            Response.Redirect("Manage_Reservation.aspx");
        }

        protected void gvReserveRest_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            string restid = gvReserveRest.DataKeys[rowIndex].Value.ToString();
            Reservation rev = new Reservation(objDB, objCommand);


            if (e.CommandName == "MakeReservation")
            {
                lblTime.Visible = true;
                lblDate.Visible = true;
                ddlTime.Visible = true;
                ddlDate.Visible = true;
                lblName.Visible = true;
                txtName.Visible = true;
            }
            else if (e.CommandName == "ConfirmReservation")
            {   
                int rid = int.Parse(restid.ToString());
                string time = ddlTime.SelectedItem.Value;
                string date = ddlDate.SelectedItem.Value;
                string name = txtName.Text;
                string username = Session["UserName"].ToString();

                rev.InsertReservation(rid, time, date, name, username);
                txtName.Text = "";

                lblTime.Visible = false;
                lblDate.Visible = false;
                ddlTime.Visible = false;
                ddlDate.Visible = false;
                txtName.Visible = false;
                lblName.Visible = false;


              }



        }

        protected void btnManageLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void btnShowMyReserv_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                gvMyReservation.Visible = true;
                Reservation rev = new Reservation(objDB, objCommand);
                ds = objDB.GetDataSetUsingCmdObj(rev.GetReservationByUser(Session["UserName"].ToString()));
                gvMyReservation.DataSource = ds;
                gvMyReservation.DataBind();
            }
        }

        protected void gvMyReservation_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            string revid = gvMyReservation.DataKeys[rowIndex].Value.ToString();
            Reservation rev = new Reservation(objDB, objCommand);

            if (e.CommandName == "CancelReservation")
            {
                
                    int id = int.Parse(revid.ToString());
                    rev.DeleteReservationByID(id);
                    gvMyReservation.DataBind();
                    gvMyReservation.Visible = false;
                
            }

        }

        protected void btnShowRestReserve_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (Session["UserType"].ToString() == "Representative")
                {
                    gvRestRev.Visible = true;
                    Reservation rev = new Reservation(objDB, objCommand);
                    ds = objDB.GetDataSetUsingCmdObj(rev.GetReservationByUser(Session["UserName"].ToString()));
                    gvRestRev.DataSource = ds;
                    gvRestRev.DataBind();

                }
                else lblError.Visible = true;
                lblError.Text = "Sorry this option is for representative users only";
            }
        }
    }
}