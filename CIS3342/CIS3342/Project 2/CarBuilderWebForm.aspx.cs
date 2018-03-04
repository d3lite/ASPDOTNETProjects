using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Data;
using CarLibrary;

namespace Project2
{
    
    public partial class CarBuilderWebForm : System.Web.UI.Page
    {
        DBConnect cn = new DBConnect();
        private int carID = 0;
        private string name = "";
        private string address = "";
        private int year = 0000;
        private string model = "";
        private string make = "";
        private string contactorno = "";
        private string buyorlease = "";
        private string phonenumber = "";
        private string carcolor = "";

        Car mycar = new Car();
        Car coolCar = new Car();

        ArrayList carmodel = new ArrayList();
        ArrayList packageprice = new ArrayList();
        ArrayList packages = new ArrayList();

        CarOption caroption = new CarOption();

        NewCar newcar = new NewCar();


        
        protected void Page_Load(object sender, EventArgs e)
        {
            lbltxtName.Visible = false;
            lbltxtAddress.Visible = false;
            lbltxtBuyorLease.Visible = false;
            lbltxtPhone.Visible = false;
            lblDealershiporContact.Visible = false;
            lblCarInfo.Visible = false;
      

            if (!IsPostBack)
            {

                string carmake = "Select DISTINCT CarMake from Cars";
                DataSet myds = cn.GetDataSet(carmake);

                ddlCarMake.DataSource = myds;
                ddlCarMake.DataTextField = "CarMake";
                ddlCarMake.DataBind();



                ShowCarModel(ddlCarMake.Text); 
            }
        }


            public void ShowCarModel(string Make)
        {
            string strSQL = "Select CarModel, CarID from Cars where CarMake IN ('" + Make + "')";
            
            ddlCarModel.DataSource = cn.GetDataSet(strSQL);
            ddlCarModel.DataTextField = "CarModel";
            ddlCarModel.DataValueField = "CarID";
         

            ddlCarModel.DataBind();

        }

        protected void ddlCarMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowCarModel(ddlCarMake.SelectedValue);
        }

        public void ShowGridViewPackages(string carid)
        {
            carID = int.Parse(carid);

            String strSQL = "SELECT PackageDescription, Price FROM Packages where CarID IN ('" + carID + "')";
            gvPackages.DataSource = cn.GetDataSet(strSQL);
            gvPackages.DataBind();

        }
      

