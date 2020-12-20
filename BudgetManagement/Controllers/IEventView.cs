using BudgetManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement.Controllers
{
    public interface IEventView
    { 
         void SetEventController(EventController controller);
        void ClearGrid(String typeFlag);
        void AddEventToGrid(Event Event);
        void UpdateGridWithChangedEvent(Event Event);
        void RemoveEventFromGrid(Event Event);
        string GetIdOfSelectedEventInGrid();
        void SetSelectedEventInGrid(Event Event);

        DateTime ViewEventDate { get; set; }
        bool CanModifyID { set; }
        int ViewEventID { get; set; }
        string ViewEventNote { get; set; }
        string ViewEventContact { get; set; }
        string ViewEventType { get; set; }
        string ViewEventName { get; set; }

        string GetIdOfSelectedREventInGrid();
        // void SetSelectedREventInGrid(RecurringEvent Event);

        bool CanModifyRID { set; }
        int ViewREventID { get; set; }
        string ViewREventNote { get; set; }
        string ViewREventContact { get; set; }
        string ViewREventType { get; set; }
        string ViewREventName { get; set; }
        DateTime ViewREventStartDate { get; set; }
        DateTime ViewREventEndDate { get; set; }
        string viewREventFrequency { get; set; }
    }
}
