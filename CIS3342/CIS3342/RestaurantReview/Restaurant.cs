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
   public class Restaurant
    {
        private DBConnect objDB;
        private SqlCommand objCommand;

        public Restaurant(DBConnect db, SqlCommand command)
        {
            objDB = db;
            objCommand = command;
        }

        public void InsertRestaurant(string restname, string catname, string city, string state, string username)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "AddRestaurant";

            SqlParameter inputpar = new SqlParameter("@restname", restname);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);

            inputpar = new SqlParameter("@catname", catname);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);

            inputpar = new SqlParameter("@city", city);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);

            inputpar = new SqlParameter("@reststate", state);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 5;
            objCommand.Parameters.Add(inputpar);

            inputpar = new SqlParameter("@username", username);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);

            objDB.DoUpdateUsingCmdObj(objCommand);




        }

        public SqlCommand SearchRestaurant(string catname)
        {
            objCommand.Parameters.Clear();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "SearchRestaurant";
            SqlParameter inputpar = new SqlParameter("@catname", catname);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);

            return objCommand;
        }

        public SqlCommand GetRestaurantByUser(string username)
        {
            objCommand.Parameters.Clear();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetRestByUser";
            SqlParameter inputpar = new SqlParameter("@username", username);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);

            return objCommand;
        }

        public void DeleteRestByID(int id)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "DeleteRestByID";

            SqlParameter inputpar = new SqlParameter("@restid", id);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 3;
            objCommand.Parameters.Add(inputpar);

            objDB.DoUpdateUsingCmdObj(objCommand);

        }

        public SqlCommand SearchRestaurantByName(string restname)
        {
            objCommand.Parameters.Clear();

            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "SearchRestaurantByName";
            SqlParameter inputpar = new SqlParameter("@restname", restname);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);

            return objCommand;
        }

        public SqlCommand GetRestaurant()
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetRestaurant";

            objDB.DoUpdateUsingCmdObj(objCommand);

            return objCommand;
        }

        public void UpdateRestaurant(int restid,string restname, string category, string city, string state)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "UpdateRestaurant";

            SqlParameter inputpar = new SqlParameter("@restid", restid);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.Int;
            inputpar.Size = 3;
            objCommand.Parameters.Add(inputpar);
            inputpar = new SqlParameter("@restname", restname);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);

            inputpar = new SqlParameter("@category", category);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);
            inputpar = new SqlParameter("@restcity", city);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);

            inputpar = new SqlParameter("@reststate", state);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);

            objDB.DoUpdateUsingCmdObj(objCommand);
        }
    }
}
