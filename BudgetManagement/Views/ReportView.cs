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
using System.Windows.Forms.DataVisualization.Charting;

namespace BudgetManagement.Views
{
    public partial class ReportView : Form, IReportView
    {
        ReportController reportController;
        private static ReportView ReportFormInstance;
        private static readonly object ReportPadlock = new object();
        private static double ReportTotalIncome;
        private static double ReportTotalExpense;

        public ReportView()
        {
            InitializeComponent();
            this.rContactCombobox.DataSource = ContactRepository.GetContactList();
            this.rContactCombobox.DisplayMember = "cName";
            rcontactTbox.Text = "All";
            ReportViewGrid.HideSelection = true;
            int chosenTime = DateTime.Now.Year;
            try
            {
                PlotMonthlyGraph(chosenTime);

            }
            catch (Exception )
            {

            }

        }
        internal static ReportView GetSetReportFormInstance()
        {
            lock (ReportPadlock)
            {
                ReportTotalIncome = 0;
                ReportTotalExpense = 0;
                if (ReportFormInstance == null || ReportFormInstance.IsDisposed)
                {
                    ReportController.SetNewViewObjFlag(true);
                    ReportFormInstance = new ReportView();
                }
                else
                {
                    ReportController.SetNewViewObjFlag(false);
                }

                return ReportFormInstance;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            e.Cancel = true;
            ReportFormInstance.Hide();
        }
        public void ClearGrid()
        {
            // Define columns and clear item
            this.ReportViewGrid.Columns.Clear();

            this.ReportViewGrid.Columns.Add("S/N", 80, HorizontalAlignment.Left);
            this.ReportViewGrid.Columns.Add("Name", 150, HorizontalAlignment.Left);
            this.ReportViewGrid.Columns.Add("Income", 100, HorizontalAlignment.Left);
            this.ReportViewGrid.Columns.Add("Expense", 100, HorizontalAlignment.Left);
            this.ReportViewGrid.Columns.Add("AMOUNT", 150, HorizontalAlignment.Left);
            this.ReportViewGrid.Columns.Add("Date", 150, HorizontalAlignment.Left);

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

        public void AddTransactionToGrid(Transaction transaction,int sn)
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
            if (transaction.transType == "Expense")
            {
                parent.SubItems.Add(transaction.transType);
            }
            else
            {
                parent.SubItems.Add("");

            }
            parent.SubItems.Add(transaction.transAmount.ToString());
            if (transaction.transType == "Expense")
            {
                ReportTotalExpense = ReportTotalExpense + transaction.transAmount;

            }
            if (transaction.transType == "Income")
            {
                ReportTotalIncome = ReportTotalIncome + transaction.transAmount;

            }
            parent.SubItems.Add(transaction.TransDate.ToString("dd/MM/yyyy").ToString());

            totalIncome.Text = ReportTotalIncome.ToString();
            totalExpenses.Text = ReportTotalExpense.ToString();
            ReportDiff.Text = "Diff:  £" + (ReportTotalIncome - ReportTotalExpense).ToString();
            ReportPeriod.Text =DateTime.Now.ToString("MMM") + " , "+ DateTime.Now.Year.ToString();
            // ApplyStripeToTransactionGrid();
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
        public void SetReportController(ReportController controller)
        {
            reportController = controller;

        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            ReportTotalIncome = 0;
            ReportTotalExpense = 0;
            int start = DateTime.Compare(Convert.ToDateTime(ViewEndDate), Convert.ToDateTime(ViewTransDate));
            if (string.IsNullOrWhiteSpace(ViewTransName))
            {
                ViewTransName = "All";
                MessageBox.Show("Please enter Transaction Name or keep All", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(ViewTransContact))
            {
                ViewTransContact = "All";
                MessageBox.Show("Please enter contact or keep All", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else if (start == -1)
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
                    ReportPeriod.Text = ViewTransDate + " - " + ViewEndDate;
                    TName.Text = ViewTransName;
                    TContact.Text = ViewTransContact;
                    totalIncome.Text = ReportTotalIncome.ToString();
                    totalExpenses.Text = ReportTotalExpense.ToString();
                    ReportDiff.Text = "Diff:  £" + (ReportTotalIncome - ReportTotalExpense).ToString();

                }
                catch (Exception)
                {


                }
                // this.reportController.LoadReportView();
                //this.transDetailBox.BackColor = System.Drawing.Color.Empty;

            }

        }

        private void AllName_CheckedChanged(object sender, EventArgs e)
        {

            if (this.AllName.Checked) { 
                this.rNameTbox.Text = "All";
            rNameTbox.Enabled = false;

         } else{
            rNameTbox.Text ="";
            rNameTbox.Enabled = true;
            }
        }

        private void AllContact_CheckedChanged(object sender, EventArgs e)
        {
            if (this.AllContact.Checked)
            {
                this.rcontactTbox.Text = "All";
                rcontactTbox.Enabled = false;
                rContactCombobox.Enabled = false;

            }
            else
            {
                rcontactTbox.Text = "";
                rcontactTbox.Enabled = true;
                rContactCombobox.Enabled = true;

            }



        }

        internal static void DisposeReportForm()
        {
            try
            {
                ReportFormInstance.Dispose();
            }
            catch (Exception)
            {
            }
            
        }
        string[] seriesArray = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" };
        private void PlotMonthlyGraph(int year)
        {
            Dictionary<int,double> IncomeTotalCollection =  ReportController.GetCalIncomeGraphValue(year);
            Dictionary<int, double> ExpenseTotalCollection = ReportController.GetCalExpenseGraphValue(year);
            chart1.Series.Clear();
            IncomeBarChart.Series.Clear();
            IncomeLineChart.Series.Clear();
            ExpenseBarChart.Series.Clear();
            ExpenseLineChart.Series.Clear();
            TransactionReportMsg.Visible = false;
            IncomeTotalMsg.Visible = false;
            ExpenseTotalMsg.Visible = false;
            double[] pointsTotalIncome = new double[12];
            double[] pointsTotalExpense = new double[12];
            try
            {
                for (int Index = 0; Index < 12; Index++)
                {
                    pointsTotalIncome[Index] = IncomeTotalCollection[Index];
                    pointsTotalExpense[Index] = ExpenseTotalCollection[Index];
                }
                double totalIncome= pointsTotalIncome.Sum();
                double totalExpense = pointsTotalExpense.Sum();
                this.chart1.Palette = ChartColorPalette.SeaGreen;
               
                this.IncomeBarChart.Palette = ChartColorPalette.SeaGreen;
                this.IncomeLineChart.Palette = ChartColorPalette.SeaGreen;
               
                
                
                this.ExpenseBarChart.Palette = ChartColorPalette.SeaGreen;
                this.ExpenseLineChart.Palette = ChartColorPalette.SeaGreen;

                Series series = new Series("Expense");
                var series2 = new Series("Income");
                
                var IncomeSeries = new Series("Income");
                var IncomeSeries2 = new Series("Income");
                var ExpenseSeries = new Series("Expense");
                var ExpenseSeries2 = new Series("Expense");

                series2.Points.DataBindXY(seriesArray, pointsTotalIncome);
                series.Points.DataBindXY(seriesArray, pointsTotalExpense);
                IncomeSeries.Points.DataBindXY(seriesArray, pointsTotalIncome);
                IncomeSeries2.Points.DataBindXY(seriesArray, pointsTotalIncome);
                ExpenseSeries.Points.DataBindXY(seriesArray, pointsTotalExpense);
                ExpenseSeries2.Points.DataBindXY(seriesArray, pointsTotalExpense);
                chart1.Series.Add(series2);
                chart1.Series.Add(series);
                IncomeLineChart.Series.Add(IncomeSeries);
                IncomeBarChart.Series.Add(IncomeSeries2);
                ExpenseLineChart.Series.Add(ExpenseSeries);
                ExpenseBarChart.Series.Add(ExpenseSeries2);

                series.ChartType = SeriesChartType.Spline;
                series2.ChartType = SeriesChartType.Spline;
                IncomeSeries.ChartType = SeriesChartType.SplineArea;
                IncomeSeries2.ChartType = SeriesChartType.Bar;
                ExpenseSeries.ChartType = SeriesChartType.SplineArea;
                ExpenseSeries2.ChartType = SeriesChartType.Bar;

                if(totalIncome == 0)
                {
                    IncomeBarChart.Series.Clear();
                    IncomeLineChart.Series.Clear();
                    IncomeTotalMsg.Visible = true;
                }
                if (totalExpense == 0)
                {
                    ExpenseBarChart.Series.Clear();
                    ExpenseLineChart.Series.Clear();
                    ExpenseTotalMsg.Visible = true;
                }
                if (totalExpense == 0 && totalIncome == 0)
                {
                    chart1.Series.Clear();
                    TransactionReportMsg.Visible = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + " Error" + seriesArray.Length);
            } 

        }

        private void MonthlyGraphPicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int chosenTime = MonthlyGraphPicker.Value.Year;
                PlotMonthlyGraph(chosenTime);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int chosenTime = MonthlyGraphPicker.Value.Year;
            PlotMonthlyGraph(chosenTime);
        }

        private void PlotGraph_Click(object sender, EventArgs e)
        {

            int chosenTime = MonthlyGraphPicker.Value.Year;
            PlotMonthlyGraph(chosenTime);
        }
    }
}