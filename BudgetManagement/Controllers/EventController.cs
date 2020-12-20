using BudgetManagement.Models;
using BudgetManagement.Repository;
using BudgetManagement.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

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
        public void DisposeEventView()
        {

            _view.Dispose();
        }
        public void SetEventFormDetails()
        {
            EventRepository getSaveEvent = new EventRepository();
            EventRepository getSaveREvent = new EventRepository();
            myEventlist = getSaveEvent.GetSavedEvent(userID);
            myRecurringEventlist = getSaveREvent.GetSavedRecurringEvent(userID); ;
            LoadEventView("NormalEvent");
            LoadEventView("RecurringEvent");
        }

        public void AddNewEvent(String typeflag)
        {
            //string id = _users.FindLastIndex.GetType();
            DateTime now = DateTime.Now;
            if(typeflag == "NormalEvent")
            {
                _selectedEvent = new Event(userID, userID, "", "", now, "", "");
                this.UpdateViewDetailValues(_selectedEvent);
                this._view.CanModifyID = false;
            }
            else
            {
                _selectedREvent = new RecurringEvent(userID, userID, "", "", now, "", "", "", now);
                this.UpdateViewDetailValues(_selectedREvent);
                this._view.CanModifyRID = false;
            }
            
        }



        public async void DeleteEvent(Event myEvent)
        {
            EventRepository eventRepoObj = new EventRepository();
            string returnMsg = await Task.Run(() => eventRepoObj.DeleteEvent(myEvent));
            if (returnMsg == "success")
            {
                if (myEvent is RecurringEvent rEvent)
                {
                    myRecurringEventlist.Clear();
                    myRecurringEventlist = eventRepoObj.GetSavedRecurringEvent(userID);
                    this._view.RemoveEventFromGrid(rEvent);


                    int newSelectedTransIndex = myRecurringEventlist.IndexOf(rEvent) + 1;
                    if (newSelectedTransIndex > -1 && newSelectedTransIndex < myRecurringEventlist.Count)
                    {

                        this._view.SetSelectedEventInGrid(myRecurringEventlist[newSelectedTransIndex]);
                    }


                }
                else
                {
                    int newSelectedIndex = myEventlist.IndexOf(myEvent) + 1;
                    myEventlist.Clear();
                    myEventlist = eventRepoObj.GetSavedEvent(userID);
                    this._view.RemoveEventFromGrid(myEvent);
                    if (newSelectedIndex > -1 && newSelectedIndex < myEventlist.Count)
                    {
                        this._view.SetSelectedEventInGrid(myEventlist[newSelectedIndex]);
                    }


                }
            }
            else
            {
                MessageBox.Show(returnMsg + " Event not deleted", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal async void UpdateEvent(Event myEvent)
        {
            string returnMsg = "false";
            EventRepository eventRepoObj = new EventRepository();
            returnMsg = await Task.Run(() => eventRepoObj.UpdateEvent(myEvent));
            if (myEvent is RecurringEvent)
            {
                myRecurringEventlist.Clear();
                myRecurringEventlist = eventRepoObj.GetSavedRecurringEvent(userID);
            }
            else
            {
                myEventlist.Clear();
                myEventlist = eventRepoObj.GetSavedEvent(userID);
            }

            if (returnMsg == "success")
            {
                this._view.UpdateGridWithChangedEvent(myEvent);
                MessageBox.Show("Updated SUCCESSFULLY");
            }
            else
            {
                MessageBox.Show(returnMsg, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            _view.SetSelectedEventInGrid(myEvent);
        }
        internal async void AddEvent(Event myevent)
        {
            EventRepository eventRepoObj = new EventRepository();
            string returnMsg = await Task.Run(() => eventRepoObj.AddEvent(myevent));
            if (returnMsg == "success")
            {
                EventRepository eventObj = new EventRepository();
                if (myevent is RecurringEvent)
                {
                    this._view.ClearGrid("RecurringEvent");
                    myRecurringEventlist.Clear();
                    myRecurringEventlist = eventObj.GetSavedRecurringEvent(userID);
                    MessageBox.Show(myRecurringEventlist.Count+ " in count");
                    int i = 1;
                    foreach (RecurringEvent rEvent in myRecurringEventlist.ToList())
                    {
                        this._view.AddEventToGrid(rEvent); //UPDATE GRIDE
                        i++;
                       // MessageBox.Show(myevent.EventName + " in adding");

                    }
                    MessageBox.Show(myevent.EventName + " ADDED SUCCESSFULLY");

                }
                else
                {
                    this._view.ClearGrid("NormalEvent");
                    myEventlist.Clear();
                    myEventlist = await Task.Run(() => eventObj.GetSavedEvent(userID));

                    foreach (Event myEvent in myEventlist.ToList())
                    {
                        this._view.AddEventToGrid(myEvent); //UPDATE GRIDE
                    }
                    MessageBox.Show(myevent.EventName + " ADDED SUCCESSFULLY");

                }
            }
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
                _view.ViewREventID = rEvent.EventID;
                _view.ViewREventName = rEvent.EventName;
                _view.ViewREventType = rEvent.EventType;
                _view.ViewREventNote = rEvent.EventNote;
                _view.ViewREventStartDate = rEvent.EventDate;
                _view.ViewREventEndDate = rEvent.EventEndDate;
                _view.ViewREventContact = rEvent.EventContact;
                _view.viewREventFrequency = rEvent.EventFreQuency;

            }
            else
            {
                _view.ViewEventID = Event.EventID;
                _view.ViewEventName = Event.EventName;
                _view.ViewEventType = Event.EventType;
                _view.ViewEventNote = Event.EventNote;
                _view.ViewEventDate = Event.EventDate;
                _view.ViewEventContact = Event.EventContact;
            }

        }

        public void LoadEventView(String typeflag)
        {
            _view.ClearGrid(typeflag);
            if (typeflag == "NormalEvent")
            {
                if (myEventlist.Count > 0)
                {
                    foreach (Event Event in myEventlist.ToList())
                    {
                        _view.AddEventToGrid(Event);
                    }
                    _view.SetSelectedEventInGrid(myEventlist[0]);
                }
            }
            else
            {
                if (myRecurringEventlist.Count > 0)
                {
                    foreach (RecurringEvent rEvent in myRecurringEventlist)
                    {
                        _view.AddEventToGrid(rEvent);
                    }
                    _view.SetSelectedEventInGrid(myRecurringEventlist[0]);
                }
            }
        }
    }
}
