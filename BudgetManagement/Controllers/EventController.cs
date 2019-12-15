using BudgetManagement.Models;
using BudgetManagement.Repository;
using BudgetManagement.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManagement.Controllers
{
    public class EventController
    {
        EventView _view;
        Event _selectedEvent;
        RecurringEvent _selectedREvent;
        List<Event> myEventlist;
        List<RecurringEvent> myRecurringEventlist;
        //List<RecurringEvent> myRecurringEventlist = new List<RecurringEvent>();

        int userID = UserRepository.GetUserID();
        private static string NewContactName = "";
        internal static string GetNewContactName()
        {
            return NewContactName;
        }

        public EventController()
        {
            _view = EventView.GetEventForm();
            _view.SetEventController(this);
            SetEventFormDetails();
            _view.WindowState = FormWindowState.Normal;
            _view.Activate();
            _view.Show();
        }

        public void SetEventFormDetails()
        {
            EventRepository getSaveEvent = new EventRepository();
            getSaveEvent.GetSavedEvent(userID);
            EventRepository getSaveREvent = new EventRepository();
            getSaveREvent.GetSavedRecurringEvent(userID);
            myEventlist = EventRepository.RequestEventList();
            myRecurringEventlist = EventRepository.RequestRecurringEventList();
            LoadEventView();
            LoadREventView();
        }

        public void AddNewEvent()
        {
            //string id = _users.FindLastIndex.GetType();
            DateTime now = DateTime.Now;
            _selectedEvent = new Event(userID, userID, "", "", now, "", "");
            this.UpdateViewDetailValues(_selectedEvent);
            this._view.CanModifyID = false;
        }

        //add new recurring Event
        public void AddNewREvent()
        {
            DateTime now = DateTime.Now;
            _selectedREvent = new RecurringEvent(userID, userID, "", "", now, "", "", "", now);
            this.UpdateViewDetailValues(_selectedREvent);
            this._view.CanModifyRID = false;
        }



        public async void RemoveEvent()
        {
            string id = this._view.GetIdOfSelectedEventInGrid();
            Event EventToRemove = null;
            if (id != "")
            {
                foreach (Event Event in this.myEventlist)
                {
                    if (Event.EventID.ToString() == id)
                    {
                        EventToRemove = Event;
                        break;
                    }
                }

                if (EventToRemove != null)
                {

                    EventRepository EventRepoObj = new EventRepository();
                    string returnMsg = await Task.Run(() => EventRepoObj.DeleteEvent(EventToRemove));
                    if (returnMsg == "success")
                    {
                        myEventlist = EventRepoObj.GetSavedEvent(userID);
                        int newSelectedIndex = this.myEventlist.IndexOf(EventToRemove);
                        //this.myEventlist.Remove(EventToRemove);
                        this._view.RemoveEventFromGrid(EventToRemove);

                        if (newSelectedIndex > -1 && newSelectedIndex < myEventlist.Count)
                        {
                            this._view.SetSelectedEventInGrid((Event)myEventlist[newSelectedIndex]);
                        }
                    }
                    else
                    {
                        MessageBox.Show(returnMsg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }
        //remove recurring Event
        internal async void RemoveREvent()
        {
            string id = this._view.GetIdOfSelectedREventInGrid();


            RecurringEvent rEventToRemove = null;

            if (id != "")
            {
                foreach (RecurringEvent rEvent in this.myRecurringEventlist)
                {
                    if (rEvent.EventID.ToString() == id)
                    {
                        rEventToRemove = rEvent;
                        break;
                    }
                }

                if (rEventToRemove != null)
                {
                    EventRepository EventRepoObj = new EventRepository();
                    string returnMsg = await Task.Run(() => EventRepoObj.DeleteEvent(rEventToRemove));
                    if (returnMsg == "success")
                    {
                        myRecurringEventlist = EventRepoObj.GetSavedRecurringEvent(userID);
                        int newRSelectedIndex = this.myRecurringEventlist.IndexOf(rEventToRemove);
                        //this.myEventlist.Remove(EventToRemove);
                        this._view.RemoveEventFromGrid(rEventToRemove);

                        if (newRSelectedIndex > -1 && newRSelectedIndex < myRecurringEventlist.Count)
                        {
                            this._view.SetSelectedEventInGrid(myRecurringEventlist[newRSelectedIndex]);
                        }
                    }
                    else
                    {
                        MessageBox.Show(returnMsg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }

        internal async void SaveREvent()
        {
            updateEventWithViewValues(_selectedREvent);
            int id = UserRepository.GetUserID();

            if (!this.myRecurringEventlist.Contains(_selectedREvent))
            {
                // Add new Event
                EventRepository EventRepoObj = new EventRepository();
                string returnMsg = await Task.Run(() => EventRepoObj.AddEvent(_selectedREvent));

                if (returnMsg == "success")
                {
                    this._view.ClearRGrid();
                    EventRepository EventObj = new EventRepository();

                    myRecurringEventlist.Clear();
                    myRecurringEventlist = EventObj.GetSavedRecurringEvent(id);
                    foreach (RecurringEvent Event in this.myRecurringEventlist)
                    {
                        this._view.AddEventToGrid(Event); //UPDATE GRIDE

                    }
                    MessageBox.Show("ADDED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show(returnMsg.ToString() + "  Event was not able to be added to database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Update existing Event
                EventRepository EventRepoObj = new EventRepository();
                string returnMsg = EventRepoObj.UpdateEvent(_selectedREvent);
                myRecurringEventlist = await Task.Run(() => EventRepoObj.GetSavedRecurringEvent(id));
                if (returnMsg == "success")
                {
                    this._view.UpdateGridWithChangedEvent(_selectedREvent);
                    MessageBox.Show(returnMsg, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(returnMsg, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            _view.SetSelectedEventInGrid(_selectedREvent);
            this._view.CanModifyRID = false;
        }

        internal async void SaveEvent()
        {
            updateEventWithViewValues(_selectedEvent);
            if (!this.myEventlist.Contains(_selectedEvent))
            {
                EventRepository EventRepoObj = new EventRepository();
                string returnMsg = await Task.Run(() => EventRepoObj.AddEvent(_selectedEvent));
                if (returnMsg == "success")
                {
                    this._view.ClearGrid();
                    int id = UserRepository.GetUserID();
                    EventRepository EventObj = new EventRepository();
                    myEventlist = EventObj.GetSavedEvent(id);
                    foreach (Event Event in this.myEventlist)
                    {
                        this._view.AddEventToGrid(Event); //UPDATE GRIDE

                    }
                    MessageBox.Show("ADDED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    string Dcontact = _selectedEvent.EventContact;
                    List<Contact> dContactList = ContactRepository.GetContactList();


                    int contactExist = 0;
                    foreach (var contact in dContactList)
                    {
                        if (Dcontact == contact.cName)
                        {
                            contactExist = 1;
                        }
                    }
                    if (contactExist == 0)
                    {
                        NewContactName = _selectedEvent.EventContact;
                        ContactController controller = new ContactController();
                    }
                }
                else
                {
                    MessageBox.Show(returnMsg.ToString() + "  Event was not able to be added to database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                // Update existing Event
                EventRepository EventRepoObj = new EventRepository();
                string returnMsg = await Task.Run(() => EventRepoObj.UpdateEvent(_selectedEvent));
                if (returnMsg == "success")
                {
                    this._view.UpdateGridWithChangedEvent(_selectedEvent);
                    MessageBox.Show(returnMsg, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show(returnMsg, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            _view.SetSelectedEventInGrid(_selectedEvent);
            this._view.CanModifyID = false;
        }

        public void SelectedEventChanged(string selectedEventId)
        {
            foreach (Event Event in this.myEventlist)
            {
                if (Event.EventID.ToString() == selectedEventId)
                {
                    _selectedEvent = Event;
                    UpdateViewDetailValues(Event);
                    _view.SetSelectedEventInGrid(Event);
                    this._view.CanModifyID = false;
                    break;
                }
            }
        }
        public void SelectedREventChanged(string selectedREventId)
        {
            foreach (RecurringEvent rEvent in this.myRecurringEventlist)
            {
                if (rEvent.EventID.ToString() == selectedREventId)
                {
                    _selectedREvent = rEvent;
                    UpdateViewDetailValues(rEvent);
                    _view.SetSelectedEventInGrid(rEvent);
                    this._view.CanModifyRID = false;
                    break;
                }
            }

        }

        private void UpdateViewDetailValues(Event Event)
        {
            if (Event is RecurringEvent rEvent)
            {
                _view.ViewREventID = rEvent.EventID.ToString();
                _view.ViewREventName = rEvent.EventName;
                _view.ViewREventType = rEvent.EventType;
                _view.ViewREventNote = rEvent.EventNote;
                _view.ViewREventStartDate = rEvent.EventDate.ToString();
                _view.ViewREventEndDate = rEvent.EventEndDate.ToString();
                _view.ViewREventContact = rEvent.EventContact;
                _view.viewREventFrequency = rEvent.EventFreQuency;
            }
            else
            {
                _view.ViewEventID = Event.EventID.ToString();
                _view.ViewEventName = Event.EventName;
                _view.ViewEventType = Event.EventType;
                _view.ViewEventNote = Event.EventNote;
                _view.ViewEventDate = Event.EventDate.ToString();
                _view.ViewEventContact = Event.EventContact;
            }

        }

        private void updateEventWithViewValues(Event Event)
        {
            if (Event is RecurringEvent rEvent)
            {
                rEvent.EventID = Convert.ToInt32(_view.ViewREventID);
                rEvent.EventName = _view.ViewREventName;
                rEvent.EventType = _view.ViewREventType;
                rEvent.EventNote = _view.ViewREventNote;
                rEvent.EventDate = Convert.ToDateTime(_view.ViewREventStartDate);
                rEvent.EventEndDate = Convert.ToDateTime(_view.ViewREventEndDate);
                rEvent.EventContact = _view.ViewREventContact;
                rEvent.EventFreQuency = _view.viewREventFrequency;
            }
            else
            {
                Event.EventID = Convert.ToInt32(_view.ViewEventID);
                Event.EventName = _view.ViewEventName;
                Event.EventType = _view.ViewEventType;
                Event.EventNote = _view.ViewEventNote;
                Event.EventDate = Convert.ToDateTime(_view.ViewEventDate);
                Event.EventContact = _view.ViewEventContact;
            }

        }

        public void LoadEventView()
        {
            _view.ClearGrid();
            if (myEventlist.Count > 0)
            {
                foreach (Event Event in myEventlist)
                {
                    _view.AddEventToGrid(Event);
                }

                _view.SetSelectedEventInGrid((Event)myEventlist[0]);
            }


        }

        //recuring Event functions.
        public void LoadREventView()
        {
            _view.ClearRGrid();
            if (myRecurringEventlist.Count > 0)
            {
                foreach (RecurringEvent rEvent in myRecurringEventlist)
                {
                    _view.AddEventToGrid(rEvent);

                }
                _view.SetSelectedEventInGrid((RecurringEvent)myRecurringEventlist[0]);
            }


        }
    }
}
