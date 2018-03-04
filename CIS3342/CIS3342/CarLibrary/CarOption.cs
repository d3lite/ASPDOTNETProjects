using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CarLibrary
{
   public class CarOption
    {
        ArrayList packagedescription = new ArrayList();
        ArrayList packageprice = new ArrayList();

        public double TotalPackagePrice(ArrayList packprice)
        {
            int count = packprice.Count;
            double total = 0;

            for (int i = 0; i<count; i++)
            {
                double number = Double.Parse(packprice[i].ToString());
                total = total + number;
            }

            return total;
        }

        public ArrayList PackageDescInfo(ArrayList packagedesc)
        {
            packagedescription = packagedesc;

            return packagedescription;
        }

        
        public ArrayList PackagePriceInfo(ArrayList thispackageprice)
        {
            packageprice = thispackageprice;


            return packageprice;
        }


    }
}