        protected void ddlCarModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGridViewPackages(ddlCarModel.SelectedItem.Value.ToString());
        }

        protected void btnManagementReport_Click(object sender, EventArgs e)
        {
            string strSQl = "SELECT * FROM Cars ORDER By TotalSales DESC ";
            gvManageReport.DataSource = cn.GetDataSet(strSQl);
            gvManageReport.DataBind();
            gvOutPut.Visible = false;
            btnBuildCar.Visible = false;
        }

        protected void gvPackages_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int rowIndex = int.Parse(e.CommandArgument.ToString());
            if (e.CommandName == "AddPackages")


                gvPackages.Rows[rowIndex].Cells[2].Enabled = false;



            else if (e.CommandName == "RemovePackages")

                gvPackages.Rows[rowIndex].Cells[2].Enabled = true;

        }

        public static bool ValidateInfo(string str)
        {
            if (string.IsNullOrEmpty(str) || str.Length > 35)
            {
                return false;
            }

            foreach (char strings in str)
            {
                if (!char.IsLetter(strings))
                {
                    return false;
                }
            }

            return true;


        }

        protected void btnBuildCar_Click(object sender, EventArgs e)
        {
            name = txtName.Text;
            address = txtAddress.Text;
            phonenumber = txtPhonenumber.Text;
            carcolor = rblColorOption.SelectedValue;
            make = ddlCarMake.SelectedValue.ToString();
            model = ddlCarModel.SelectedValue.ToString();
            contactorno = rblDealershiporNo.SelectedValue;
            buyorlease = rblBuyorLease.SelectedValue;

            if (ValidateInfo(name) == false)
            {
                lbltxtName.Visible = true;
                lbltxtName.Text = "Please enter your valid name";

            }

            else if (address == "")
            {
                lbltxtAddress.Visible = true;
                lbltxtAddress.Text = "Please enter your address";

            }
            else if (ValidateInfo(phonenumber) == true)
            {
                lbltxtPhone.Visible = true;
                lbltxtPhone.Text = "Please enter your valid phone number";

            }
            else if (carcolor == "" || make == "" || model == "")
            {
                lblCarInfo.Visible = true;
                lblCarInfo.Text = "Please Choose your color";

            }
            else if (contactorno == "")
            {
                lblDealershiporContact.Visible = true;
                lblDealershiporContact.Text = "Please Choose how would you like to contact us";
            }
            else if (buyorlease == "")
            {
                lbltxtBuyorLease.Visible = true;
                lbltxtBuyorLease.Text = "Please Choose if you would like to buy a car or lease.";
            }

            //else
            //{

            //    for (int row = 0; row < gvPackages.Rows.Count; row++)
            //    {

            //        Boolean disabled = !(gvPackages.Rows[row].Cells[2].Enabled);

            //        if (disabled)
            //        {
            //            string package = "";

            //            package = gvPackages.Rows[row].Cells[0].Text;
            //            packages.Add(package);

            //        }

            //    }
            //    int count = packages.Count;






            //    for (int row = 0; row < gvPackages.Rows.Count; row++)
            //    {

            //        Boolean disable = !(gvPackages.Rows[row].Cells[2].Enabled);
            //        if (disable)
            //        {
            //            string pack_price;
            //            double price = 0;

            //            pack_price = gvPackages.Rows[row].Cells[1].Text;


            //            string newstring = pack_price.Replace("$", string.Empty);
            //            price = Double.Parse(newstring);
            //            packageprice.Add(price);

            //        }

            //    }
            //    int counts = packages.Count;

            //    string[] arrlist = new string[count];
            //    for (int i = 0; i < count; i++)
            //    {
            //        arrlist[i] = packages[i].ToString();
            //    }

            //    DataTable dt = new DataTable();

            //    dt.Columns.Add("Package Description");
            //    for (int i = 0; i < arrlist.Count(); i++)
            //    {
            //        dt.Rows.Add();
            //        dt.Rows[i]["Package Description"] = arrlist[i].ToString();

            //    }

            //    string[] arrlistprice = new string[count];
            //    for (int i = 0; i < count; i++)
            //    {
            //        arrlistprice[i] = packageprice[i].ToString();
            //    }
            //    dt.Columns.Add("Price");
            //    for (int i = 0; i < arrlist.Count(); i++)
            //    {
            //        dt.Rows.Add();
            //        dt.Rows[i]["Price"] = "$" + arrlistprice[i].ToString();

            //    }

            //    gvOutPut.DataSource = dt;
            //    gvOutPut.DataBind();


            //    double totalPackagePrice = caroption.TotalPackagePrice(packageprice);

            //    gvOutPut.Columns[0].FooterText = "Total: ";
            //    gvOutPut.Columns[1].FooterText = totalPackagePrice.ToString("c2");



            //    gvOutPut.DataBind();




            //    string stryear = "Select CarYear from Cars where CarMake IN ('" + model + "')";
            //    string year = cn.GetDataSet(stryear).ToString();
            //    int convertyear = int.Parse(year);

            //    string carid = ddlCarModel.SelectedItem.Value.ToString();
            //    int IDcar = int.Parse(carid);
            //    convertyear = newcar.GetCarYear(model);


            //    mycar.NewCar(IDcar, make, model, carcolor, 0000, 0000, packages, packageprice);

            //    newcar.updatemodelTotal(mycar);
            //    double totalprice = newcar.GetTotalPrice(totalPackagePrice, model);
            //    caroption.PackageDescInfo(packages);
            //    caroption.PackagePriceInfo(packageprice);



                lbltxtName.Visible = true;  lbltxtName.Text = "Name : " + name;
                lbltxtAddress.Visible = true; lbltxtAddress.Text = "Address : " + address;
                lbltxtPhone.Visible = true; lbltxtPhone.Text = "Phone number : " + phonenumber;
                lbltxtBuyorLease.Visible = true; lbltxtBuyorLease.Text = buyorlease;
                lblDealershiporContact.Visible = true; lblDealershiporContact.Text = contactorno;
                lblCarInfo.Visible = true; lblCarInfo.Text = "Car make: " + make + " , Car model: " + model + " , Car color: " + carcolor;

                gvPackages.Visible = false;
               

            }
            }
    }

