using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;

namespace CarLibrary
{
   public class NewCar
    {
        DBConnect cn = new DBConnect();



        public void updatemodelTotal(Car mycar)
        {
            string model = mycar.CarModel;
            int number = 1;
            string strsql = "UPDATE Cars SET TotalQuantitySold = TotalQuantitySold + " + number + " WHERE CarModel = '" + model + "'";
            cn.DoUpdate(strsql);
            int carid = mycar.carid;

            for (int i = 0; i < mycar.Package.Count; i++)
            {
                string packaged = mycar.Package[i].ToString();

                string strsqlP = "UPDATE Packages SET TotalQuantitySold = TotalQuantitySold + " + number + " WHERE CarID = '" + carid + "' AND  PackageDescription ='" + packaged + "' ";

                cn.DoUpdate(strsqlP);

            }

        }
        public double GetTotalPrice(double packageprice, string model)
        {
            double total = 0;

            string strsql = "SELECT BasePrice FROM Cars WHERE CarModel = '" + model + "'";
            DataSet myDataSet = cn.GetDataSet(strsql);
            double basePrice = Convert.ToDouble(myDataSet.Tables[0].Rows[0]["BasePrice"].ToString());
            total = basePrice + packageprice;
            string strtotal = "UPDATE Cars SET TotalSales = TotalSales + " + total + " WHERE CarModel = '" + model + "'";
            cn.DoUpdate(strtotal);

            return total;
        }
        public int GetCarYear(string model)
        {
            int caryear = 0000;

            string strsql = "SELECT CarYear FROM Cars Where CarModel = '" + model + "'";
            DataSet mydataset = cn.GetDataSet(strsql);
            int year = Convert.ToInt32(mydataset.Tables[0].Rows[0]["CarYear"].ToString());
            caryear = year;

            return caryear;
        }





    }

}
