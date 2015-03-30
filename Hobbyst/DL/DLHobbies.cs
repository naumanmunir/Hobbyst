using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hobbyst.DL
{
    class Hobbies
    {
        DLConnections nConnection;

        public Hobbies()
        {
            nConnection = new DLConnections();

        }

        //CREATE HOBBIES
        public void CreateHobbies(string Title, string Description, float Price)
        {
            SqlCommand cmdcreatehobbies = new SqlCommand();

            cmdcreatehobbies.CommandText = "usp_createhobby";
            cmdcreatehobbies.CommandType = CommandType.StoredProcedure;

            cmdcreatehobbies.Connection = nConnection.GetConnection();

            cmdcreatehobbies.Parameters.AddWithValue("@title", Title);
            cmdcreatehobbies.Parameters.AddWithValue("@description", Description);
            cmdcreatehobbies.Parameters.AddWithValue("@price", Price);

            cmdcreatehobbies.Connection.Open();
            cmdcreatehobbies.ExecuteNonQuery();
            cmdcreatehobbies.Connection.Close();
        }

        //SEARCH HOBBIES
        public DataSet SearchHobbies(string Title, Decimal Price, int Zip)
        {
            DataSet myDataSet = new DataSet();
            SqlCommand cmdsearchhobbies = new SqlCommand();

            cmdsearchhobbies.CommandText = "usp_search1";
            cmdsearchhobbies.CommandType = CommandType.StoredProcedure;

            cmdsearchhobbies.Connection = nConnection.GetConnection();

            cmdsearchhobbies.Parameters.AddWithValue("@title", Title);
            cmdsearchhobbies.Parameters.AddWithValue("@price", Price);
            cmdsearchhobbies.Parameters.AddWithValue("@zip", Zip);

            SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter(cmdsearchhobbies);
            mySqlDataAdapter.Fill(myDataSet);

            cmdsearchhobbies.Connection.Open();
            cmdsearchhobbies.ExecuteNonQuery();
            cmdsearchhobbies.Connection.Close();

            return myDataSet;

        }
    }
}
