using BudgetManagement.Models;
using BudgetManagement.Repository;
using BudgetManagement.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManagement.Controllers
{
    public class ReportController
    {
        ReportView _view;
        List<Transaction> reportTransactionlist;
        static int userID = UserRepository.GetUserID();
        private static bool newViewObjFlag = false;
        static List<Transaction> Transactionlist;
        static Dictionary<int, double> MonthTotalIncomeHolder = new Dictionary<int, double>();
        static Dictionary<int, double> MonthTotalExpenseHolder = new Dictionary<int, double>();

        public ReportController()
        {
            try
            {
                _view = ReportView.GetSetReportFormInstance();
                _view.SetReportController(this);
                SetReportFormDetails();
                _view.WindowState = FormWindowState.Normal;
                _view.Activate();
                _view.Show();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        public void SetReportFormDetails()
        {
            if (newViewObjFlag == true)
            {
                TransactionRepository getSaveTransaction = new TransactionRepository();
                reportTransactionlist = getSaveTransaction.GetSavedTransaction(userID);
                LoadReportView();
            }

        }

        internal static void SetNewViewObjFlag(bool flag)
        {

            newViewObjFlag = flag;
        }

        internal void RequestReport(DateTime startDate, DateTime endDate, string name, string contact)
        {
            try
            {
                reportTransactionlist.Clear();

            }
            catch (Exception)
            {

            }
            int noTransaction = 1;
            TransactionRepository getTransactionReport = new TransactionRepository();
            reportTransactionlist = getTransactionReport.GetTransactionReport(userID, name, contact);
            this._view.ClearGrid();
            foreach (Transaction transaction in this.reportTransactionlist)
            {
                int startRangeCheck = DateTime.Compare(Convert.ToDateTime(transaction.TransDate).Date, Convert.ToDateTime(startDate));
                int endRangeCheck = DateTime.Compare(Convert.ToDateTime(transaction.TransDate).Date, Convert.ToDateTime(endDate));

                if (startRangeCheck != -1 && endRangeCheck != 1)
                {
                    this._view.AddTransactionToGrid(transaction, noTransaction);
                    noTransaction++;
                }
            }
        }
        public void LoadReportView()
        {
            _view.ClearGrid();
            int noTransaction = 1;
            if (reportTransactionlist.Count > 0)
            {
                foreach (Transaction transaction in reportTransactionlist)
                {
                    if (transaction.TransDate.Month == DateTime.Now.Month && transaction.TransDate.Year == DateTime.Now.Year)
                    {
                        _view.AddTransactionToGrid(transaction, noTransaction);
                        noTransaction++;
                    }
                    try
                    {
                        MonthTotalIncomeHolder.Clear();
                        MonthTotalExpenseHolder.Clear();
                        CalMonthlyIncomeExpense(transaction, DateTime.Now.Year);
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e + ".ToString()");
                    }
                }
                SetMonthlyIndexWithNoTransaction();
                _view.SetSelectedTransactionInGrid((Transaction)reportTransactionlist[0]);
            }


        }

        private static void SetMonthlyIndexWithNoTransaction()
        {
            for (int incomeIndex = 0; incomeIndex < 12; incomeIndex++)
            {
                if (!MonthTotalIncomeHolder.ContainsKey(incomeIndex))
                {
                    MonthTotalIncomeHolder.Add(incomeIndex, 0);
                }
            }
            for (int ExpenseIndex = 0; ExpenseIndex < 12; ExpenseIndex++)
            {
                if (!MonthTotalExpenseHolder.ContainsKey(ExpenseIndex))
                {
                    MonthTotalExpenseHolder.Add(ExpenseIndex, 0);
                }
            }

        }
        private static void CalMonthlyIncomeExpense(Transaction transaction, int date)
        {
            if (transaction.TransDate.Year == date)
            {
                if (transaction.transType == "Income")
                {
                    if (!MonthTotalIncomeHolder.ContainsKey(transaction.TransDate.Month - 1))
                    {
                        MonthTotalIncomeHolder.Add(transaction.TransDate.Month - 1, transaction.transAmount);
                    }
                    else
                    {
                        MonthTotalIncomeHolder[transaction.TransDate.Month - 1] = MonthTotalIncomeHolder[transaction.TransDate.Month - 1] + transaction.transAmount;
                    }
                }

                if (transaction.transType == "Expense")
                {
                    if (!MonthTotalExpenseHolder.ContainsKey(transaction.TransDate.Month - 1))
                    {
                        MonthTotalExpenseHolder[transaction.TransDate.Month - 1] = transaction.transAmount;
                    }
                    else
                    {
                        MonthTotalExpenseHolder[transaction.TransDate.Month - 1] = MonthTotalExpenseHolder[transaction.TransDate.Month - 1] + transaction.transAmount;
                    }
                }

            }
        }

        internal static Dictionary<int, double> GetCalIncomeGraphValue(int year)
        {
            TransactionRepository getSaveTransaction = new TransactionRepository();
            Transactionlist = getSaveTransaction.GetSavedTransaction(userID);
            MonthTotalIncomeHolder.Clear();
            MonthTotalExpenseHolder.Clear();

            foreach (Transaction transaction in Transactionlist)
            {
                CalMonthlyIncomeExpense(transaction, year);
            }
            SetMonthlyIndexWithNoTransaction();
            return MonthTotalIncomeHolder;
        }

        internal static Dictionary<int, double> GetCalExpenseGraphValue(int v)
        {
            return MonthTotalExpenseHolder;
        }
    }
}

