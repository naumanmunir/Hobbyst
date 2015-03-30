using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Hobbyst.BL;

namespace Hobbyst.DL
{
    class UserProfile
    {
        DLConnections nConnection;

        public UserProfile()
        {
            nConnection = new DLConnections();
        }

        public void uploadProfilePic(Object profilepic)
        {
            SqlCommand cmduppic = new SqlCommand();

            cmduppic.CommandText = "usp_uploadpic";
            cmduppic.CommandType = CommandType.StoredProcedure;

            cmduppic.Connection = nConnection.GetConnection();

            cmduppic.Parameters.AddWithValue("@profilepic", profilepic);

            cmduppic.Connection.Open();
            cmduppic.ExecuteNonQuery();
            cmduppic.Connection.Close();

        }

        public void NewUserProfile(string Fname, string Lname, DateTime DoB, string PrimaryNum, string Street, string City, string State, string Zip)
        {

            SqlCommand sqlInsertUserProfile = new SqlCommand();

            sqlInsertUserProfile.CommandText = "usp_userProfile";                  //link stored procedure
            sqlInsertUserProfile.CommandType = CommandType.StoredProcedure;        //tell its a stored procedure
            // connection
            sqlInsertUserProfile.Connection = nConnection.GetConnection();
            //send values
            sqlInsertUserProfile.Parameters.AddWithValue("@FirstName", Fname);
            sqlInsertUserProfile.Parameters.AddWithValue("@LastName", Lname);
            sqlInsertUserProfile.Parameters.AddWithValue("@DateofBirth", DoB);
            sqlInsertUserProfile.Parameters.AddWithValue("@primarynum", PrimaryNum);
            sqlInsertUserProfile.Parameters.AddWithValue("@Street", Street);
            sqlInsertUserProfile.Parameters.AddWithValue("@city", City);
            sqlInsertUserProfile.Parameters.AddWithValue("@State", State);
            sqlInsertUserProfile.Parameters.AddWithValue("@zip", Zip);

            // execute the INSERT statement
            sqlInsertUserProfile.Connection.Open();
            sqlInsertUserProfile.ExecuteNonQuery();
            sqlInsertUserProfile.Connection.Close();

        }

        public DataSet populateStates()
        {
            DataSet myDataSet = new DataSet();
            SqlCommand cmdps = new SqlCommand();
            cmdps.CommandText = "usp_grabstates";
            cmdps.CommandType = CommandType.StoredProcedure;
            cmdps.Connection = nConnection.GetConnection();

            SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(cmdps);
            mySqlDataAdapter.Fill(myDataSet);
            return myDataSet;
        }

    }


}
