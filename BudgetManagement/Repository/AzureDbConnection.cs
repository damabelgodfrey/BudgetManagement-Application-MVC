using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace BudgetManagement.Repository
{
    class AzureDbConnection
    {
        
        private readonly string dbConnMessage;
        protected  string Key; 
        protected string dbReturnMessage;
        protected string dbQuery;
        protected SqlConnection sqlConnection;
        protected SqlCommand sqlCommand;

        public AzureDbConnection()
        {
            try
            {
                string dbconn = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
                //The query to use
               
                 sqlConnection = new SqlConnection(dbconn);
                //sqlConnection.Open();

            }
            catch (Exception ex)
            {
                dbConnMessage = "Exception:" + ex.Message;
                
            }


        }
    }
}
