using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetManagement.Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using BudgetManagement.Utilities;

namespace BudgetManagement.Repository
{
    class UserRepositoryController: AzureDbConnection
    {
        
            //Add User 
        public string AddUser(User user)
            {
            if (CheckUser(user))
            {
                dbReturnMessage = "Error: Email already exist with another user ";

            }else { 
                dbReturnMessage = "";
                dbQuery = "INSERT INTO Users([Name],[Email],[Password]) VALUES(@Name, @Email, @Password);";
                try
                {
                sqlCommand = new SqlCommand(dbQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Name", user.uName);
                sqlCommand.Parameters.AddWithValue("@Email", user.uEmail);
                Key = "b14ca5898a4e4133bbce2ea2315a1916";
                    String EncriptPassword = DataCypher.EncryptString(Key, user.uPassword); //encript password
                sqlCommand.Parameters.AddWithValue("@Password", EncriptPassword);          
                    sqlConnection.Open();
                    int i = sqlCommand.ExecuteNonQuery();
                    if (i > 0)
                        dbReturnMessage = user.uName + "  Added Successfully!!";

                    else
                        throw new Exception("Error, Data Could Not Be Added!");
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    dbReturnMessage = "Exception: " + ex.Message;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
                return dbReturnMessage;
        }

        //Check if user exist
        public bool CheckUser(User user)
        {

            dbQuery = "SELECT count(*)  FROM Users WHERE [Email] = @Email";
            sqlCommand = new SqlCommand(dbQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Email", user.uEmail);
            try
            {
                sqlConnection.Open();
                int i = sqlCommand.ExecuteNonQuery();
                int recordCount = (int)sqlCommand.ExecuteScalar();

                if (recordCount > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                dbReturnMessage = "Exception: " + ex.Message;
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
           
        }
        
    }
}
