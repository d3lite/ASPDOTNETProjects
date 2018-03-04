using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Utilities;


namespace RestaurantReview
{
   public class Category
    {
        private DBConnect objDB;
        private SqlCommand objCommand;

        public Category(DBConnect db, SqlCommand command)
        {
            objDB = db;
            objCommand = command;
        }

        public SqlCommand GetCategory()
        {
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetCategory";

            objDB.GetDataSetUsingCmdObj(objCommand);

            return objCommand;


        }

        

    }
}
