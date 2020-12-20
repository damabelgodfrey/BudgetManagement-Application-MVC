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
using NLog;

namespace BudgetManagement.Repository
{
    class UserRepository: AzureDbConnection
    {
        private static User user;
        public SqlCommand sqlCommand;
        private Logger _logger = LogManager.GetCurrentClassLogger();


        internal static int GetUserID() {
          int id = user.uID;
          return id;
        }

        internal static DateTime GetUserLogDate()
        {

            DateTime access = user.uLastAccess;
            return access;

        }

        internal static User GetUser(){
            return user;
        }
        internal static void ClearUser()
        {
            user = null;
        }

        internal static string GetKey()
        {
            Key = "b14ca5898a4e4133bbce2ea2315a1916";
            return Key;
        }

        //Add User 
        public string AddUser(User myUser)
            {
            dbReturnMessage = "";
            if (CheckUser(myUser))
            {
                dbReturnMessage = "false";
            }
            else
            {

                dbQuery = "INSERT INTO Users([Name],[Email],[Password]) VALUES(@Name, @Email, @Password);";
                try
                {
                    sqlCommand = new SqlCommand(dbQuery, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@Name", myUser.uName);
                    sqlCommand.Parameters.AddWithValue("@Email", myUser.uEmail);
                    Key = GetKey();
                    String EncriptPassword = DataCypher.EncryptString(Key, myUser.uPassword); //encript password
                    sqlCommand.Parameters.AddWithValue("@Password", EncriptPassword);
                    sqlConnection.Open();
                    int i = sqlCommand.ExecuteNonQuery();
                    if (i > 0)
                        dbReturnMessage = myUser.uName + "  Added Successfully!!";

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

        public  User VerifyUser(string email, string Password)
        {
            if (user != null)
            {
                user = null;
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
                MessageBox.Show(dbReturnMessage.ToString());


            }
            finally
            {
                sqlConnection.Close();
            }
            return user;
            
        }


        //
        private  void ReadUserRow(IDataRecord record)
        {
            int id = Convert.ToInt32(record[0]);
            string Name = Convert.ToString(record[1]);
            string Email = Convert.ToString(record[2]);
            string Password = Convert.ToString(record[3]);
            DateTime LastAccess = Convert.ToDateTime(record[4]);
            user = new User(id, Name, Email, Password,LastAccess);
            //UserList.Add(obj);
        }

        //Check if user exist
        public bool CheckUser(User myUser)
        {

            dbQuery = "SELECT count(*)  FROM Users WHERE [Email] = @Email";
            sqlCommand = new SqlCommand(dbQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Email", myUser.uEmail);
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

        internal bool UpdateUser(User newUser, string flag)
        {
            if (flag == "Details")
            {
                dbQuery = "UPDATE Users SET [Name] = @Name WHERE [Id] = @Id ;";
                sqlCommand = new SqlCommand(dbQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Name", newUser.uName);

            }
            if (flag == "Password")
            {
                dbQuery = "UPDATE Users SET [Password] = @Password WHERE [Id] = @Id ;";
                sqlCommand = new SqlCommand(dbQuery, sqlConnection);
                Key = GetKey();
                String EncriptPassword = DataCypher.EncryptString(Key, newUser.uPassword); //encript password
                sqlCommand.Parameters.AddWithValue("@Password", EncriptPassword);
            }
            if (flag == "Log")
            {
                dbQuery = "UPDATE Users SET [LastAccess] = @LastAccess WHERE [Id] = @Id ;";
                sqlCommand = new SqlCommand(dbQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@LastAccess", DateTime.Now);
            }
                sqlCommand.Parameters.AddWithValue("@Id", newUser.uID);
            try
            {
                sqlConnection.Open();
                int i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    dbReturnMessage = "  Updated Successfully!!";

                }

                else
                {
                    dbReturnMessage = "Error:  Data Could Not Be Found!";
                    MessageBox.Show("Update User Access" + dbReturnMessage);

                }
                sqlConnection.Close();
                if (user != null)
                {
                    user=null;
                }
               user = newUser;
                return true;
            }
            catch (Exception ex)
            {
                _logger.Error(ex);
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
