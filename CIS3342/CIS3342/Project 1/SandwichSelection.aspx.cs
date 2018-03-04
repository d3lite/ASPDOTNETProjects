using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project1
{
    public partial class SandwichSelection : System.Web.UI.Page
    {
        Sandwich sandwich = new Sandwich();
        protected void Page_Load(object sender, EventArgs e)
        {
            string name = Request["txtName"];

            lblName.Text = "Name: " + name;

            string phonenumber = Request["txtPhone"];

            lblPhoneNumber.Text = "Phone : " + phonenumber;

            string size = Request["sandwichSize"];
            string meat = Request["Meat"];
            string addon = Request["chkAdditional"];
            string additional = Request["chkPremium"];
            string meal = Request["chkMeal"];
            string tips = Request["txtTips"];



            lblSandwichSize.Text = "Sandwich Size: " + size + "( " + sandwich.SandwichSizeCalc(size).ToString("c") + ")";
            lblMeatType.Text = "Meat Type: " + meat;
            lblAddonItems.Text = "Addon Items : " + addon;
            lblAdditionalItems.Text = "Additional Items : " + additional + " (" + sandwich.CalculateAddonPrice(additional).ToString("c") + ")";
            lblMeal.Text = "Meal : " + meal + "(" + sandwich.CalculateMealPrice(meal).ToString("c") + ")";
            lblTips.Text = "Tips : " + tips;

            int finalprice = sandwich.SandwichSizeCalc(size) + sandwich.CalculateAddonPrice(additional) + sandwich.CalculateMealPrice(meal) + sandwich.CalculateTips(tips);


            lblFinalPrice.Text = "Total Price is : " + finalprice.ToString("c");





        }
    }
}