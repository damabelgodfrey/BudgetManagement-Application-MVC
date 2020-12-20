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
    public partial class TransactionView : Form, ITransactionView
    {
        TransactionController transactionController;
        private static TransactionView TransactionForm;
        private static readonly object TransactionPadlock = new object();
        int UserId = TransactionController.GetUserID();
        List<Contact> myContacts;

        // ContactRepositoryController contactRepoController;
        public TransactionView()
        {
            InitializeComponent();
            ContactRepository contacts = new ContactRepository();
            myContacts = contacts.GetSavedContact(UserId);
            this.tContactCombobox.DataSource = myContacts;
            this.tContactCombobox.DisplayMember = "cName";
            this.rTransContactList.DataSource = myContacts;
            this.rTransContactList.DisplayMember = "cName";
        }

        // for recurent Transaction
        public string viewRTransFrequency
        {
            get { return this.rTransFrequency.Text; }
            set { this.rTransFrequency.Text = value; }

        }
        public string AllRContactName
        {
            get { return this.rTransContactList.DisplayMember; }

        }
        public string AllRFrequency
        {
            get { return this.rTransFrequencyList.DisplayMember; }

        }
        public string ViewRTransName
        {
            get { return this.rTransName.Text; }

            set
            {
                this.rTransName.Text = value;
            }
        }

        public string ViewRTransType
        {
            get
            {
                if (this.rExpense.Checked)
                    return this.rExpense.Text;
                else
                    return this.rIncome.Text;
            }
            set
            {
                if (value == "Income")
                    this.rIncome.Checked = true;
                else
                    this.rExpense.Checked = true;
            }

        }

        public double ViewRTransAmount
        {
            get { return Convert.ToDouble(this.rTransAmount.Text); }
            set { (this.rTransAmount.Text) = value.ToString(); }
        }

        public string ViewRTransContact
        {
            get { return this.rTransContact.Text; }
            set { this.rTransContact.Text = value; }
        }
        public string ViewRTransNote
        {
            get { return this.rTransNote.Text; }
            set { this.rTransNote.Text = value; }
        }
        public int ViewRTransID
        {
            get { return Convert.ToInt32(this.rID.Text); }
            set { this.rID.Text = value.ToString(); }
        }

        public DateTime ViewRTransStartDate
        {
            get { return Convert.ToDateTime(this.rTransStartPeriod.Text); }
            set { this.rTransStartPeriod.Text = value.ToString(); }
        }
        public DateTime ViewRTransEndDate
        {
            get { return Convert.ToDateTime(this.rTransEndPeriod.Text); }
            set { this.rTransEndPeriod.Text = value.ToString(); }
        }


        public void ClearGrid(String typeflag)
        {
            // Define columns and clear item

            if (typeflag == "RecurringTrans")
            {
                this.RTransListView.Columns.Clear();
                this.RTransListView.Columns.Add("ID", 150, HorizontalAlignment.Left);
                this.RTransListView.Columns.Add("Name", 150, HorizontalAlignment.Left);
                this.RTransListView.Columns.Add("AMOUNT", 150, HorizontalAlignment.Left);
                this.RTransListView.Columns.Add("TYPE", 150, HorizontalAlignment.Left);
                this.RTransListView.Columns.Add("Dates", 250, HorizontalAlignment.Left);
                this.RTransListView.Items.Clear();
            }
            else
            {
                this.transGridView.Columns.Clear();
                this.transGridView.Columns.Add("ID", 150, HorizontalAlignment.Left);
                this.transGridView.Columns.Add("Name", 150, HorizontalAlignment.Left);
                this.transGridView.Columns.Add("AMOUNT", 150, HorizontalAlignment.Left);
                this.transGridView.Columns.Add("TYPE", 150, HorizontalAlignment.Left);
                this.transGridView.Columns.Add("Date", 200, HorizontalAlignment.Left);
                this.transGridView.Items.Clear();
            }
        }
        //public string GetIdOfSelectedRTransactionInGrid()
        //{
        //    if (this.RTransListView.SelectedItems.Count > 0)
        //    {
        //        return this.RTransListView.SelectedItems[0].Text;

        //    }
        //    else
        //    {
        //        return "";

        //    }
        //}


        private void RTransListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.RTransListView.SelectedItems.Count > 0)
                this.transactionController.SelectedRTransactionChanged(this.RTransListView.SelectedItems[0].Text);
        }
        private void rTransFrequencyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rTransFrequency.Text = this.rTransFrequencyList.GetItemText(this.rTransFrequencyList.SelectedItem);

        }

        private void rTransContactList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rTransContact.Text = this.rTransContactList.GetItemText(this.rTransContactList.SelectedItem);

        }
        //transaction
        public string AllContactName
        {
            get { return this.tContactCombobox.DisplayMember; }

        }
        public string ViewTransName
        {
            get { return this.tNameTbox.Text; }

            set {
                this.tNameTbox.Text = value; }
        }
        
        public string ViewTransType
        {
            get
            {
                if (this.incomeTRbtn.Checked)
                    return this.incomeTRbtn.Text;
                else
                    return this.expenseTRbtn.Text;
            }
            set
            {
                if (value == "Income")
                    this.incomeTRbtn.Checked = true;
                else
                    this.expenseTRbtn.Checked = true;
            }

        }
        
        public double ViewTransAmount
        {
        get { return Convert.ToDouble(this.tAmountTbox.Text); }
        set { (this.tAmountTbox.Text) = value.ToString(); }
        }

        public string ViewTransContact
        {
            get { return this.tcontactTbox.Text; }
            set { this.tcontactTbox.Text = value; }
        }
        public string ViewTransNote
        {
            get { return this.tNoteTbox.Text; }
            set { this.tNoteTbox.Text = value; }
        }
        public int ViewTransID
        {
            get { return Convert.ToInt32(this.tIDtbox.Text); }
            set { this.tIDtbox.Text = value.ToString(); }
        }
        public DateTime ViewTransDate
        {
            get { return Convert.ToDateTime(this.tDatePicker.Text); }
            set { this.tDatePicker.Text = value.ToString(); }
        }

        private void TContactCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tcontactTbox.Text = this.tContactCombobox.GetItemText(this.tContactCombobox.SelectedItem); 
            //transactionController.LoadTransactionView();

        }

        public void AddTransactionToGrid(Transaction transaction)
        {
            ListViewItem parent;
            if (transaction is RecurringTransaction rTransaction)
            {
               // parent = this.RTransListView.Items.Add(rTransaction.transID.ToString());
                parent = this.RTransListView.Items.Add(rTransaction.transID.ToString());

                parent.SubItems.Add(rTransaction.transName);
                parent.SubItems.Add(rTransaction.transAmount.ToString());
                parent.SubItems.Add(rTransaction.transType);
                parent.SubItems.Add(rTransaction.TransDate.Date.ToShortDateString ()+ " - " + rTransaction.transEndDate.Date.ToShortDateString());

            }
            else
            {
                parent = this.transGridView.Items.Add(transaction.transID.ToString());
                parent.SubItems.Add(transaction.transName);
                parent.SubItems.Add(transaction.transAmount.ToString());
                parent.SubItems.Add(transaction.transType);
                parent.SubItems.Add(transaction.TransDate.Date.ToShortDateString());

            }
            ApplyStripeToTransactionGrid(transaction);
        }

        internal static TransactionView GetTransactionForm()
        {
            lock (TransactionPadlock)
            {
                if (TransactionForm == null || TransactionForm.IsDisposed)
                {
                    TransactionForm = new TransactionView();
                }
                return TransactionForm;
            }
        }

        internal static void DisposeTransactionForm()
        {
            try
            {
                TransactionForm.Dispose();
            }
            catch (Exception)
            {
            }
            return;
        }


        public void UpdateGridWithChangedTransaction(Transaction transaction)
        {
            ListViewItem rowToUpdate = null;
            if (transaction is RecurringTransaction rTransaction)
            {
                foreach (ListViewItem row in this.RTransListView.Items)
                {
                    if (row.Text == rTransaction.transID.ToString())
                    {
                        rowToUpdate = row;

                    }
                }

                if (rowToUpdate != null)
                {
                    rowToUpdate.Text = rTransaction.transID.ToString();
                    rowToUpdate.SubItems[1].Text = rTransaction.transName;
                    rowToUpdate.SubItems[2].Text = rTransaction.transAmount.ToString();
                    rowToUpdate.SubItems[3].Text = rTransaction.transType;
                    rowToUpdate.SubItems[4].Text = rTransaction.TransDate.ToShortDateString() + " - " + rTransaction.transEndDate.ToShortDateString();

                    RTransListView.Select();
                    RTransListView.MultiSelect = false;
                    rowToUpdate.Selected = true;
                    RTransListView.MultiSelect = true;
                }
            }
            else
            {
                foreach (ListViewItem row in this.transGridView.Items)
                {
                    if (row.Text == transaction.transID.ToString())
                    {
                        rowToUpdate = row;
                    }
                }

                if (rowToUpdate != null)
                {
                    rowToUpdate.Text = transaction.transID.ToString();
                    rowToUpdate.SubItems[1].Text = transaction.transName;
                    rowToUpdate.SubItems[2].Text = transaction.transAmount.ToString();
                    rowToUpdate.SubItems[3].Text = transaction.transType;
                    rowToUpdate.SubItems[4].Text = transaction.TransDate.ToShortDateString();

                    transGridView.Select();
                    transGridView.MultiSelect = false;
                    rowToUpdate.Selected = true;
                    transGridView.MultiSelect = true;


                }
            }
        }
        //public string GetIdOfSelectedTransactionInGrid()
        //{
        //    if (this.transGridView.SelectedItems.Count > 0)
        //    {
        //        return this.transGridView.SelectedItems[0].Text;

        //    }
        //    else
        //    {
        //        return "";

        //    }
        //}

        public void RemoveTransactionFromGrid(Transaction transaction)
        {

            ListViewItem rowToRemove = null;
            if (transaction is RecurringTransaction)
            { 
                RecurringTransaction rTransaction = (RecurringTransaction)transaction;
                foreach (ListViewItem row in this.RTransListView.Items)
                {
                    if (row.Text == rTransaction.transID.ToString())
                    {
                        rowToRemove = row;
                    }
                }

                if (rowToRemove != null)
                {
                    this.RTransListView.Items.Remove(rowToRemove);
                    ApplyStripeToTransactionGrid(transaction);
                    this.RTransListView.Focus();
                }
            } else {
                foreach (ListViewItem row in this.transGridView.Items)
                {
                    if (row.Text == transaction.transID.ToString())
                    {
                        rowToRemove = row;
                    }
                }

                if (rowToRemove != null)
                {
                    this.transGridView.Items.Remove(rowToRemove);
                    ApplyStripeToTransactionGrid(transaction);
                    this.transGridView.Focus();
                }
            }

           
        }


        public void SetSelectedTransactionInGrid(Transaction transaction)
        {

            if (transaction is RecurringTransaction)
            {
                RecurringTransaction rTransaction = (RecurringTransaction)transaction;

                foreach (ListViewItem row in this.RTransListView.Items)
                {
                    if (row.Text == rTransaction.transID.ToString())
                    {
                        row.Selected = true;
                    }
                }
            }
            else
            {
                foreach (ListViewItem row in this.transGridView.Items)
                {
                    if (row.Text == transaction.transID.ToString())
                    {
                        row.Selected = true;
                    }
                }
            }
        }

        //add transaction
        private void adTBtn_Click(object sender, EventArgs e)
        {

           
            this.transDetailBox.Text = "Adding Transaction...";
            this.transDetailBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#d8dde3");
            this.transactionController.AddNewTransaction("NormalTrans");
            transGridView.Enabled = false;
            UpdateTBtn.Visible = false;
            DeleteTBtn.Visible = false;
            addTBtn.Enabled = false;
            cancelTBtn.Visible = true;
            SubmitTrans.Visible = true;


        }
        // delete transaction
        private void DeleteTBtn_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(ViewTransID, UserId, ViewTransName, ViewTransNote, Convert.ToDateTime(ViewTransDate), ViewTransAmount, ViewTransType, ViewTransContact);
            transactionController.DeleteTransaction(transaction);
        }
        //call controller to save transaction
        private void UpdateTBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ViewTransName))
            {
                MessageBox.Show("Please Enter Transaction Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ViewTransAmount <= 0)
            {
                MessageBox.Show("Please Enter Transaction Amount above zero", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Transaction transaction = new Transaction(ViewTransID, UserId, ViewTransName, ViewTransNote, Convert.ToDateTime(ViewTransDate), ViewTransAmount, ViewTransType, ViewTransContact);
            this.transactionController.UpdateTransaction(transaction);
            this.transDetailBox.BackColor = System.Drawing.Color.Empty;
            this.transactionController.LoadTransactionView("NormalTrans");
        }
        //apply zebraline to grid
        public void ApplyStripeToTransactionGrid(Transaction trans)
        {
            int i = 0;
            if (trans is RecurringTransaction)
            {
                RTransListView.BackColor = Color.FromArgb(255, 255, 255);
                foreach (ListViewItem row in this.RTransListView.Items)
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
            else
            {
                transGridView.BackColor = Color.FromArgb(255, 255, 255);
                foreach (ListViewItem row in this.transGridView.Items)
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
        }

        public void SetTransactionController(TransactionController controller)
        {
            transactionController = controller;

        }

        private void TransGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.transGridView.SelectedItems.Count > 0)
                this.transactionController.SelectedTransactionChanged(this.transGridView.SelectedItems[0].Text);
        }

        private void CancelTBtn_Click(object sender, EventArgs e)
        {
            transGridView.Enabled = true;
            UpdateTBtn.Visible = true;
            SubmitTrans.Visible = false;
            DeleteTBtn.Visible = true;
            addTBtn.Enabled = true;
            cancelTBtn.Visible = false;
            this.transDetailBox.Text = "Transaction Details";
            this.transDetailBox.BackColor = System.Drawing.Color.Empty;
            this.transactionController.LoadTransactionView("NormalTrans");
            transGridView.Focus();
        }
        private void SubmitTrans_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ViewTransName))
            {
                MessageBox.Show("Please Enter Transaction Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ViewTransAmount <= 0)
            {
                MessageBox.Show("Zero transaction amount not accepted. Please Enter Amount amount.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int UserId = TransactionController.GetUserID();
            Transaction transaction = new Transaction(0, UserId, ViewTransName, ViewTransNote, Convert.ToDateTime(ViewTransDate), ViewTransAmount, ViewTransType, ViewTransContact);
            this.transactionController.AddTransaction(transaction);
           // this.transactionController.LoadTransactionView("NormalTrans");
            this.transDetailBox.Text = "Transaction Details";
            transGridView.Enabled = true;
            UpdateTBtn.Visible = true;
            SubmitTrans.Visible = false;
            DeleteTBtn.Visible = true;
            addTBtn.Enabled = true;
            cancelTBtn.Visible = false;
            transGridView.Focus();
        }

        //update Recurring Transaction
        private void UpdateRecurring_Click(object sender, EventArgs e)
        {
            string checkName = rTransName.Text;
            if (string.IsNullOrWhiteSpace(checkName))
            {
                MessageBox.Show("Please Enter Transaction Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SubmitRTransaction.Enabled = false;
            RecurringTransaction transaction = new RecurringTransaction(ViewRTransID, UserId, ViewRTransName, ViewRTransNote, Convert.ToDateTime(ViewRTransStartDate), ViewRTransAmount, ViewRTransType, ViewRTransContact, viewRTransFrequency, ViewRTransEndDate);
            this.transactionController.UpdateTransaction(transaction);
            this.AddRTransaction.Enabled = true;
            this.DeleteRTransaction.Enabled = true;
            this.DeleteRTransaction.Visible = true;
            rTransDetailBox.BackColor = System.Drawing.Color.Empty;
            SubmitRTransaction.Enabled = true;
        }

        private void DeleteRTransaction_Click_1(object sender, EventArgs e)
        {
            RecurringTransaction rTransaction = new RecurringTransaction(ViewRTransID, UserId, ViewRTransName, ViewRTransNote, Convert.ToDateTime(ViewRTransStartDate), ViewRTransAmount, ViewRTransType, ViewRTransContact, viewRTransFrequency, ViewRTransEndDate);
            this.transactionController.DeleteTransaction(rTransaction);
            this.transactionController.LoadTransactionView("Recurring");
        }

        private void CancelRTransaction_Click(object sender, EventArgs e)
        {
            this.transDetailBox.Text = "Update Transaction";
            this.transDetailBox.BackColor = System.Drawing.Color.Empty;
            this.transactionController.LoadTransactionView("RecurringTrans");
            RTransListView.Enabled = true;
            UpdateRTransaction.Visible = true;
            SubmitRTransaction.Visible = false;
            DeleteRTransaction.Visible = true;
            AddRTransaction.Enabled = true;
            CancelRTransaction.Visible = false;
            RTransListView.Focus();
        }

        private void AddRTransaction_Click_1(object sender, EventArgs e)
        {
            this.rTransDetailBox.Text = "Add Recurrent Transaction";
            this.rTransDetailBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#d8dde3");
            this.transactionController.AddNewTransaction("RecurringTrans");
            RTransListView.Enabled = false;
            UpdateRTransaction.Visible = false;
            DeleteRTransaction.Visible = false;
            AddRTransaction.Enabled = false;
            CancelRTransaction.Visible = true;
            SubmitRTransaction.Visible = true;

        }

        private void RegisterRTransaction_Click_1(object sender, EventArgs e)
        {
             if (string.IsNullOrWhiteSpace(ViewRTransName))
            {
                MessageBox.Show("Please Enter Transaction Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(viewRTransFrequency))
            {
                MessageBox.Show("Please Enter Occurance Frequency from dropdown provided", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ViewRTransAmount <= 0)
            {
                MessageBox.Show("Zero transaction amount not accepted. Please Enter Amount amount.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RecurringTransaction transaction = new RecurringTransaction(ViewRTransID, UserId, ViewRTransName, ViewRTransNote, Convert.ToDateTime(ViewRTransStartDate), ViewRTransAmount, ViewRTransType, ViewRTransContact, viewRTransFrequency, ViewRTransEndDate);
            this.transactionController.AddTransaction(transaction);
            rTransDetailBox.BackColor = System.Drawing.Color.Empty;
            this.transactionController.LoadTransactionView("recurringTrans");
            RTransListView.Enabled = true;
            UpdateRTransaction.Visible = true;
            SubmitRTransaction.Visible = false;
            DeleteRTransaction.Visible = true;
            AddRTransaction.Enabled = true;
            CancelRTransaction.Visible = false;
            RTransListView.Focus();
        }
        private void Refresh_Click(object sender, EventArgs e)
        {
            ContactRepository contacts = new ContactRepository();
            myContacts = contacts.GetSavedContact(UserId);
            tContactCombobox.DataSource = null;
            tContactCombobox.DataSource = myContacts;
            tContactCombobox.DisplayMember = "cName";
            rTransContactList.DataSource = null;
            rTransContactList.DataSource = myContacts;
            rTransContactList.DisplayMember = "cName";
            this.transactionController.LoadTransactionView("NormalTrans");
        }

        private void RefreshView_Click(object sender, EventArgs e)
        {
            ContactRepository contacts = new ContactRepository();
            myContacts = contacts.GetSavedContact(UserId);
            tContactCombobox.DataSource = null;
            tContactCombobox.DataSource = myContacts;
            tContactCombobox.DisplayMember = "cName";
            rTransContactList.DataSource = null;
            rTransContactList.DataSource = myContacts;
            rTransContactList.DisplayMember = "cName";
            transGridView.Enabled = true;
            UpdateTBtn.Visible = true;
            SubmitTrans.Visible = false;
            DeleteTBtn.Visible = true;
            addTBtn.Enabled = true;
            cancelTBtn.Visible = false;
            this.transDetailBox.BackColor = System.Drawing.Color.Empty;
            this.transactionController.LoadTransactionView("NormalTrans");
            transGridView.Focus();
        }

        private void RefreshRView_Click(object sender, EventArgs e)
        {
            ContactRepository contacts = new ContactRepository();
            myContacts = contacts.GetSavedContact(UserId);
            tContactCombobox.DataSource = null;
            tContactCombobox.DataSource = myContacts;
            tContactCombobox.DisplayMember = "cName";
            rTransContactList.DataSource = null;
            rTransContactList.DataSource = myContacts;
            rTransContactList.DisplayMember = "cName";
            this.transactionController.LoadTransactionView("RecurringTrans");
            RTransListView.Enabled = true;
            UpdateRTransaction.Visible = true;
            SubmitRTransaction.Visible = false;
            DeleteRTransaction.Visible = true;
            AddRTransaction.Enabled = true;
            CancelRTransaction.Visible = false;
            RTransListView.Focus();
        }
    }
}
