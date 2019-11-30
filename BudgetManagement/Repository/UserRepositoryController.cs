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
        public static List<User> UserList = new List<User>();
        public SqlCommand sqlCommand;

        internal static int GetUserID() {

           int id = UserList[0].uID;
            return id;

        }

        internal static string getKey()
        {
            Key = "b14ca5898a4e4133bbce2ea2315a1916";
            return Key;
        }

        //Add User 
        public string AddUser(User user)
            {
            dbReturnMessage = "";
            if (CheckUser(user))
            {
                dbReturnMessage = "false";
            }
            else
            {

                dbQuery = "INSERT INTO Users([Name],[Email],[Password]) VALUES(@Name, @Email, @Password);";
                try
                {
                    sqlCommand = new SqlCommand(dbQuery, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Name", user.uName);
                    sqlCommand.Parameters.AddWithValue("@Email", user.uEmail);
                    Key = getKey();
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
                    MessageBox.Show(dbReturnMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlConnection.Close();
                }
            }
                return dbReturnMessage;
        }

        public  string VerifyUser(string email, string Password)
        {
            if (UserList.Count()> 0)
            {
                UserRepositoryController.UserList.Clear();
            }
                
            dbQuery = "SELECT * FROM Users  WHERE [Email] = @Email;";
            sqlCommand = new SqlCommand(dbQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Email", email);
            try
            {
                using (sqlConnection)
                {


                    using (sqlConnection)
                    {
                        sqlConnection.Open();
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        // Call Read before accessing data.
                        while (reader.Read())
                        {
                            ReadUserRow((IDataRecord)reader);
                            break;
                        }
                        sqlConnection.Close();
                        reader.Close();

                    }
                }
            }
            catch (Exception ex)
            {
                dbReturnMessage = "Exception: " + ex.Message;
                MessageBox.Show(dbReturnMessage, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                sqlConnection.Close();
            }
            if (UserList.Count() > 0)
            {
                return "true";
            }
            else {
                return "false";
            }
            
        }

        //
        private  void ReadUserRow(IDataRecord record)
        {
            int id = Convert.ToInt32(record[0]);
            string Name = Convert.ToString(record[1]);
            string Email = Convert.ToString(record[2]);
            string Password = Convert.ToString(record[3]);
            User obj = new User(id, Name, Email, Password);
            UserList.Add(obj);
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
