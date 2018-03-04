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
   public class Reviews
    {
        private DBConnect objDB;
        private SqlCommand objCommand;

        public Reviews(DBConnect db, SqlCommand command)
        {
            objDB = db;
            objCommand = command;
        }

        public void InsertReview(int restid, int rating, int pricerange, string username, string review)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "InsertReview";

            SqlParameter inputpar = new SqlParameter("@restid", restid);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.Int;
            inputpar.Size = 3;
            objCommand.Parameters.Add(inputpar);

             inputpar = new SqlParameter("@rating", rating);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.Int;
            inputpar.Size = 3;
            objCommand.Parameters.Add(inputpar);

            inputpar = new SqlParameter("@pricerange", pricerange);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.Int;
            inputpar.Size = 3;
            objCommand.Parameters.Add(inputpar);

            inputpar = new SqlParameter("@username", username);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);

            inputpar = new SqlParameter("@reviews", review);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 100;
            objCommand.Parameters.Add(inputpar);

            objDB.DoUpdateUsingCmdObj(objCommand);



        }

        public SqlCommand GetReviewsByRestID(int restid)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetReviewsByRestID";

            SqlParameter inputpar = new SqlParameter("@restid", restid);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.Int;
            inputpar.Size = 3;
            objCommand.Parameters.Add(inputpar);

            objDB.DoUpdateUsingCmdObj(objCommand);

            return objCommand;

        }

        public SqlCommand GetReviewsByUser(string username)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetReviewsByUser";

            SqlParameter inputpar = new SqlParameter("@username", username);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);

            objDB.DoUpdateUsingCmdObj(objCommand);

            return objCommand;
        }

        public void DeleteReviewersByID(int revid)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "DeleteReviewsByID";

            SqlParameter inputpar = new SqlParameter("@reviewid", revid);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 3;
            objCommand.Parameters.Add(inputpar);

            objDB.DoUpdateUsingCmdObj(objCommand);
        }

        public void UpdateReviewsByID(int revid, int rating, int pricerange, string reviews)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "UpdateReviews";

            SqlParameter inputpar = new SqlParameter("@reviewid", revid);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.Int;
            inputpar.Size = 3;
            objCommand.Parameters.Add(inputpar);

            inputpar = new SqlParameter("@rating", rating);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.Int;
            inputpar.Size = 3;
            objCommand.Parameters.Add(inputpar);
            inputpar = new SqlParameter("@pricerange", pricerange);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.Int;
            inputpar.Size = 3;
            objCommand.Parameters.Add(inputpar);

            inputpar = new SqlParameter("@reviews", reviews);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);

            objDB.DoUpdateUsingCmdObj(objCommand);
        }
    }
}
