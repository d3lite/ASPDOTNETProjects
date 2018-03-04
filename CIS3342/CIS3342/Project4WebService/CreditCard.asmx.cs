using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using Utilities;


namespace Project4WebService
{
    /// <summary>
    /// Summary description for CreditCard
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CreditCard : System.Web.Services.WebService
    {
        DBConnect objDB = new DBConnect();
        SqlCommand objCommand = new SqlCommand();

        [WebMethod]
        public void AddCreditCard(string[] array, int APIKey)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "AddCreditCardInformation";

            SqlParameter inputParameter = new SqlParameter("@ssn", array[0]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@username", array[1]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@ccnumber", array[2]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@cvvnumber", array[3]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@expmonthyear", array[4]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            
            inputParameter = new SqlParameter("@credtype", array[5]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@fname", array[6]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@lname", array[7]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@credbalance", array[8]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@credlimit", array[9]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@straddress", array[10]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@city", array[11]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@state", array[12]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@zipcode", array[13]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            objDB.DoUpdateUsingCmdObj(objCommand);


        }

        [WebMethod]
        
        public DataSet GetCreditInformation(string ssn, string username, int APIKey)
        {
             

            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetCustomerInfo";

            SqlParameter inputParameter = new SqlParameter("@ssn", ssn);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@username", username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

           return objDB.GetDataSetUsingCmdObj(objCommand);

                                              
        }
        [WebMethod]
        public void UpdateCreditInformation(string[] array, int APIKey)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "UpdateCreditCardInformation";

            SqlParameter inputParameter = new SqlParameter("@ssn", array[0]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@username", array[1]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@address", array[2]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@city", array[3]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@state", array[4]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@zip", array[5]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            objDB.DoUpdateUsingCmdObj(objCommand);

        }

        [WebMethod]
        // this method verifies the data entered by the user in the purchase page 
        // this method validates the card number, cvv number, address, etc. 
        public int[] VerifyInformation(string[] myarray, int APIKey)
        {
            DBConnect objDB = new DBConnect();
            SqlCommand objCommand = new SqlCommand();
            int[] ReturnResult = new int[5];

            objCommand.Parameters.Clear();


            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "CheckCreditCardNumber";  //Checking Card Number

            objCommand.Parameters.AddWithValue("@CreditCardnumber", myarray[0]);

            SqlParameter outputPrameter = new SqlParameter("@result", 0);
            outputPrameter.Direction = ParameterDirection.Output;
            objCommand.Parameters.Add(outputPrameter);

            objDB.GetDataSetUsingCmdObj(objCommand);


            int count = int.Parse(objCommand.Parameters["@result"].Value.ToString());
            ReturnResult[0] = count;

            int result = 0;
            if (count == 1)
            {
                objCommand.Parameters.Clear();


                objCommand.CommandType = CommandType.StoredProcedure;
                objCommand.CommandText = "CheckCVVNum";

                objCommand.Parameters.AddWithValue("@CreditCardnumber", myarray[0]);
                objCommand.Parameters.AddWithValue("@cvvnum", myarray[1]);

                outputPrameter = new SqlParameter("@verifycvvnum", 0);
                outputPrameter.Direction = ParameterDirection.Output;
                objCommand.Parameters.Add(outputPrameter);

                objDB.GetDataSetUsingCmdObj(objCommand);


                result = int.Parse(objCommand.Parameters["@verifycvvnum"].Value.ToString());
                ReturnResult[1] = result;

                int number = 0;
                if (result == 3)
                {
                    objCommand.Parameters.Clear();


                    objCommand.CommandType = CommandType.StoredProcedure;     //Checking Billing Address
                    objCommand.CommandText = "CheckBillingAddress";

                    objCommand.Parameters.AddWithValue("@CreditCardnumber", myarray[0]);
                    objCommand.Parameters.AddWithValue("@cvvnum", myarray[1]);
                    objCommand.Parameters.AddWithValue("@BillingAddress", myarray[2]);
                    objCommand.Parameters.AddWithValue("@billingcity", myarray[3]);
                    objCommand.Parameters.AddWithValue("@billingstate", myarray[4]);
                    objCommand.Parameters.AddWithValue("@billingzip", myarray[5]);



                    outputPrameter = new SqlParameter("@result", 0);
                    outputPrameter.Direction = ParameterDirection.Output;
                    objCommand.Parameters.Add(outputPrameter);

                    objDB.GetDataSetUsingCmdObj(objCommand);


                    number = int.Parse(objCommand.Parameters["@result"].Value.ToString());
                    ReturnResult[2] = number;

                    if (number == 5)
                    {
                        objCommand.Parameters.Clear();


                        objCommand.CommandType = CommandType.StoredProcedure;   //Checking Balance
                        objCommand.CommandText = "GetCreditCardLimit";

                        objCommand.Parameters.AddWithValue("@creditcardnumber", myarray[0]);
                        objCommand.Parameters.AddWithValue("@cvvnum", myarray[1]);

                        outputPrameter = new SqlParameter("@result", 0);
                        outputPrameter.Direction = ParameterDirection.Output;
                        objCommand.Parameters.Add(outputPrameter);

                        objDB.GetDataSetUsingCmdObj(objCommand);


                        string creditlimit = objCommand.Parameters["@result"].Value.ToString();
                        float creditlimitindollars = float.Parse(creditlimit);
                        float ItemCost = float.Parse(myarray[6].ToString());
                        if (ItemCost <= creditlimitindollars)
                        {
                            ReturnResult[3] = 100;
                        }
                        else
                        {
                            ReturnResult[3] = 50;
                        }
                    }  //Will Check
                    //if (ReturnResult[3] == 100)
                    //{
                    //    objCommand.Parameters.Clear();
                    //    objCommand.CommandType = CommandType.StoredProcedure;
                    //    objCommand.CommandText = "GetMonthYear";

                    //    objCommand.Parameters.AddWithValue("@creditcardnumber", myarray[0]);
                    //    objCommand.Parameters.AddWithValue("@cvvnum", myarray[1]);


                    //    outputPrameter = new SqlParameter("@result", 0);
                    //    outputPrameter.Direction = ParameterDirection.Output;
                    //    objCommand.Parameters.Add(outputPrameter);

                    //    objDB.GetDataSetUsingCmdObj(objCommand);


                    //    string monthyear = objCommand.Parameters["@result"].Value.ToString();

                    //    string UserMonthYear = myarray[7];
                    //    if (UserMonthYear == monthyear)
                    //    {
                    //        ReturnResult[4] = 10;
                    //    }
                    //    else
                    //    {
                    //        ReturnResult[4] = 20;
                    //    }


                    //}

                }
            }
            return ReturnResult;
        }

        [WebMethod]
        public void AddToBalance(string[] array, int APIKey)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "AddToBalance";

            SqlParameter inputParameter = new SqlParameter("@itemprice", array[6]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@creditcardnumber", array[0]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            objDB.DoUpdateUsingCmdObj(objCommand);


        }

        [WebMethod]
        public void AddTransaction(string[] array, int APIKey)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "AddTransaction";

            SqlParameter inputParameter = new SqlParameter("@username", array[0]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@itemname", array[1]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@itemprice", array[2]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@ccnum", array[3]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@cvvnum", array[4]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@trandate", array[5]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@transtatus", array[6]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@monthyear", array[7]);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            objDB.DoUpdateUsingCmdObj(objCommand);


        }

        [WebMethod]
        public DataSet GetTransactionByUserName(string username, int APIKey)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetTransactionByUserName";

            SqlParameter inputParameter = new SqlParameter("@username", username);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);


            return objDB.GetDataSetUsingCmdObj(objCommand);
        }

        [WebMethod]
        public DataSet GetPaymentDetails(string cardnum, string cvvnum, int APIKey)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetCardInfoByUser";

            SqlParameter inputParameter = new SqlParameter("@cardnum", cardnum);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@cvvnum", cvvnum);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);


            return objDB.GetDataSetUsingCmdObj(objCommand);
        }

        [WebMethod]

        public void MakePayment(string payment, string cardnum, int APIKey)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "MakePaymentToCard";

            SqlParameter inputParameter = new SqlParameter("@amount", payment);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            inputParameter = new SqlParameter("@cardnum", cardnum);
            inputParameter.Direction = ParameterDirection.Input;
            inputParameter.SqlDbType = SqlDbType.VarChar;
            objCommand.Parameters.Add(inputParameter);

            objDB.DoUpdateUsingCmdObj(objCommand);


        }


    }
}
