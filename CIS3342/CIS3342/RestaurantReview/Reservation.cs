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
    public class Reservation
    {
        private DBConnect objDB;
        private SqlCommand objCommand;

        public Reservation(DBConnect db, SqlCommand command)
        {
            objDB = db;
            objCommand = command;
        }

        public void InsertReservation( int restid, string time, string date, string name, string username)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "InsertReservation";

            SqlParameter inputpar = new SqlParameter("@restid", restid);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.Int;
            inputpar.Size = 3;
            objCommand.Parameters.Add(inputpar);

            inputpar = new SqlParameter("@time", time);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);


            inputpar = new SqlParameter("@date", date);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);


            inputpar = new SqlParameter("@name", name);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);

            inputpar = new SqlParameter("@username", username);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);

            objDB.DoUpdateUsingCmdObj(objCommand);

        }

        public SqlCommand GetReservationByUser(string username)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "GetReservationByUser";

            SqlParameter 
                inputpar = new SqlParameter("@username", username);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.VarChar;
            inputpar.Size = 50;
            objCommand.Parameters.Add(inputpar);

            objDB.DoUpdateUsingCmdObj(objCommand);
            return objCommand;

        }

        public void DeleteReservationByID(int id)
        {
            objCommand.Parameters.Clear();
            objCommand.CommandType = CommandType.StoredProcedure;
            objCommand.CommandText = "DeleteReservationByID";

            SqlParameter
                inputpar = new SqlParameter("@revid", id);
            inputpar.Direction = ParameterDirection.Input;
            inputpar.SqlDbType = SqlDbType.Int;
            inputpar.Size = 3;
            objCommand.Parameters.Add(inputpar);

            objDB.DoUpdateUsingCmdObj(objCommand);
            
        }

        }
}
