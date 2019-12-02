using BudgetManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement.Repository
{
    public class EventRepository
    {
        public static List<Event> EventList = new List<Event>();
        public static List<RecurringEvent> RecurringEventList = new List<RecurringEvent>();

        internal void GetEvents(int uID)
        {
            throw new NotImplementedException();
        }

        internal void GetRecurringEvents(int uID)
        {
            throw new NotImplementedException();
        }
    }
}
