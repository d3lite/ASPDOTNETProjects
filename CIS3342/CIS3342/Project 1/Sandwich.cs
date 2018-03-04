using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project1
{
    public class Sandwich
    {
        private int price = 0;
        private int addonprice = 0;
        private int mealprice = 0;
        private int tipmoney = 0;




        public int SandwichSizeCalc(string size)
        {

            if (size == "Small")
            {
                price = 3;
            }
            else if (size == "Medium")
            {
                price = 4;
            }
            else if (size == "Large")
            {
                price = 5;

            }

            return price;
        }

        public int CalculateAddonPrice(string addon)
        {

            if (addon == "Extra Cheese")
            {
                addonprice = 1;
            }
            else if (addon == "Extra Meat")
            {
                addonprice = 3;

            }
            else if (addon == "Add Bacon")
            {
                addonprice = 2;

            }
            else if (addon == "Extra Cheese,Extra Meat")
            {

                addonprice = 5;
            }
            else if (addon == "Extra Cheese,Extra Meat,Add Bacon")
            {
                addonprice = 6;
            }
            else if (addon == "Extra Cheese,Add Bacon")
            {
                addonprice = 3;
            }
            else if (addon == "Extra Meat,Add Bacon")
            {
                addonprice = 4;
            }





            return addonprice;
        }


        public int CalculateMealPrice(string addon)
        {
            if (addon == "Fountain Drinks and Chips")
                mealprice = 3;
            return mealprice;
        }

        public int CalculateTips(string tips)
        {
            if (tips == "$1.00")
            {

                tipmoney = 1;
            }
            else if (tips == "$2.00")
            {
                tipmoney = 2;
            }
            else if (tips == "$3.00")
            {
                tipmoney = 3;
            }
            else if (tips == "$5.00")
            {
                tipmoney = 5;
            }
            else
                tipmoney = 0;


            return tipmoney;
        }



    }
}