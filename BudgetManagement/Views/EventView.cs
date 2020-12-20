using BudgetManagement.Controllers;
using BudgetManagement.Models;
using BudgetManagement.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManagement.Views
{
    public partial class EventView : Form, IEventView
    {
        EventController EventController;
        private static EventView EventForm;
        private static readonly object EventPadlock = new object();
        int UserId = TransactionController.GetUserID();
        List<Contact> myContacts;

        public EventView()
        {
            InitializeComponent();
            ContactRepository contacts = new ContactRepository();
            myContacts = contacts.GetSavedContact(UserId);
            this.AllEventContact.DataSource = myContacts;
            this.AllEventContact.DisplayMember = "cName";
            this.rEventContactList.DataSource = myContacts;
            this.rEventContactList.DisplayMember = "cName";
        }

        // for recurent Event
        public string viewREventFrequency
        {
            get { return this.rEventFrequency.Text; }
            set { this.rEventFrequency.Text = value; }

        }
        public string AllRContactName
        {
            get { return this.rEventContactList.DisplayMember; }

        }
        public string AllRFrequency
        {
            get { return this.rEventFrequencyList.DisplayMember; }

        }
        public string ViewREventName
        {
            get { return this.rEventName.Text; }

            set
            {
                this.rEventName.Text = value;
            }
        }

        public string ViewREventType
        {
            get
            {
                if (this.rAppointment.Checked)
                    return this.rAppointment.Text;
                else
                    return this.rTask.Text;
            }
            set
            {
                if (value == "Task")
                    this.rTask.Checked = true;
                else
                    this.rAppointment.Checked = true;
            }

        }


        public string ViewREventContact
        {
            get { return this.rEventContact.Text; }
            set { this.rEventContact.Text = value; }
        }
        public string ViewREventNote
        {
            get { return this.rEventNote.Text; }
            set { this.rEventNote.Text = value; }
        }
        public int ViewREventID
        {
            get { return Convert.ToInt32(this.EID.Text); }
            set { this.EID.Text = value.ToString(); }
        }
        public bool CanModifyRID
        {
            set { this.EID.Enabled = value; }
        }
        public DateTime ViewREventStartDate
        {
            get { return Convert.ToDateTime(this.rEventStartPeriod.Text); }
            set { this.rEventStartPeriod.Text = value.ToString(); }
        }
        public DateTime ViewREventEndDate
        {
            get { return Convert.ToDateTime(this.rEventEndPeriod.Text); }
            set { this.rEventEndPeriod.Text = value.ToString(); }
        }


        public string GetIdOfSelectedREventInGrid()
        {
            if (this.REventListView.SelectedItems.Count > 0)
            {
                return this.REventListView.SelectedItems[0].Text;

            }
            else
            {
                return "";

            }
        }




        //Event
        public string AllContactName
        {
            get { return this.AllEventContact.DisplayMember; }

        }
        public string ViewEventName
        {
            get { return this.EventName.Text; }

            set
            {
                this.EventName.Text = value;
            }
        }

        public string ViewEventType
        {
            get
            {
                if (this.TaskRbtn.Checked)
                    return this.TaskRbtn.Text;
                else
                    return this.AppointmentRbtn.Text;
            }
            set
            {
                if (value == "Task")
                    this.TaskRbtn.Checked = true;
                else
                    this.AppointmentRbtn.Checked = true;
            }

        }

        public string ViewEventContact
        {
            get { return this.EventContact.Text; }
            set { this.EventContact.Text = value; }
        }
        public string ViewEventNote
        {
            get { return this.EventNote.Text; }
            set { this.EventNote.Text = value; }
        }
        public int ViewEventID
        {
            get { return Convert.ToInt32(this.EventIDtbox.Text); }
            set { this.EventIDtbox.Text = value.ToString(); }
        }
        public bool CanModifyID
        {
            set { this.EventIDtbox.Enabled = value; }
        }
        public DateTime ViewEventDate
        {
            get { return Convert.ToDateTime(this.EventDate.Text); }
            set { this.EventDate.Text = value.ToString(); }
        }


        public void AddEventToGrid(Event Event)
        {
            ListViewItem parent;
            if (Event is RecurringEvent rEvent)
            {
                parent = this.REventListView.Items.Add(rEvent.EventID.ToString());
                parent.SubItems.Add(rEvent.EventName);
                parent.SubItems.Add(rEvent.EventType);
                parent.SubItems.Add(rEvent.EventNote);
                parent.SubItems.Add(rEvent.EventFreQuency);
                parent.SubItems.Add(rEvent.EventEndDate.ToString());

            }
            else
            {
                parent = this.EventGridView.Items.Add(Event.EventID.ToString());
                parent.SubItems.Add(Event.EventName);
                parent.SubItems.Add(Event.EventType);
                parent.SubItems.Add(Event.EventNote.ToString());
                parent.SubItems.Add(Event.EventContact);
                ApplyStripeToEventGrid();
            }
        }

        internal static EventView GetEventForm()
        {
            lock (EventPadlock)
            {
                if (EventForm == null || EventForm.IsDisposed)
                {
                    EventForm = new EventView();
                }
                return EventForm;
            }
        }


        public void ClearGrid(String typeFlag)
        {
            // Define columns and clear item
            if(typeFlag == "RecurringEvent")
            {
                // Define columns and clear item
                this.REventListView.Columns.Clear();
                this.REventListView.Columns.Add("ID", 150, HorizontalAlignment.Left);
                this.REventListView.Columns.Add("Name", 150, HorizontalAlignment.Left);
                this.REventListView.Columns.Add("TYPE", 150, HorizontalAlignment.Left);
                this.REventListView.Columns.Add("NOTE", 250, HorizontalAlignment.Left);
                this.REventListView.Columns.Add("FREQUENCY", 150, HorizontalAlignment.Left);
                this.REventListView.Columns.Add("END DATE", 150, HorizontalAlignment.Left);

                this.REventListView.Items.Clear();
            }
            else
            {
                this.EventGridView.Columns.Clear();
                this.EventGridView.Columns.Add("ID", 150, HorizontalAlignment.Left);
                this.EventGridView.Columns.Add("Name", 150, HorizontalAlignment.Left);
                this.EventGridView.Columns.Add("TYPE", 200, HorizontalAlignment.Left);
                this.EventGridView.Columns.Add("NOTE", 150, HorizontalAlignment.Left);
                this.EventGridView.Columns.Add("CONTACT", 250, HorizontalAlignment.Left);
                this.EventGridView.Items.Clear();
            }
      
        }

        public void UpdateGridWithChangedEvent(Event Event)
        {
            ListViewItem rowToUpdate = null;
            if (Event is RecurringEvent rEvent)
            {
                foreach (ListViewItem row in this.REventListView.Items)
                {
                    if (row.Text == rEvent.EventID.ToString())
                    {
                        rowToUpdate = row;
                    }
                }

                if (rowToUpdate != null)
                {
                    rowToUpdate.Text = rEvent.EventID.ToString();
                    rowToUpdate.SubItems[1].Text = rEvent.EventName;
                    rowToUpdate.SubItems[2].Text = rEvent.EventType;
                    rowToUpdate.SubItems[3].Text = rEvent.EventNote.ToString();
                    rowToUpdate.SubItems[4].Text = rEvent.EventFreQuency;
                    rowToUpdate.SubItems[5].Text = rEvent.EventDate.Date +" - " + rEvent.EventEndDate.Date;
                   // REventListView.MultiSelect = false;
                    rowToUpdate.Selected = true;
                   // REventListView.MultiSelect = true;

                }
            }
            else
            {
                foreach (ListViewItem row in this.EventGridView.Items)
                {
                    if (row.Text == Event.EventID.ToString())
                    {
                        rowToUpdate = row;
                    }
                }

                if (rowToUpdate != null)
                {
                    rowToUpdate.Text = Event.EventID.ToString();
                    rowToUpdate.SubItems[1].Text = Event.EventName;
                    rowToUpdate.SubItems[2].Text = Event.EventType;
                    rowToUpdate.SubItems[3].Text = Event.EventNote.ToString();
                    rowToUpdate.SubItems[4].Text = Event.EventContact;
                    EventGridView.MultiSelect = false;
                    rowToUpdate.Selected = true;
                    EventGridView.MultiSelect = true;

                }
            }
        }
        public string GetIdOfSelectedEventInGrid()
        {
            if (this.EventGridView.SelectedItems.Count > 0)
            {
                return this.EventGridView.SelectedItems[0].Text;

            }
            else
            {
                return "";

            }
        }

        public void RemoveEventFromGrid(Event Event)
        {

            ListViewItem rowToRemove = null;
            if (Event is RecurringEvent)
            {
                RecurringEvent rEvent = (RecurringEvent)Event;
                foreach (ListViewItem row in this.REventListView.Items)
                {
                    if (row.Text == rEvent.EventID.ToString())
                    {
                        rowToRemove = row;
                    }
                }

                if (rowToRemove != null)
                {
                    this.REventListView.Items.Remove(rowToRemove);
                    ApplyStripeToEventGrid();
                    this.EventGridView.Focus();
                }
            }
            else
            {
                foreach (ListViewItem row in this.EventGridView.Items)
                {
                    if (row.Text == Event.EventID.ToString())
                    {
                        rowToRemove = row;
                    }
                }

                if (rowToRemove != null)
                {
                    this.EventGridView.Items.Remove(rowToRemove);
                    ApplyStripeToEventGrid();
                    this.EventGridView.Focus();
                }
            }


        }


        public void SetSelectedEventInGrid(Event Event)
        {

            if (Event is RecurringEvent)
            {
                RecurringEvent rEvent = (RecurringEvent)Event;

                foreach (ListViewItem row in this.REventListView.Items)
                {
                    if (row.Text == rEvent.EventID.ToString())
                    {
                        row.Selected = true;
                    }
                }
            }
            else
            {
                foreach (ListViewItem row in this.EventGridView.Items)
                {
                    if (row.Text == Event.EventID.ToString())
                    {
                        row.Selected = true;
                    }
                }
            }
        }

        //apply zebraline to grid
        public void ApplyStripeToEventGrid()
        {
            int i = 0;
            EventGridView.BackColor = Color.FromArgb(255, 255, 255);
            foreach (ListViewItem row in this.EventGridView.Items)
            {
                if (i == 1)
                {
                    row.BackColor = Color.FromArgb(230, 230, 255);
                    i = 0;

                }
                else
                {
                    row.BackColor = Color.FromArgb(255, 255, 255);
                    i = 1;
                }
            }
        }

        public void SetEventController(EventController controller)
        {
            EventController = controller;

        }

        private void EventGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.EventGridView.SelectedItems.Count > 0)
                this.EventController.SelectedEventChanged(this.EventGridView.SelectedItems[0].Text);
        }

        private void AddEvent_Click(object sender, EventArgs e)
        {
            EventGridView.Enabled = false;
            UpdateEvent.Visible = false;
            DeleteEvent.Visible = false;
            AddEvent.Enabled = false;
            cancelEvent.Visible = true;
            SubmitEvent.Visible = true;
            this.transDetailBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#d8dde3");
            this.EventController.AddNewEvent("NormalEvent");
            EventGridView.Focus();

        }

        private void UpdateEvent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ViewEventName))
            {
                MessageBox.Show("Please Enter Event Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ViewEventDate.Date < DateTime.Today)
            {
                MessageBox.Show("Please choose a future date", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Event myEvent = new Event(ViewEventID, UserId, ViewEventName, ViewEventNote, ViewEventDate, ViewEventType, ViewEventContact);
            this.EventController.UpdateEvent(myEvent);
            this.transDetailBox.BackColor = System.Drawing.Color.Empty;
            EventGridView.Focus();
        }

        private void REventListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.REventListView.SelectedItems.Count > 0)
                this.EventController.SelectedREventChanged(this.REventListView.SelectedItems[0].Text);
        }

        private void rEventContactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rEventContact.Text = this.rEventContactList.GetItemText(this.rEventContactList.SelectedItem);
        }

        private void rEventFrequencyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rEventFrequency.Text = this.rEventFrequencyList.GetItemText(this.rEventFrequencyList.SelectedItem);
        }

        private void AllEventContact_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.EventContact.Text = this.AllEventContact.GetItemText(this.AllEventContact.SelectedItem);

        }

        private void RefreshEventView_Click(object sender, EventArgs e)
        {
            EventGridView.Enabled = true;
            UpdateEvent.Visible = true;
            SubmitEvent.Visible = false;
            DeleteEvent.Visible = true;
            AddEvent.Enabled = true;
            cancelEvent.Visible = false;
            EventGridView.Focus();
            EventController.LoadEventView("NormalEvent");
            ContactRepository contacts = new ContactRepository();
            myContacts = contacts.GetSavedContact(UserId);
            AllEventContact.DataSource = null;
            rEventContactList.DataSource = null;
            this.AllEventContact.DataSource = myContacts;
            this.AllEventContact.DisplayMember = "cName";
            this.rEventContactList.DataSource = myContacts;
            this.rEventContactList.DisplayMember = "cName";

        }



        private void AddReEvent_Click(object sender, EventArgs e)
        {
            
            REventListView.Enabled = false;
            UpdateReEvent.Visible = false;
            DeleteReEvent.Visible = false;
            AddReEvent.Enabled = false;
            CancelREvent.Visible = true;
            SubmitReEvent.Visible = true;
            this.rTransDetailBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#d8dde3");
            this.EventController.AddNewEvent("RecurringEvent");
        }

        private void UpdateReEvent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ViewREventName))
            {
                MessageBox.Show("Please Enter Event Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(viewREventFrequency))
            {
                MessageBox.Show("Please Enter Event Frequency", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ViewREventStartDate.Date < DateTime.Today)
            {
                MessageBox.Show("Please choose a future date", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ViewREventStartDate.Date > ViewREventEndDate)
            {
                MessageBox.Show("Please choose an end date that is greaater than start date", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RecurringEvent myRecurringEvent = new RecurringEvent(ViewREventID, UserId, ViewREventName, ViewREventNote, ViewREventStartDate, ViewREventType, ViewREventContact, viewREventFrequency, ViewREventEndDate);
            this.EventController.UpdateEvent(myRecurringEvent);
            rTransDetailBox.BackColor = System.Drawing.Color.Empty;
            REventListView.Focus();
    
        }

        private void DeleteReEvent_Click(object sender, EventArgs e)
        {
            RecurringEvent myRecurringEvent = new RecurringEvent(ViewREventID, UserId, ViewREventName, ViewREventNote, ViewREventStartDate, ViewREventType, ViewREventContact, viewREventFrequency, ViewREventEndDate);
            this.EventController.DeleteEvent(myRecurringEvent);
            REventListView.Focus();

        }

        private void SubmitReEvent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ViewREventName))
            {
                MessageBox.Show("Please Enter Event Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(viewREventFrequency))
            {
                MessageBox.Show("Please Enter Event Frequency", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ViewREventStartDate.Date < DateTime.Today)
            {
                MessageBox.Show("Please choose a future date", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ViewREventStartDate.Date > ViewREventEndDate)
            {
                MessageBox.Show("Please choose a future date greaater than start date", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RecurringEvent myEvent = new RecurringEvent(ViewREventID, UserId, ViewREventName, ViewREventNote, ViewREventStartDate, ViewREventType, ViewREventContact, viewREventFrequency, ViewREventEndDate);
            this.EventController.AddEvent(myEvent);
            rTransDetailBox.BackColor = System.Drawing.Color.Empty;
            this.EventController.LoadEventView("RecurringEvent");
            REventListView.Enabled = true;
            UpdateReEvent.Visible = true;
            SubmitReEvent.Visible = false;
            DeleteReEvent.Visible = true;
            AddReEvent.Enabled = true;
            CancelREvent.Visible = false;
            REventListView.Focus();
        }
        private void DeleteEvent_Click(object sender, EventArgs e)
        {
            Event myEvent = new Event(ViewEventID, UserId, ViewEventName, ViewEventNote, ViewEventDate, ViewEventType, ViewEventContact);
            this.EventController.DeleteEvent(myEvent);
            EventGridView.Focus();
        }

        internal static void DisposeEventForm()
        {
            try
            {
                EventForm.Dispose();
            }
            catch (Exception)
            {

            }
        }

        private void SubmitEvent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ViewEventName))
            {
                MessageBox.Show("Please Enter Event Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ViewEventDate.Date < DateTime.Today)
            {
                MessageBox.Show("Please choose a future date", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Event myEvent = new Event(ViewEventID, UserId, ViewEventName, ViewEventNote, ViewEventDate, ViewEventType, ViewEventContact);
            this.EventController.AddEvent(myEvent);
            this.transDetailBox.BackColor = System.Drawing.Color.Empty;
            this.EventController.LoadEventView("NormalEvent");
            EventGridView.Enabled = true;
            UpdateEvent.Visible = true;
            SubmitEvent.Visible = false;
            DeleteEvent.Visible = true;
            AddEvent.Enabled = true;
            cancelEvent.Visible = false;
            EventGridView.Focus();
        }

        private void RefreshRView_Click(object sender, EventArgs e)
        {
            RefreshEventView.Text = "Resfreshing....";
            this.EventController.LoadEventView("RecurringEvent");
            ContactRepository contacts = new ContactRepository();
            myContacts = contacts.GetSavedContact(UserId);
            AllEventContact.DataSource = null;
            rEventContactList.DataSource = null;
            this.AllEventContact.DataSource = myContacts;
            this.AllEventContact.DisplayMember = "cName";
            this.rEventContactList.DataSource = myContacts;
            this.rEventContactList.DisplayMember = "cName";
            REventListView.Enabled = true;
            UpdateReEvent.Visible = true;
            SubmitReEvent.Visible = false;
            DeleteReEvent.Visible = true;
            AddReEvent.Enabled = true;
            CancelREvent.Visible = false;
            REventListView.Focus();


        }

        private void cancelEvent_Click(object sender, EventArgs e)
        {
            EventController.LoadEventView("NormalEvent");
            EventGridView.Enabled = true;
            UpdateEvent.Visible = true;
            SubmitEvent.Visible = false;
            DeleteEvent.Visible = true;
            AddEvent.Enabled = true;
            cancelEvent.Visible = false;
            EventGridView.Focus();
        }

        private void CancelREvent_Click(object sender, EventArgs e)
        {
            this.transDetailBox.Text = "Update Event";
            this.transDetailBox.BackColor = System.Drawing.Color.Empty;
            this.EventController.LoadEventView("RecurringEvent");
            REventListView.Enabled = true;
            UpdateReEvent.Visible = true;
            SubmitReEvent.Visible = false;
            DeleteReEvent.Visible = true;
            AddReEvent.Enabled = true;
            CancelREvent.Visible = false;
            REventListView.Focus();
        }
    }
}