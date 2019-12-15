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
        private static List<Transaction> TransactionList = new List<Transaction>();
        private static List<RecurringTransaction> RecurringTransactionList = new List<RecurringTransaction>();
        public static List<Transaction> ReportTransactionList = new List<Transaction>();

        
        //add contact
        public SqlCommand sqlCommand;
        public string AddTransaction(Transaction transaction)
        {
            dbReturnMessage = "";
            if (transaction is RecurringTransaction)
            {
                dbQuery = "INSERT INTO RECURRINGTRANSACTIONS([UserId],[Name],[Type],[Amount],[Note],[ContactName],[Frequency],[StartDate],[EndDate]) VALUES(@UserId,@Name, @Type,@Amount,@Note,@ContactName,@Frequency,@StartDate,@EndDate);";
            }
            else
            {
                dbQuery = "INSERT INTO TRANSACTIONS([UserId],[Name],[Type],[Amount],[Note],[ContactName],[StartDate]) VALUES(@UserId,@Name, @Type,@Amount,@Note,@ContactName,@StartDate);";
            }
            if (transaction.GetType().IsAssignableFrom(typeof(Transaction)))
            {
                // dbQuery = "INSERT INTO TRANSACTIONS([UserId],[Name],[Type],[Amount],[Note],[ContactName],[StartDate]) VALUES(@UserId,@Name, @Type,@Amount,@Note,@ContactName,@StartDate);";
            }
            if (transaction.GetType().IsAssignableFrom(typeof(RecurringTransaction)))
            {
                // dbQuery = "INSERT INTO RECURRINGTRANSACTIONS([UserId],[Name],[Type],[Amount],[Note],[ContactName],[StartDate],[Period]) VALUES(@UserId,@Name, @type,@Amount,@Note,@ContactName,@StartDate,@Period);";

            }
            // dbQuery = "INSERT INTO RECURRINGTRANSACTIONS([UserId],[Name],[Type],[Amount],[Note],[ContactName],[StartDate],[Period]) VALUES(@UserId,@Name, @type,@Amount,@Note,@ContactName,@StartDate,@Period);";

            //dbQuery = "INSERT INTO Contacts([UserId],[Name],[Address],[Type]) VALUES(@UserId,@Name, @address, @type);";

            sqlCommand = new SqlCommand(dbQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@UserId", transaction.transID);
            sqlCommand.Parameters.AddWithValue("@Name", transaction.transName);
            sqlCommand.Parameters.AddWithValue("@Type", transaction.transType);
            sqlCommand.Parameters.AddWithValue("@Amount", transaction.transAmount);
            sqlCommand.Parameters.AddWithValue("@Note", transaction.transNote);
            sqlCommand.Parameters.AddWithValue("@ContactName", transaction.transContact);
            sqlCommand.Parameters.AddWithValue("@StartDate", Convert.ToDateTime(transaction.TransDate));
            if (transaction is RecurringTransaction rTransaction)
            {
                sqlCommand.Parameters.AddWithValue("@Frequency", rTransaction.transFreQuency);
                sqlCommand.Parameters.AddWithValue("@EndDate", Convert.ToDateTime(rTransaction.transEndDate));
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
                    MessageBox.Show(i + "  Could not verify", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                dbReturnMessage = "Exception: " + ex.Message;
                MessageBox.Show(dbReturnMessage + "Could not open", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                sqlConnection.Close();
            }
            return dbReturnMessage;
        }

        internal List<Transaction> GetTransactionReport(int userId, string transName, string contact)
        {
            ReportTransactionList.Clear();
            dbQuery = "SELECT * FROM TRANSACTIONS  WHERE ";
           if(transName != "All")
            {
                dbQuery += " [Name] =@Name AND";
            }
            if(contact != "All")
            {
                dbQuery += " [ContactName] =@ContactName AND";
            }
            dbQuery += "[UserId] = @UserId";

            sqlCommand = new SqlCommand(dbQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@UserId", userId);
            if (transName != "All")
            {
                sqlCommand.Parameters.AddWithValue("@Name", transName);

            }
            if (contact != "All")
            {
                sqlCommand.Parameters.AddWithValue("@ContactName", contact);

            }
            MessageBox.Show(dbQuery);
            try
                {
                using (sqlConnection)
                {
                    sqlConnection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    // Call Read before accessing data.
                    while (reader.Read())
                    {
                        ReadTransRow((IDataRecord)reader,"Report");
                    }
                    sqlConnection.Close();
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                dbReturnMessage = "Exception: " + ex.Message;
                MessageBox.Show(dbReturnMessage);
            }
            finally
            {
                sqlConnection.Close();
            }

            return ReportTransactionList;
        }




        //list transaction
        public List<Transaction> GetSavedTransaction(int userId)
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
                        ReadTransRow((IDataRecord)reader,"Transaction");
                    }
                    sqlConnection.Close();
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                dbReturnMessage = "Exception: " + ex.Message;
                MessageBox.Show(dbReturnMessage);

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
                if (transaction is RecurringTransaction)
                {
                    dbQuery = "DELETE FROM RecurringTransactions WHERE [Id] = @Id";
                }
                else
                {
                    dbQuery = "DELETE FROM Transactions WHERE [Id] = @Id";
                }
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
                    MessageBox.Show(dbReturnMessage);

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
            if (transaction is RecurringTransaction)
            {
                dbQuery = "UPDATE RECURRINGTRANSACTIONS SET [Name] = @Name, [Type]=@Type,[Amount] = @Amount, [Note]=@Note," +
                    "[ContactName]=@ContactName,[Frequency]=@Frequency,[StartDate]=@StartDate,[EndDate]=@EndDate WHERE [Id] = @Id ;";
            }
            else
            {
                dbQuery = "UPDATE TRANSACTIONS SET [Name] = @Name, [Type]=@Type,[Amount] = @Amount, [Note]=@Note," +
             "[ContactName]=@ContactName,[StartDate]=@StartDate WHERE [Id] = @Id ;";
            }
            sqlCommand = new SqlCommand(dbQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Id", transaction.transID);
            sqlCommand.Parameters.AddWithValue("@Name", transaction.transName);
            sqlCommand.Parameters.AddWithValue("@Type", transaction.transType);
            sqlCommand.Parameters.AddWithValue("@Amount", transaction.transAmount);
            sqlCommand.Parameters.AddWithValue("@Note", transaction.transNote);
            sqlCommand.Parameters.AddWithValue("@ContactName", transaction.transContact);
            sqlCommand.Parameters.AddWithValue("@StartDate", Convert.ToDateTime(transaction.TransDate));
            if (transaction is RecurringTransaction rtransaction)
            {
                sqlCommand.Parameters.AddWithValue("@Frequency", rtransaction.transFreQuency);
                sqlCommand.Parameters.AddWithValue("@EndDate", Convert.ToDateTime(rtransaction.transEndDate));
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
                MessageBox.Show(dbReturnMessage);

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
        public List<RecurringTransaction> GetSavedRecurringTransaction(int userId)
        {
            RecurringTransactionList.Clear(); //fetch updated contact list from database into contactlist;
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
                        ReadTransRow((IDataRecord)reader,"RecurringTransaction");

                    }
                    sqlConnection.Close();
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                dbReturnMessage = "Exception: " + ex.Message;
                MessageBox.Show(dbReturnMessage);
            }
            finally
            {
                sqlConnection.Close();
            }

            return RecurringTransactionList;
        }

        //Iterate through transaction
        //add to transaction list
        private static void ReadTransRow(IDataRecord record, string sender)
        {
            int id = Convert.ToInt32(record[0]);
            int UserId = Convert.ToInt32(record[1]);
            string Name = Convert.ToString(record[2]);
            string Type = Convert.ToString(record[3].ToString());
            double Amount = Convert.ToDouble(record[4]);
            string Note = Convert.ToString(record[5]);
            string CountactName = Convert.ToString(record[6]);
            DateTime TransDate = Convert.ToDateTime(record[7]);
            if (sender == "Report")
            {
                Transaction trans = new Transaction(id, UserId, Name, Note, TransDate, Amount, Type, CountactName);

                ReportTransactionList.Add(trans);
            }
            if(sender =="Transaction")
            {
            Transaction trans= new Transaction(id, UserId, Name, Note, TransDate, Amount, Type, CountactName);
                TransactionList.Add(trans); //add contact to contact list

            }
            if(sender == "RecurringTransaction")
            {
                string Transfrequency = Convert.ToString(record[8]);

                DateTime EndDate = Convert.ToDateTime(record[9]);
                RecurringTransaction obj = new RecurringTransaction(id, UserId, Name, Note, TransDate, Amount, Type, CountactName, Transfrequency, EndDate);

                RecurringTransactionList.Add(obj); //add contact to contact list
            }
        }



        //access list of transation
        public static List<Transaction> RequestTransactionList()
        {
            return TransactionList;
        }
        public static List<RecurringTransaction> RequestRecurringTransactionList()
        {

            return RecurringTransactionList;
        }
    }
}
