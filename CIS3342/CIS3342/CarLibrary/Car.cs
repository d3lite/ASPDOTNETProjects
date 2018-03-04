using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace CarLibrary
{
    public class Car
    {
        public int carid = 0;
        public string carmake = "";
        public string carmodel = "";
        public int caryear = 0000;
        public double totalprice = 0000;
        public string carcolor = "";
        public ArrayList packages = null;
        public ArrayList packageprice = null;
                                        
        public Car()
        {

        }

        public void NewCar(int carid, string carmake, string carmodel, string carcolor, int caryear, double totalprice, ArrayList packages, ArrayList packageprice)
        {
            this.carid = carid;
            this.carmake = carmake;
            this.caryear = caryear;
            this.totalprice = totalprice;
            this.carcolor = carcolor;
            this.totalprice = totalprice;
            this.packages = packages;
            this.packageprice = packageprice;                           
        }

        public int CarID
        {
            get { return carid; }
            set { carid = value; }
        }

        public string CarMake
        {
            get { return carmake; }
            set { carmake = value; }
        }

        public string CarModel
        {
            get { return carmodel; }
            set { carmodel = value; }
        }

        public string CarColor
        {
            get { return carcolor; }
            set { carcolor = value; }
        }

        public int CarYear
        {
            get { return caryear; }
            set { caryear = value; }
        }

        public double TotalPrice
        {
            get { return totalprice; }
            set { totalprice = value; }
        }

        public ArrayList Package
        {
            get { return packages; }
            set { packages = value; }
        }

        public ArrayList PackagePrice
        {
            get { return packageprice; }
            set { packageprice = value; }
        }


    }
}
