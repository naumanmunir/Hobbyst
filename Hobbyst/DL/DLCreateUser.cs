using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hobbyst.BL;
using System.Data;
using System.Data.SqlClient;

namespace Hobbyst.DL
{
    class AddUser
    {
        //declare connection string
        DLConnections nConnection;

        //Constructor
        public AddUser()
        {

            nConnection = new DLConnections();
        }

        public void InsertUser(string UserName, string Password, string Email)
        {

            SqlCommand sqlInsertUser = new SqlCommand();

            sqlInsertUser.CommandText = "usp_newUser";                      //link stored procedure
            sqlInsertUser.CommandType = CommandType.StoredProcedure;        //tell its a stored procedure
            
            // connection
            sqlInsertUser.Connection = nConnection.GetConnection();
            ////send values
            sqlInsertUser.Parameters.AddWithValue("@username", UserName);
            sqlInsertUser.Parameters.AddWithValue("@password", Password);
            sqlInsertUser.Parameters.AddWithValue("@email", Email);
            
            //// execute the INSERT statement
            sqlInsertUser.Connection.Open();
            sqlInsertUser.ExecuteNonQuery();
            sqlInsertUser.Connection.Close();

        }

    }
}
