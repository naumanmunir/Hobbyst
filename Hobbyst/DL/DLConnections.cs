using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Hobbyst.DL
{
    class DLConnections
    {
        //initialize connection String
        string conString = string.Empty;
        SqlConnection SQLconnection;
        
        //Constructor
        public DLConnections()
        {
            //Fetching the connection string from App.config file
            conString = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString; 
            
        }

        //Open database connection 
        public SqlConnection GetConnection()
        {
            if (SQLconnection == null)
            {
                SQLconnection = new SqlConnection();
                SQLconnection.ConnectionString = conString;
            }
            return SQLconnection;
        }
    }
}
