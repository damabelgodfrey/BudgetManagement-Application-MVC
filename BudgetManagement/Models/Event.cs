using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement.Models
{
   public class Event
    {
        public Event(int id, int UserID, string name, string note, DateTime datetime, string type, string contact)
        {
            EventID = id;
            EventUserID = UserID;
            EventName = name;
            EventNote = note;
            EventType = type;
            EventDate = datetime;
            EventContact = contact;
        }
        public Event()
        {
            //Eventactionaction EventObj;
            //EventObj.addEventaction("Product Buy","","05,11,2019",100,"income",&Category("Game",500));

        }

        public int EventID { get; set; }
        public int EventUserID { get; set; }
        public string EventName { get; set; }
        public string EventNote { get; set; }
        public double EventAmount { get; set; }
        public string EventType { get; set; }
        public DateTime EventDate { get; set; }
        public string EventContact { get; set; }


    }
}

