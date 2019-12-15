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

        //List<RecurringTransaction> myRecurringTransactionlist = new List<RecurringTransaction>();

        int userID = UserRepository.GetUserID();
        private static string NewContactName = "";
        internal static string GetNewContactName()
        {
            return NewContactName;
        }

        public ReportController()
        {
            _view = ReportView.GetReportForm();
            _view.SetReportController(this);
            SetReportFormDetails();
            _view.WindowState = FormWindowState.Normal;
            _view.Activate();
            _view.Show();
        }

        public void SetReportFormDetails()
        {
            TransactionRepository getSaveTransaction = new TransactionRepository();
            getSaveTransaction.GetSavedTransaction(userID);
            reportTransactionlist = TransactionRepository.RequestTransactionList();
            LoadReportView();
        }

        
        internal void RequestReport(DateTime startDate, DateTime endDate, string name, string contact)
        {
            reportTransactionlist.Clear();
            TransactionRepository getTransactionReport = new TransactionRepository();
            reportTransactionlist = getTransactionReport.GetTransactionReport(userID, name, contact);
            this._view.ClearGrid();
            foreach (Transaction transaction in this.reportTransactionlist)
            {
                //if(Convert.ToDateTime(transaction.TransDate).Date == Convert.ToDateTime(transaction.TransDate).Date)
                
                int startRangeCheck = DateTime.Compare(Convert.ToDateTime(transaction.TransDate).Date, Convert.ToDateTime(startDate));
                int endRangeCheck = DateTime.Compare(Convert.ToDateTime(transaction.TransDate).Date, Convert.ToDateTime(endDate));

                if (startRangeCheck != -1 && endRangeCheck !=1)
                {
                        this._view.AddTransactionToGrid(transaction);
                              
                }
            }
        }

        public void LoadReportView()
        {
            _view.ClearGrid();
           int noTransaction = 0;
            if (reportTransactionlist.Count >0)
            {
                foreach (Transaction transaction in reportTransactionlist)
                {
                    if(noTransaction > 50)
                    {
                        return;
                    }
                    _view.AddTransactionToGrid(transaction);
                    noTransaction++;
                }

                _view.SetSelectedTransactionInGrid((Transaction)reportTransactionlist[0]);
            }


        }
    }
}

 