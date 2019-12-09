using BudgetManagement.Controllers;
using BudgetManagement.Models;
using BudgetManagement.Repository;
using System;
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
            //this.tContactCombobox.ValueMember = "cID";

        }

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


        private void tContactCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.tcontactTbox.Text = this.tContactCombobox.GetItemText(this.tContactCombobox.SelectedItem); 
            //transactionController.LoadTransactionView();

        }


        public void AddTransactionToGrid(Transaction transaction)
        {
            ListViewItem parent;
            parent = this.transGridView.Items.Add(transaction.transID.ToString());
            parent.SubItems.Add(transaction.transName);
            parent.SubItems.Add(transaction.transAmount.ToString());
            parent.SubItems.Add(transaction.transType);
            ApplyStripeToTransactionGrid();
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
                rowToUpdate.SubItems[3].Text = transaction.transAmount.ToString();
                rowToUpdate.SubItems[2].Text = transaction.transType;
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


        public void SetSelectedTransactionInGrid(Transaction transaction)
        {
            foreach (ListViewItem row in this.transGridView.Items)
            {
                if (row.Text == transaction.transID.ToString())
                {
                    row.Selected = true;
                }
            }
        }


        private void addTBtn_Click(object sender, EventArgs e)
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

        private void transGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.transGridView.SelectedItems.Count > 0)
                this.transactionController.SelectedTransactionChanged(this.transGridView.SelectedItems[0].Text);
        }

        private void cancelTBtn_Click(object sender, EventArgs e)
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
