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
    public partial class ReportView : Form, IReportView
    {
        ReportController reportController;
        private static ReportView ReportForm;
        private static readonly object ReportPadlock = new object();
        int sn = 1;
        double ReportTotalIncome = 0;
        double ReportTotalExpense = 0;
        int AllContactFlag = 0;
        public ReportView()
        {
            InitializeComponent();
            List<Contact> contacts =ContactRepository.GetContactList();
            if(AllContactFlag == 0)
            {
                Contact contact = new Contact(0, 1, "All", " ", " ");
                contacts.Insert(0, contact);
                AllContactFlag = 1;
            }
            this.rContactCombobox.DataSource = contacts;
            this.rContactCombobox.DisplayMember = "cName";
        }

        public void ClearGrid()
        {
            // Define columns and clear item
            this.ReportViewGrid.Columns.Clear();

            this.ReportViewGrid.Columns.Add("S/N", 150, HorizontalAlignment.Left);
            this.ReportViewGrid.Columns.Add("Name", 150, HorizontalAlignment.Left);
            this.ReportViewGrid.Columns.Add("Income", 150, HorizontalAlignment.Left);
            this.ReportViewGrid.Columns.Add("Expense", 150, HorizontalAlignment.Left);
            this.ReportViewGrid.Columns.Add("AMOUNT", 150, HorizontalAlignment.Left);
            this.ReportViewGrid.Items.Clear();
        }



        //transaction
        public string AllContactName
        {
            get { return this.rContactCombobox.DisplayMember; }

        }
        public string ViewTransName
        {
            get { return this.rNameTbox.Text; }

            set
            {
                this.rNameTbox.Text = value;
            }
        }

        public string ViewTransContact
        {
            get { return this.rcontactTbox.Text; }
            set { this.rcontactTbox.Text = value; }
        }
        public string ViewTransDate
        {
            get { return this.StartTime.Text; }
            set { this.StartTime.Text = value.ToString(); }
        }
        public string ViewEndDate
        {
            get { return this.rEndDate.Text; }
            set { this.rEndDate.Text = value.ToString(); }
        }

        private void TContactCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.rcontactTbox.Text = this.rContactCombobox.GetItemText(this.rContactCombobox.SelectedItem);
            //transactionController.LoadTransactionView();

        }

        public void AddTransactionToGrid(Transaction transaction)
        {
            ListViewItem parent;

            parent = this.ReportViewGrid.Items.Add(sn.ToString());
            parent.SubItems.Add(transaction.transName);

            if (transaction.transType == "Income") { 
                parent.SubItems.Add(transaction.transType);
            }
            else
            {
                parent.SubItems.Add("");

            }
            if (transaction.transType == "Expenses")
            {
                parent.SubItems.Add(transaction.transType);
            }
            else
            {
                parent.SubItems.Add("");

            }
            parent.SubItems.Add(transaction.transAmount.ToString());
            if (transaction.transType == "Expenses")
            {
                ReportTotalExpense = ReportTotalExpense + transaction.transAmount;

            }
            if (transaction.transType == "Income")
            {
                ReportTotalIncome = ReportTotalIncome + transaction.transAmount;

            }
            totalIncome.Text = ReportTotalIncome.ToString();
            totalExpenses.Text = ReportTotalExpense.ToString();
            sn++;
              // ApplyStripeToTransactionGrid();
        }

        internal static ReportView GetReportForm()
        {
            lock (ReportPadlock)
            {
                if (ReportForm == null || ReportForm.IsDisposed)
                {
                    ReportForm = new ReportView();

                }
                return ReportForm;
            }
        }

        public void UpdateGridWithChangedTransaction(Transaction transaction)
        {
            ListViewItem rowToUpdate = null;
                foreach (ListViewItem row in this.ReportViewGrid.Items)
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
                    rowToUpdate.SubItems[3].Text = transaction.transType;
                rowToUpdate.SubItems[2].Text = transaction.transAmount.ToString();

            }
        }

        public void SetSelectedTransactionInGrid(Transaction transaction)
        {

                foreach (ListViewItem row in this.ReportViewGrid.Items)
                {
                    if (row.Text == transaction.transID.ToString())
                    {
                        row.Selected = true;
                    }
            }
        }

        //call controller to save transaction
        //apply zebraline to grid
        public void ApplyStripeToTransactionGrid()
        {
            int i = 0;
            ReportViewGrid.BackColor = Color.FromArgb(255, 255, 255);
            foreach (ListViewItem row in this.ReportViewGrid.Items)
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

        public void SetReportController(ReportController controller)
        {
            reportController = controller;

        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            sn = 1;
            ReportTotalIncome = 0;
             ReportTotalExpense = 0;
            int start = DateTime.Compare(Convert.ToDateTime(ViewEndDate), Convert.ToDateTime(ViewTransDate));
            if (string.IsNullOrWhiteSpace(ViewTransName))
            {
                ViewTransName = "All";
                MessageBox.Show("Please enter Transaction Name or keep All", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if(string.IsNullOrWhiteSpace(ViewTransContact))
            {
                ViewTransContact = "All";
                MessageBox.Show("Please enter contact or keep All", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else if (start ==-1)
            {
                MessageBox.Show("Start date must be less than end date", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                GenerateReport.Enabled = false;
                GenerateReport.Text = "Fetching Report";

                //this.transDetailBox.BackColor = System.Drawing.Color.Empty;
                reportController.RequestReport(Convert.ToDateTime(ViewTransDate), Convert.ToDateTime(ViewEndDate), ViewTransName, ViewTransContact);
                GenerateReport.Enabled = true;
                GenerateReport.Text = "Generate Report";


                try
                {
                    totalIncome.Text = ReportTotalIncome.ToString();
                    totalExpenses.Text = ReportTotalExpense.ToString();

                }
                catch (Exception)
                {

                    
                }
                // this.reportController.LoadReportView();
                //this.transDetailBox.BackColor = System.Drawing.Color.Empty;

            }

        }

    }
}