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
        public EventView()
        {
            InitializeComponent();
            this.AllEventContact.DataSource = ContactRepository.GetContactList();
            this.AllEventContact.DisplayMember = "cName";
            this.rEventContactList.DataSource = ContactRepository.GetContactList();
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
                if (value == "Income")
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
        public string ViewREventID
        {
            get { return this.EID.Text; }
            set { this.EID.Text = value; }
        }
        public bool CanModifyRID
        {
            set { this.EID.Enabled = value; }
        }
        public string ViewREventStartDate
        {
            get { return this.rEventStartPeriod.Text; }
            set { this.rEventStartPeriod.Text = value.ToString(); }
        }
        public string ViewREventEndDate
        {
            get { return this.rEventEndPeriod.Text; }
            set { this.rEventEndPeriod.Text = value.ToString(); }
        }


        public void ClearRGrid()
        {
            // Define columns and clear item
            this.REventListView.Columns.Clear();

            this.REventListView.Columns.Add("ID", 150, HorizontalAlignment.Left);
            this.REventListView.Columns.Add("Name", 150, HorizontalAlignment.Left);
            this.REventListView.Columns.Add("AMOUNT", 150, HorizontalAlignment.Left);
            this.REventListView.Columns.Add("TYPE", 150, HorizontalAlignment.Left);
            this.REventListView.Items.Clear();
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
                if (value == "Income")
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
        public string ViewEventID
        {
            get { return this.EventIDtbox.Text; }
            set { this.EventIDtbox.Text = value; }
        }
        public bool CanModifyID
        {
            set { this.EventIDtbox.Enabled = value; }
        }
        public string ViewEventDate
        {
            get { return this.EventDate.Text; }
            set { this.EventDate.Text = value.ToString(); }
        }


        public void AddEventToGrid(Event Event)
        {
            ListViewItem parent;
            if (Event is RecurringEvent rEvent)
            {
                parent = this.REventListView.Items.Add(rEvent.EventID.ToString());
                parent.SubItems.Add(rEvent.EventName);
                parent.SubItems.Add(rEvent.EventAmount.ToString());
                parent.SubItems.Add(rEvent.EventType);
                //ApplyStripeToEventGrid();
            }
            else
            {
                parent = this.EventGridView.Items.Add(Event.EventID.ToString());
                parent.SubItems.Add(Event.EventName);
                parent.SubItems.Add(Event.EventAmount.ToString());
                parent.SubItems.Add(Event.EventType);
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

        public void ClearGrid()
        {
            // Define columns and clear item
            this.EventGridView.Columns.Clear();
            this.EventGridView.Columns.Add("ID", 150, HorizontalAlignment.Left);
            this.EventGridView.Columns.Add("Name", 150, HorizontalAlignment.Left);
            this.EventGridView.Columns.Add("AMOUNT", 150, HorizontalAlignment.Left);
            this.EventGridView.Columns.Add("TYPE", 150, HorizontalAlignment.Left);
            this.EventGridView.Items.Clear();
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
                    rowToUpdate.SubItems[2].Text = rEvent.EventAmount.ToString();
                    rowToUpdate.SubItems[3].Text = rEvent.EventType;
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
                    rowToUpdate.SubItems[2].Text = Event.EventAmount.ToString();
                    rowToUpdate.SubItems[3].Text = Event.EventType;
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
            this.AddEvent.Enabled = false;
            this.DeleteEvent.Enabled = false;
            this.cancelEvent.Visible = true;
            this.UpdateEvent.Text = "Add Event";
            this.transDetailBox.Text = "Add Event Process";
            this.transDetailBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#d8dde3");
            this.EventController.AddNewEvent();
        }

        private void UpdateEvent_Click(object sender, EventArgs e)
        {
            UpdateEvent.Enabled = false;
            this.UpdateEvent.Text = "Processing....";
            this.EventController.SaveEvent();
            this.AddEvent.Enabled = true;
            this.DeleteEvent.Enabled = true;
            this.DeleteEvent.Visible = true;
            cancelEvent.Visible = true;
            this.transDetailBox.BackColor = System.Drawing.Color.Empty;
            this.EventController.LoadEventView();
            this.UpdateEvent.Text = "Update Event";
            UpdateEvent.Enabled = true;

        }

        private void DeleteEvent_Click(object sender, EventArgs e)
        {
            DeleteEvent.Enabled = false;
            this.EventController.RemoveEvent();
            DeleteEvent.Enabled = true;

        }

        private void cancelEvent_Click(object sender, EventArgs e)
        {
            this.cancelEvent.Visible = false;
            this.AddEvent.Enabled = true;
            this.DeleteEvent.Enabled = true;
            this.UpdateEvent.Text = "Update Event";
            this.transDetailBox.Text = "Update Event";
            this.transDetailBox.BackColor = System.Drawing.Color.Empty;
            this.EventController.LoadEventView();
        }

        private void AddREvent_Click_1(object sender, EventArgs e)
        {
            this.AddREvent.Enabled = false;
            this.DeleteREvent.Enabled = false;
            //this.cancelTBtn.Visible = true;
            this.RegisterREvent.Text = "Submit";
            this.rTransDetailBox.Text = "Add Recurrent Event";
            this.rTransDetailBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#d8dde3");
            this.CancelAddRAction.Visible = true;
            this.EventController.AddNewREvent();
        }

        private void RegisterREvent_Click(object sender, EventArgs e)
        {

            RegisterREvent.Enabled = false;
            this.EventController.SaveREvent();
            this.RegisterREvent.Text = "Update Recurring";
            this.AddREvent.Enabled = true;
            this.DeleteREvent.Enabled = true;
            this.DeleteREvent.Visible = true;
            rTransDetailBox.BackColor = System.Drawing.Color.Empty;
            this.EventController.LoadREventView();
            RegisterREvent.Enabled = true;

        }

        private void CancelAddRAction_Click_1(object sender, EventArgs e)
        {
            this.CancelAddRAction.Visible = false;
            this.AddREvent.Enabled = true;
            this.DeleteREvent.Enabled = true;
            this.RegisterREvent.Text = "Update Event";
            this.transDetailBox.Text = "Update Event";
            this.transDetailBox.BackColor = System.Drawing.Color.Empty;
            this.EventController.LoadREventView();
        }

        private void DeleteREvent_Click_1(object sender, EventArgs e)
        {
            this.EventController.RemoveREvent();
        }

        private void REventListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.REventListView.SelectedItems.Count > 0)
                this.EventController.SelectedREventChanged(this.REventListView.SelectedItems[0].Text);
        }

        private void rEventContactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rEventContact.Text = this.rEventFrequencyList.GetItemText(this.rEventFrequencyList.SelectedItem);
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
            RefreshEventView.Enabled = false;
            RefreshEventView.Text = "Resfreshing....";
            this.EventController.LoadEventView();
            RefreshEventView.Enabled = true;
            RefreshEventView.Text = "Resfresh View";

        }

        private void RefreshEView_Click(object sender, EventArgs e)
        {
            RefreshEView.Enabled = false;
            RefreshEView.Text = "Resfreshing....";
            this.EventController.LoadREventView();
            RefreshEView.Enabled = true;
            RefreshEView.Text = "Resfresh View";
        }
    }
}