using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement.Models
{ 
  public class RecurringEvent : Event
    {
        public RecurringEvent(int id, int UserID, string name, string note, DateTime datetime, string type, string contact, string frequency, DateTime endDate) : base()
        {
            EventID = id;
            EventUserID = UserID;
            EventName = name;
            EventNote = note;
            EventType = type;
            EventDate = datetime;
            EventContact = contact;
            EventFreQuency = frequency;
            EventEndDate = endDate;

        }
        public string EventFreQuency { get; set; }
        public DateTime EventEndDate { get; set; }
    }
}
