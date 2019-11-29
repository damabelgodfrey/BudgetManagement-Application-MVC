using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace BudgetManagement.Repository
{
    class AzureDbConnection
    {
        
        private readonly string dbConnMessage;
        public static string Key; 
        protected static string dbReturnMessage;
        protected static string dbQuery;
        public SqlConnection sqlConnection;

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
        public bool ValidateAction(string message, string caption)
        {
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                return true;
            }
            else { return false; }
        }
    }
}
