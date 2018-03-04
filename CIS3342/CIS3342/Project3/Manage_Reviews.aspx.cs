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
    public partial class Manage_Reviews : System.Web.UI.Page
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();
        DataSet ds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblRating.Visible = false;
                lblRating0.Visible = false;
                lblReviews.Visible = false;
                lblPriceRange.Visible = false;
                txtReviews.Visible = false;
                rbRating.Visible = false;
                rbPriceRange.Visible = false;

                gvSearchRest.Visible = false;
                string[] names = new string[1];
                names[0] = "RestaurantID";
                gvSearchRest.DataKeyNames = names;
                gvSearchRest.DataBind();

                gvMyReviews.Visible = false;
                string[] id = new string[1];
                id[0] = "ReviewID";
                gvMyReviews.DataKeyNames = id;
                gvMyReviews.DataBind();

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

        protected void btnSearch_Click(object sender, EventArgs e)
        {   if (IsPostBack)
            {
                gvSearchRest.Visible = true;
                ShowSearchResult();
            }
         }

        public void ShowSearchResult()
        {
            Restaurant rest = new Restaurant(objDB, objCommand);
            ds = objDB.GetDataSetUsingCmdObj(rest.SearchRestaurantByName(txtSearchRest.Text));
            gvSearchRest.DataSource = ds;
            gvSearchRest.DataBind();
        }

        protected void gvSearchRest_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            string restid = gvSearchRest.DataKeys[rowIndex].Value.ToString();
            Reviews rev = new Reviews(objDB, objCommand);

            if (e.CommandName == "WriteReviews")
            {
                if (IsPostBack)
                {
                    lblRating.Visible = true;
                    lblRating0.Visible = true;
                    lblReviews.Visible = true;
                    lblPriceRange.Visible = true;
                    txtReviews.Visible = true;
                    rbRating.Visible = true;
                    rbPriceRange.Visible = true;



                }



            }
            else if (e.CommandName == "SeeReviews")
            {
                if (IsPostBack)
                {
                    lblRating.Visible = false;
                    lblRating0.Visible = false;
                    lblReviews.Visible = false;
                    lblPriceRange.Visible = false;
                    txtReviews.Visible = false;
                    rbRating.Visible = false;
                    rbPriceRange.Visible = false;

                    gvReviewsByID.Visible = true;
                    Reviews review = new Reviews(objDB, objCommand);
                    ds = objDB.GetDataSetUsingCmdObj(rev.GetReviewsByRestID(int.Parse(restid.ToString())));
                    gvReviewsByID.DataSource = ds;
                    gvReviewsByID.DataBind();
                }



            }
            else if (e.CommandName == "SubmitReviews")
            {
                string username = Session["UserName"].ToString();
                string review = txtReviews.Text;
                int rating = int.Parse(rbRating.SelectedItem.Value);
                int pricerange = int.Parse(rbPriceRange.SelectedItem.Value);

               
                rev.InsertReview(int.Parse(restid.ToString()), rating, pricerange, username, review);
                lblRating.Visible = false;
                lblRating0.Visible = false;
                lblReviews.Visible = false;
                lblPriceRange.Visible = false;
                txtReviews.Visible = false;
                rbRating.Visible = false;
                rbPriceRange.Visible = false;

            }

        }

        protected void btnManageLogOut_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }

        protected void btnMyReview_Click(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                gvMyReviews.Visible = true;
                Reviews rev = new Reviews(objDB, objCommand);
                ds = objDB.GetDataSetUsingCmdObj(rev.GetReviewsByUser(Session["UserName"].ToString()));
                gvMyReviews.DataSource = ds;
                gvMyReviews.DataBind();
            }
        }

        protected void gvMyReviews_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            string restid = gvMyReviews.DataKeys[rowIndex].Value.ToString();
            Reviews rev = new Reviews(objDB, objCommand);

            if (e.CommandName == "DeleteMyReviews")
            {
                if (IsPostBack)
                {   if (Session["UserType"].ToString() == "Reviewer")
                    {
                        rev.DeleteReviewersByID(int.Parse(restid.ToString()));
                        gvMyReviews.DataBind();
                        lblRating.Visible = false;
                        lblRating0.Visible = false;
                        lblReviews.Visible = false;
                        lblPriceRange.Visible = false;
                        txtReviews.Visible = false;
                        rbRating.Visible = false;
                        rbPriceRange.Visible = false;
                    }
                    else lblError.Visible = true;
                    lblError.Text = "Sorry only a reviewer may delete their reviews.";
                }

            }
            else if (e.CommandName == "EditMyReviews")
            {
                lblRating.Visible = true;
                lblRating0.Visible = true;
                lblReviews.Visible = true;
                lblPriceRange.Visible = true;
                txtReviews.Visible = true;
                rbRating.Visible = true;
                rbPriceRange.Visible = true;
                lblRating.Text = "Edit your reviews here: ";

               


            }
            else if (e.CommandName == "UpdateMyReviews")
            {
                int rid = int.Parse(restid.ToString());
                string reviews = txtReviews.Text;
                int rating = int.Parse(rbRating.SelectedItem.Value);
                int pricerange = int.Parse(rbPriceRange.SelectedItem.Value);

                rev.UpdateReviewsByID(rid, rating, pricerange, reviews);
                gvMyReviews.DataBind();

                lblRating.Visible = false;
                lblRating0.Visible = false;
                lblReviews.Visible = false;
                lblPriceRange.Visible = false;
                txtReviews.Visible = false;
                rbRating.Visible = false;
                rbPriceRange.Visible = false;
            }








        }

        
    }
}