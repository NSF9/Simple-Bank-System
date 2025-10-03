using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstBankProject
{
    public static class clsLogRegisterDA
    {
        public static bool SaveLogRegister
            
           (int UserID,
           int LogTypeID)
           
        {
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string Query = @"INSERT INTO LogRegister
           (UserID
           ,LogTypeID
           ,LogTime)
              VALUES
           (@UserID,
           @LogTypeID
           ,@LogTime)";



            SqlCommand Command = new SqlCommand(Query, Connection);

           
            Command.Parameters.AddWithValue("UserID", UserID);
            Command.Parameters.AddWithValue("LogTypeID", LogTypeID);
            Command.Parameters.AddWithValue("LogTime", DateTime.Now);
            
        



            int RowsAffected = 0;

            try
            {

                Connection.Open();

                RowsAffected = Command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return false;

            }
            finally
            {
                Connection.Close();
            }

            return (RowsAffected > 0);
        }



    }

}
