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
    class TransactionRepository : AzureDbConnection
    {
        public static List<Transaction> TransactionList = new List<Transaction>();
        public static List<RecurringTransaction> RecurringTransList = new List<RecurringTransaction>();

        //add contact
        public SqlCommand sqlCommand;
        public string AddTransaction(Transaction transaction)
        {
            var a = transaction.GetType();
            if (transaction is RecurringTransaction)
            {
                MessageBox.Show(a.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            if (transaction.GetType().IsAssignableFrom(typeof(Transaction)))
            {
               // MessageBox.Show("Transaction", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               // MessageBox.Show("RecurringTransaction","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            dbReturnMessage = "";
          
               // dbQuery = "INSERT INTO RECURRINGTRANSACTIONS([UserId],[Name],[Type],[Amount],[Note],[ContactName],[StartDate],[Period]) VALUES(@UserId,@Name, @type,@Amount,@Note,@ContactName,@StartDate,@Period);";
                dbQuery = "INSERT INTO TRANSACTIONS([UserId],[Name],[Type],[Amount],[Note],[ContactName],[StartDate]) VALUES(@UserId,@Name, @Type,@Amount,@Note,@ContactName,@StartDate);";

            //dbQuery = "INSERT INTO Contacts([UserId],[Name],[Address],[Type]) VALUES(@UserId,@Name, @address, @type);";

            sqlCommand = new SqlCommand(dbQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@UserId", transaction.transID);
                sqlCommand.Parameters.AddWithValue("@Name", transaction.transName);
                sqlCommand.Parameters.AddWithValue("@Type", transaction.transType);
                sqlCommand.Parameters.AddWithValue("@Amount", transaction.transAmount);
                sqlCommand.Parameters.AddWithValue("@Note", transaction.transNote);
                sqlCommand.Parameters.AddWithValue("@ContactName", transaction.transContact);
                sqlCommand.Parameters.AddWithValue("@StartDate", transaction.TransDate);
             MessageBox.Show(transaction.transID+transaction.transName+ transaction.transType+ transaction.transAmount+ transaction.transNote+ transaction.transContact+ transaction.TransDate+"RecurringTransaction","ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            // if (frequency == "Recurrent")
            // {
            // sqlCommand.Parameters.AddWithValue("@EndDate", transaction.TransDate);
            // sqlCommand.Parameters.AddWithValue("@period", transaction.TransDate);
            // }

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
            return dbReturnMessage;
        }
        //list transaction
        public List<Transaction> GetTransaction(int userId)
        {
            TransactionList.Clear(); //fetch updated contact list from database into contactlist;
            dbQuery = "SELECT * FROM TRANSACTIONS  WHERE [UserId] = @UserId ;";
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
                        ReadTransRow((IDataRecord)reader);
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
           
                return TransactionList;

            
        }

        // Delete Transaction
        public string DeleteTransaction(Transaction transaction)
        {
            dbReturnMessage = "";
            if (ValidateAction("Are You show you want to delete transaction", "DELETE OPEREATION"))
            {
                    dbQuery = "DELETE FROM Transactions WHERE [Id] = @Id";
                
                sqlCommand = new SqlCommand(dbQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Id", transaction.transID);
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
                        dbReturnMessage = "Error: " + transaction.transName + " Data Could Not Be Deleted!";
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
        //update transaction
        public string UpdateTransaction(Transaction transaction)
        {

            if (transaction.GetType().IsAssignableFrom(typeof(Transaction)))
            {

                dbQuery = "UPDATE TRANSACTIONS SET [Name] = @Name, [Type]=@Type,[Amount] = @Amount, [Note]=@Note," +
                  "[ContactName]=@ContactName,[StartDate]=@StartDate WHERE [Id] = @Id ;";

            }
            else
            {
               dbQuery = "UPDATE RECURRENTTRANSACTIONS SET [Name] = @Name, [Type]=@Type,[Amount] = @Amount, [Note]=@Note," +
            "[ContactName]=@ContactName,[StartDate]=@StartDate,[EndDate]=@EndDate,[period]=@period WHERE [Id] = @Id ;";
            }
            

            sqlCommand = new SqlCommand(dbQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Id", transaction.transID);
            sqlCommand.Parameters.AddWithValue("@Name", transaction.transName);
            sqlCommand.Parameters.AddWithValue("@Type", transaction.transType);
            sqlCommand.Parameters.AddWithValue("@Amount", transaction.transAmount);
            sqlCommand.Parameters.AddWithValue("@Note", transaction.transNote);
            sqlCommand.Parameters.AddWithValue("@ContactName", transaction.transContact);
            sqlCommand.Parameters.AddWithValue("@StartDate", transaction.TransDate);
            if (transaction.GetType().IsAssignableFrom(typeof(RecurringTransaction)))
            {
                sqlCommand.Parameters.AddWithValue("@EndDate", transaction.TransDate);
                sqlCommand.Parameters.AddWithValue("@period", transaction.TransDate);
            }
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
                    dbReturnMessage = "Error: " + transaction.transName + " I had difficulty to be certain the update was successful!";
                    sqlConnection.Close();
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
            return dbReturnMessage;
        }
        //check if transaction name exist
        public bool CheckTransaction(Transaction transaction)
        {

            dbQuery = "SELECT count(*)  FROM Transaction WHERE [Name] = @Name";
            sqlCommand = new SqlCommand(dbQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Name", transaction.transName);
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

        //get Recurring transaction
        public List<RecurringTransaction> GetRecurringTransaction(int userId)
        {
            RecurringTransList.Clear(); //fetch updated contact list from database into contactlist;
            dbQuery = "SELECT * FROM RECURRINGTRANSACTIONS  WHERE [UserId] = @UserId ;";
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
                        ReadRecurringTransRow((IDataRecord)reader);
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

            return RecurringTransList;


        }

        // Delete Transaction
        public string DeleteRecurringTransaction(RecurringTransaction transaction)
        {
            dbReturnMessage = "";
            if (ValidateAction("Are You show you want to delete this recuring transaction", "DELETE OPEREATION"))
            {
                dbQuery = "DELETE FROM RecuringTransactions WHERE [Id] = @Id";

                sqlCommand = new SqlCommand(dbQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Id", transaction.transID);
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
                        dbReturnMessage = "Error: " + transaction.transName + " Data Could Not Be Deleted!";
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
        //Iterate through transaction
        //add to transaction list
        private static void ReadTransRow(IDataRecord record)
        {
            int id = Convert.ToInt32(record[0]);
            int UserId = Convert.ToInt32(record[1]);
            string Name = Convert.ToString(record[2]);
            string Type = Convert.ToString(record[3].ToString());
            double Amount = Convert.ToDouble(record[4]);
            string Note = Convert.ToString(record[5]);
            string CountactName = Convert.ToString(record[6]);
            string TransDate = Convert.ToString(record[7]);
          
                Transaction obj = new Transaction(id, UserId, Name, Note, TransDate, Amount, Type, CountactName);
                TransactionList.Add(obj); //add contact to contact list
           
        }

        //read returning transaction row
        private static void ReadRecurringTransRow(IDataRecord record)
        {
            int id = Convert.ToInt32(record[0]);
            int UserId = Convert.ToInt32(record[1]);
            string Name = Convert.ToString(record[2]);
            string Type = Convert.ToString(record[3].ToString());
            double Amount = Convert.ToDouble(record[4]);
            string Note = Convert.ToString(record[5]);
            string CountactName = Convert.ToString(record[6]);
            string TransDate = Convert.ToString(record[7]);
            string Transfrequency = Convert.ToString(record[8]);
            string endDate = Convert.ToString(record[9]);
            RecurringTransaction obj = new RecurringTransaction(id, UserId, Name, Note, TransDate, Amount, Type, CountactName, Transfrequency, endDate);
            RecurringTransList.Add(obj); //add contact to contact list
        }

    }
}
