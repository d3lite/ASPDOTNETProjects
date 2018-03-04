using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using System.Data;
using System.Data.SqlClient;



namespace RestaurantReview
{
  public  class UserLogin
    {
        private DBConnect objDB;
        private SqlCommand objCommand;

        public UserLogin(DBConnect db, SqlCommand command)
        {
            objDB = db;
            objCommand = command;
        }

        public bool verifyUser(string userName, string userType)
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "ValidateUser";

            SqlParameter inputPar = new SqlParameter("@userName", userName);
            inputPar.Direction = ParameterDirection.Input;
            inputPar.SqlDbType = SqlDbType.VarChar;
            inputPar.Size = 50;
            objCommand.Parameters.Add(inputPar);

            inputPar = new SqlParameter("@userType", userType);
            inputPar.Direction = ParameterDirection.Input;
            inputPar.SqlDbType = SqlDbType.VarChar;
            inputPar.Size = 50;
            objCommand.Parameters.Add(inputPar);

            DataSet ds = objDB.GetDataSetUsingCmdObj(objCommand);

            if (ds.Tables[0].Rows.Count != 0)
            {
                return true;
                
            }
            else
            {
                return false;
            }
        }

    }
}
