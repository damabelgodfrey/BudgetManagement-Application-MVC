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
        // ContactRepositoryController contactRepoController;
        public TransactionView()
        {
            InitializeComponent();
            this.tContactCombobox.DataSource = ContactRepository.GetContactList();
            this.tContactCombobox.DisplayMember = "cName";
            this.rTransContactList.DataSource = ContactRepository.GetContactList();
            this.rTransContactList.DisplayMember = "cName";

           // var FrequencyList = new List<ArrayList>();
           // FrequencyList.Add(new ArrayList() { "Daily", "Monthly","Yearly" });
           // rTransFrequencyList.DataSource = FrequencyList;
           // this.rTransFrequencyList.DisplayMember = "cName";
            //this.tContactCombobox.ValueMember = "cID";

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
        public string ViewRTransID
        {
            get { return this.rID.Text; }
            set { this.rID.Text = value; }
        }
        public bool CanModifyRID
        {
            set { this.rID.Enabled = value; }
        }
        public string ViewRTransStartDate
        {
            get { return this.rTransStartPeriod.Text; }
            set { this.rTransStartPeriod.Text = value.ToString(); }
        }
        public string ViewRTransEndDate
        {
            get { return this.rTransEndPeriod.Text; }
            set { this.rTransEndPeriod.Text = value.ToString(); }
        }


        public void ClearRGrid()
        {
            // Define columns and clear item
            this.RTransListView.Columns.Clear();

            this.RTransListView.Columns.Add("ID", 150, HorizontalAlignment.Left);
            this.RTransListView.Columns.Add("Name", 150, HorizontalAlignment.Left);
            this.RTransListView.Columns.Add("AMOUNT", 150, HorizontalAlignment.Left);
            this.RTransListView.Columns.Add("TYPE", 150, HorizontalAlignment.Left);
            this.RTransListView.Items.Clear();
        }
        public string GetIdOfSelectedRTransactionInGrid()
        {
            if (this.RTransListView.SelectedItems.Count > 0)
            {
                return this.RTransListView.SelectedItems[0].Text;

            }
            else
            {
                return "";

            }
        }



        private void AddRTransaction_Click(object sender, EventArgs e)
        {
            this.AddRTransaction.Enabled = false;
            this.DeleteRTransaction.Enabled = false;
            //this.cancelTBtn.Visible = true;
            this.RegisterRTransaction.Text = "Submit";
            this.rTransDetailBox.Text = "Add Recurrent Transaction";
            this.rTransDetailBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#d8dde3");
            this.CancelAddRAction.Visible = true;
            this.transactionController.AddNewRTransaction();

        }

        private void RegisterRTransaction_Click(object sender, EventArgs e)
        {
            this.transactionController.SaveRTransaction();
            this.RegisterRTransaction.Text = "Update Recurring";
            this.AddRTransaction.Enabled = true;
            this.DeleteRTransaction.Enabled = true;
            this.DeleteRTransaction.Visible = true;
            rTransDetailBox.BackColor = System.Drawing.Color.Empty;
            this.transactionController.LoadRTransactionView();

        }
        private void CancelAddRAction_Click(object sender, EventArgs e)
        {
            this.CancelAddRAction.Visible = false;
            this.AddRTransaction.Enabled = true;
            this.DeleteRTransaction.Enabled = true;
            this.RegisterRTransaction.Text = "Update Transaction";
            this.transDetailBox.Text = "Update Transaction";
            this.transDetailBox.BackColor = System.Drawing.Color.Empty;
            this.transactionController.LoadRTransactionView();
        }
        private void DeleteRTransaction_Click(object sender, EventArgs e)
        {
            this.transactionController.RemoveRTransaction();
        }
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
        public string ViewTransID
        {
            get { return this.tIDtbox.Text; }
            set { this.tIDtbox.Text = value; }
        }
        public bool CanModifyID
        {
            set { this.tIDtbox.Enabled = value; }
        }
        public string ViewTransDate
        {
            get { return this.tDatePicker.Text; }
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
                parent = this.RTransListView.Items.Add(rTransaction.transID.ToString());
                parent.SubItems.Add(rTransaction.transName);
                parent.SubItems.Add(rTransaction.transAmount.ToString());
                parent.SubItems.Add(rTransaction.transType);
                //ApplyStripeToTransactionGrid();
            }
            else
            {
                parent = this.transGridView.Items.Add(transaction.transID.ToString());
                parent.SubItems.Add(transaction.transName);
                parent.SubItems.Add(transaction.transAmount.ToString());
                parent.SubItems.Add(transaction.transType);
                ApplyStripeToTransactionGrid();
            }
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

        public void ClearGrid()
        {
            // Define columns and clear item
            this.transGridView.Columns.Clear();
            this.transGridView.Columns.Add("ID", 150, HorizontalAlignment.Left);
            this.transGridView.Columns.Add("Name", 150, HorizontalAlignment.Left);
            this.transGridView.Columns.Add("AMOUNT", 150, HorizontalAlignment.Left);
            this.transGridView.Columns.Add("TYPE", 150, HorizontalAlignment.Left);
            this.transGridView.Items.Clear();
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
                }
            }
        }
        public string GetIdOfSelectedTransactionInGrid()
        {
            if (this.transGridView.SelectedItems.Count > 0)
            {
                return this.transGridView.SelectedItems[0].Text;

            }
            else
            {
                return "";

            }
        }

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
                    ApplyStripeToTransactionGrid();
                    this.transGridView.Focus();
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
                    ApplyStripeToTransactionGrid();
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


        private void AddTBtn_Click(object sender, EventArgs e)
        {
            this.addTBtn.Enabled = false;
            this.DeleteTBtn.Enabled = false;
            this.cancelTBtn.Visible = true;
            this.UpdateTBtn.Text = "Register Contact";
            this.transDetailBox.Text = "Add Contact";
            this.transDetailBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#d8dde3");
            this.transactionController.AddNewTransaction();

        }

        // delete contact
        private void DeleteTBtn_Click(object sender, EventArgs e)
        {
            this.transactionController.RemoveTransaction();

        }

         //call controller to save transaction
        private void UpdateTBtn_Click(object sender, EventArgs e)
        {
            this.transactionController.SaveTransaction();
            this.UpdateTBtn.Text = "Update Contact";
            this.addTBtn.Enabled = true;
            this.DeleteTBtn.Enabled = true;
            this.DeleteTBtn.Visible = true;
            cancelTBtn.Visible = true;
            this.transDetailBox.BackColor = System.Drawing.Color.Empty;
            this.transactionController.LoadTransactionView();

        }
        //apply zebraline to grid
        public void ApplyStripeToTransactionGrid()
        {
            int i = 0;
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
            this.cancelTBtn.Visible = false;
            this.addTBtn.Enabled = true;
            this.DeleteTBtn.Enabled = true;
            this.UpdateTBtn.Text = "Update Transaction";
            this.transDetailBox.Text = "Update Transaction";
            this.transDetailBox.BackColor = System.Drawing.Color.Empty;
            this.transactionController.LoadTransactionView();
        }

      
    }
}
