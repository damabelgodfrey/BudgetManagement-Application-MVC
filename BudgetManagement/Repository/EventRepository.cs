using BudgetManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManagement.Repository
{
    class EventRepository :  AzureDbConnection
    {
        private static List<Event> EventList = new List<Event>();
        private static List<RecurringEvent> RecurringEventList = new List<RecurringEvent>();
        //add contact
        public SqlCommand sqlCommand;
        public string AddEvent(Event Event)
        {
            
            dbReturnMessage = "";
            if (Event is RecurringEvent)
            {
                dbQuery = "INSERT INTO RecurringEvents([UserId],[Name],[Type],[Note],[ContactName],[Frequency],[StartDate],[EndDate]) VALUES(@UserId,@Name, @Type,@Note,@ContactName,@Frequency,@StartDate,@EndDate);";
            }
            else
            {
                dbQuery = "INSERT INTO Events([UserId],[Name],[Type],[Note],[ContactName],[StartDate]) VALUES(@UserId,@Name, @Type,@Note,@ContactName,@StartDate);";
            }

            if (Event.GetType().IsAssignableFrom(typeof(Event)))
            {
                // dbQuery = "INSERT INTO EventS([UserId],[Name],[Type],[Amount],[Note],[ContactName],[StartDate]) VALUES(@UserId,@Name, @Type,@Amount,@Note,@ContactName,@StartDate);";
            }
            if (Event.GetType().IsAssignableFrom(typeof(RecurringEvent)))
            {
                // dbQuery = "INSERT INTO RecurringEventS([UserId],[Name],[Type],[Amount],[Note],[ContactName],[StartDate],[Period]) VALUES(@UserId,@Name, @type,@Amount,@Note,@ContactName,@StartDate,@Period);";

            }
            // dbQuery = "INSERT INTO RecurringEventS([UserId],[Name],[Type],[Amount],[Note],[ContactName],[StartDate],[Period]) VALUES(@UserId,@Name, @type,@Amount,@Note,@ContactName,@StartDate,@Period);";

            //dbQuery = "INSERT INTO Contacts([UserId],[Name],[Address],[Type]) VALUES(@UserId,@Name, @address, @type);";

            sqlCommand = new SqlCommand(dbQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@UserId", Event.EventID);
            sqlCommand.Parameters.AddWithValue("@Name", Event.EventName);
            sqlCommand.Parameters.AddWithValue("@Type", Event.EventType);
            sqlCommand.Parameters.AddWithValue("@Note", Event.EventNote);
            sqlCommand.Parameters.AddWithValue("@ContactName", Event.EventContact);
            sqlCommand.Parameters.AddWithValue("@StartDate", Event.EventDate);
            if (Event is RecurringEvent rEvent)
            {
                sqlCommand.Parameters.AddWithValue("@Frequency", rEvent.EventFreQuency);
                sqlCommand.Parameters.AddWithValue("@EndDate", rEvent.EventEndDate);
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
        //list Event
        public List<Event> GetSavedEvent(int userId)
        {
            EventList.Clear(); //fetch updated contact list from database into contactlist;
            dbQuery = "SELECT * FROM Events  WHERE [UserId] = @UserId ;";
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
                        ReadEventRow((IDataRecord)reader,"Event");
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

            return EventList;
        }

        // Delete Event
        public string DeleteEvent(Event Event)
        {
            dbReturnMessage = "";
            if (ValidateAction("Are You show you want to delete Event", "DELETE OPEREATION"))
            {
                if (Event is RecurringEvent)
                {
                    dbQuery = "DELETE FROM RecurringEvents WHERE [Id] = @Id";
                }
                else
                {
                    dbQuery = "DELETE FROM Events WHERE [Id] = @Id";
                }
                sqlCommand = new SqlCommand(dbQuery, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Id", Event.EventID);
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
                        dbReturnMessage = "Error: " + Event.EventName + " Data Could Not Be Deleted!";
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
        //update Event
        public string UpdateEvent(Event Event)
        {
            if (Event is RecurringEvent)
            {
                dbQuery = "UPDATE RecurringEvents SET [Name] = @Name, [Type]=@Type, [Note]=@Note," +
                    "[ContactName]=@ContactName,[Frequency]=@Frequency,[StartDate]=@StartDate,[EndDate]=@EndDate WHERE [Id] = @Id ;";
            }
            else
            {
                dbQuery = "UPDATE EventS SET [Name] = @Name, [Type]=@Type, [Note]=@Note," +
             "[ContactName]=@ContactName,[StartDate]=@StartDate WHERE [Id] = @Id ;";
            }
            sqlCommand = new SqlCommand(dbQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Id", Event.EventID);
            sqlCommand.Parameters.AddWithValue("@Name", Event.EventName);
            sqlCommand.Parameters.AddWithValue("@Type", Event.EventType);
            sqlCommand.Parameters.AddWithValue("@Note", Event.EventNote);
            sqlCommand.Parameters.AddWithValue("@ContactName", Event.EventContact);
            sqlCommand.Parameters.AddWithValue("@StartDate", Event.EventDate);
            if (Event is RecurringEvent rEvent)
            {
                sqlCommand.Parameters.AddWithValue("@Frequency", rEvent.EventFreQuency);
                sqlCommand.Parameters.AddWithValue("@EndDate", rEvent.EventEndDate);
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
                    dbReturnMessage = "Error: " + Event.EventName + " I had difficulty to be certain the update was successful!";
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
        //check if Event name exist
        public bool CheckEvent(Event Event)
        {
            dbQuery = "SELECT count(*)  FROM Event WHERE [Name] = @Name";
            sqlCommand = new SqlCommand(dbQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Name", Event.EventName);
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

        //get Recurring Event
        public List<RecurringEvent> GetSavedRecurringEvent(int userId)
        {
            RecurringEventList.Clear(); //fetch updated contact list from database into contactlist;
            dbQuery = "SELECT * FROM RecurringEvents  WHERE [UserId] = @UserId ;";
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
                        ReadEventRow((IDataRecord)reader,"RecurringEvent");

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

            return RecurringEventList;
        }

        //Iterate through Event
        //add to Event list
        private static void ReadEventRow(IDataRecord record,string reader)
        {
            int id = Convert.ToInt32(record[0]);
            int UserId = Convert.ToInt32(record[1]);
            string Name = Convert.ToString(record[2]);
            string Type = Convert.ToString(record[3].ToString());
            string Note = Convert.ToString(record[4]);
            string CountactName = Convert.ToString(record[5]);
            DateTime EventDate = Convert.ToDateTime(record[6]);
            if (reader == "Event")
            {
                Event obj = new Event(id, UserId, Name, Note, EventDate, Type, CountactName);
                EventList.Add(obj); //add contact to contact list
            }
            if(reader == "RecurringEvent")
            {
                string Eventfrequency = Convert.ToString(record[7]);
                DateTime EndDate = Convert.ToDateTime(record[8]);
                RecurringEvent obj = new RecurringEvent(id, UserId, Name, Note, EventDate, Type, CountactName, Eventfrequency, EndDate);
                RecurringEventList.Add(obj); //add contact to contact list
            }
            
        }

        //read returning Event row

        //access list of Eventation
        public static List<Event> RequestEventList()
        {
            return EventList;
        }
        public static List<RecurringEvent> RequestRecurringEventList()
        {

            return RecurringEventList;
        }
    }
}
