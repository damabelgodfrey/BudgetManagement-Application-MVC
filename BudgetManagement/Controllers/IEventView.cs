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
    void ClearGrid();
    void AddEventToGrid(Event Event);
    void UpdateGridWithChangedEvent(Event Event);
    void RemoveEventFromGrid(Event Event);
    string GetIdOfSelectedEventInGrid();
    void SetSelectedEventInGrid(Event Event);

    string ViewEventDate { get; set; }
    bool CanModifyID { set; }
    string ViewEventID { get; set; }
    string ViewEventNote { get; set; }
    string ViewEventContact { get; set; }
    string ViewEventType { get; set; }
    string ViewEventName { get; set; }

    void ClearRGrid();
    // void AddREventToGrid(RecurringEvent Event);
    // void UpdateGridWithChangedREvent(RecurringEvent Event);
    // void RemoveREventFromGrid(RecurringEvent Event);
    string GetIdOfSelectedREventInGrid();
    // void SetSelectedREventInGrid(RecurringEvent Event);

    bool CanModifyRID { set; }
    string ViewREventID { get; set; }
    string ViewREventNote { get; set; }
    string ViewREventContact { get; set; }
    string ViewREventType { get; set; }
    string ViewREventName { get; set; }
    string ViewREventStartDate { get; set; }
    string ViewREventEndDate { get; set; }
    string viewREventFrequency { get; set; }
}
}
