using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Hobbyst.DL
{
    class GetData
    {
        DLConnections HobbystConnection;

        public GetData()
        {
            HobbystConnection = new DLConnections();
        }


        //assign values and parameters to command object
        private SqlCommand GetCmdspValidateUser(string username, string pwd)
        {
            SqlCommand CmdspValidateUser = new SqlCommand();
            CmdspValidateUser.CommandText = "usp_userLogin";
            CmdspValidateUser.CommandType = CommandType.StoredProcedure;
            CmdspValidateUser.Connection = HobbystConnection.GetConnection();
            CmdspValidateUser.Parameters.AddWithValue("@Username", username);
            CmdspValidateUser.Parameters.AddWithValue("@Password", pwd);

            return CmdspValidateUser;
        }

        public void GetUserData(string username, string pwd)
        {
           string returnValue = string.Empty;
            //Get the command, open connection and execute the cmd query.
            //Return First name if successful
            using (SqlCommand objCommand = GetCmdspValidateUser(username, pwd))
            {
                objCommand.Connection.Open();
                objCommand.ExecuteNonQuery();
                //returnValue = (string)objCommand.Parameters["@firstName"].Value;               
            }
            //return returnValue;          
        }
    }
}
