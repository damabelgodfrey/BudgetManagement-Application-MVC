using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement.Models
{ 
  public class RecurringEvent : Event
    {
        public RecurringEvent(int id, int UserID, string name, string note, string datetime, double amount, string type, string contact, string frequency, string endDate) : base()
        {
            EventID = id;
            EventUserID = UserID;
            EventName = name;
            EventNote = note;
            EventAmount = amount;
            EventType = type;
            EventDate = datetime;
            EventContact = contact;

        }
        public string EventFreQuency { get; set; }
        public string EventEndDate { get; set; }
    }
}
