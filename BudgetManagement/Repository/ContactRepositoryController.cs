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

namespace BudgetManagement.Repository
{
    class ContactRepositoryController : AzureDbConnection
    {
        public static List<Contact> ContactList = new List<Contact>();

        //add contact

        public SqlCommand sqlCommand;
        public string AddContact(Contact contact)
        {
            if (CheckUser(contact))
            {
                dbReturnMessage = "Error: " + contact.cName+  " already exist on contact list";

            }
            else
            {
                dbReturnMessage = "";
                dbQuery = "INSERT INTO Contacts([UserId],[Name],[Address],[Type]) VALUES(@UserId,@Name, @address, @type);";
                sqlCommand = new SqlCommand(dbQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@UserId", contact.cUserId);
                sqlCommand.Parameters.AddWithValue("@Name", contact.cName);
                sqlCommand.Parameters.AddWithValue("@Address", contact.cAddress);
                sqlCommand.Parameters.AddWithValue("@Type", contact.cType);
                try
                {
                    sqlConnection.Open();
                    int i = sqlCommand.ExecuteNonQuery();
                    if (i > 0)
                    {
                        dbReturnMessage = "success";
                    }
                    else
                    {
                        MessageBox.Show(i + "  Could not verify", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        sqlConnection.Close();
                    }
                }
                catch (Exception ex)
                { 
                    dbReturnMessage = "Exception: " + ex.Message;
                    MessageBox.Show("Could not open", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally
                {
                    sqlConnection.Close();
                }
            }
            return dbReturnMessage;
        }

        // Delete Contact
        public string DeleteContact(Contact contact)
        {
            dbReturnMessage = "";
            if (ValidateAction("Are You show you want to delete Contact", "DELETE OPEREATION"))
            {
                dbQuery = "DELETE FROM Contacts WHERE [Id] = @Id";
                sqlCommand = new SqlCommand(dbQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Id", contact.cID);
                try
                {
                    sqlConnection.Open();
                    int i = sqlCommand.ExecuteNonQuery();
                    if (i > 0)
                    {
                        dbReturnMessage = "success";

                    }
                    else
                    {
                        dbReturnMessage = "Error: " + contact.cName + " Data Could Not Be Deleted!";
                    }
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

        public string UpdateContact(Contact contact)
        {

            dbQuery = "UPDATE CONTACTS SET [Name] = @Name, [Address] = @Address, [Type]=@Type WHERE [Id] = @Id ;";
            sqlCommand = new SqlCommand(dbQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Id", contact.cID);
            sqlCommand.Parameters.AddWithValue("@Name", contact.cName);
            sqlCommand.Parameters.AddWithValue("@Address", contact.cAddress);
            sqlCommand.Parameters.AddWithValue("@Type", contact.cType);
            try
            {
                sqlConnection.Open();
                int i = sqlCommand.ExecuteNonQuery();
                if (i > 0)
                    dbReturnMessage = contact.cName + "  Updated Successfully!!";

                else
                    throw new Exception("Error: " + contact.cName + " Data Could Not Be Found!");
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
            return dbReturnMessage;
        }

        // select contact
        public  List<Contact> GetContact(int userId)
        {
            ContactList.Clear(); //fetch updated contact list from database into contactlist;

            dbQuery = "SELECT * FROM CONTACTS  WHERE [UserId] = @UserId ;";
            sqlCommand = new SqlCommand(dbQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@UserId", userId);
            try
            {
                using (sqlConnection)
                {
                    sqlConnection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    // Call Read before accessing data.
                    while (reader.Read())
                    {
                        ReadContactRow((IDataRecord)reader);
                    }
                    sqlConnection.Close();
                    reader.Close();

                }
            }
            catch (Exception ex)
            {
                dbReturnMessage = "Exception: " + ex.Message;

            }
            finally
            {
                sqlConnection.Close();
            }
            return ContactList;
        }

        private static void ReadContactRow(IDataRecord record)
        {
            int id = Convert.ToInt32(record[0]);
            int UserId = Convert.ToInt32(record[1]);
            string Name = Convert.ToString(record[2]);
            string Address = Convert.ToString(record[3]);
            string Type = Convert.ToString(record[4].ToString());
            Contact obj = new Contact(id, UserId, Name, Address, Type);
            ContactList.Add(obj); //add contact to contact list
        }
        //Check if user exist
        public bool CheckUser(Contact contact)
        {

            dbQuery = "SELECT count(*)  FROM Contacts WHERE [Name] = @Name";
            sqlCommand = new SqlCommand(dbQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Name", contact.cName);
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
            catch (Exception ex)
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
