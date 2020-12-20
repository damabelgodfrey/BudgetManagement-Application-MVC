using BudgetManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement.Controllers
{
    public interface ITransactionView
    {
        void SetTransactionController(TransactionController controller);
        void ClearGrid(String typeflag);
        void AddTransactionToGrid(Transaction trans);
        void UpdateGridWithChangedTransaction(Transaction trans);
        void RemoveTransactionFromGrid(Transaction trans);
        void SetSelectedTransactionInGrid(Transaction trans);

        DateTime ViewTransDate { get; set; }
       // bool CanModifyID { set; }
        int ViewTransID { get; set; }
        string ViewTransNote { get; set; }
        string ViewTransContact { get; set; }
        double ViewTransAmount { get; set; }
        string ViewTransType { get; set; }
        string ViewTransName { get; set; }
      //  string GetIdOfSelectedRTransactionInGrid();
       // void SetSelectedRTransactionInGrid(RecurringTransaction trans);

       // bool CanModifyRID { set; }
        int ViewRTransID { get; set; }
        string ViewRTransNote { get; set; }
        string ViewRTransContact { get; set; }
        double ViewRTransAmount { get; set; }
        string ViewRTransType { get; set; }
        string ViewRTransName { get; set; }
        DateTime ViewRTransStartDate { get; set; }
        DateTime ViewRTransEndDate { get; set; }
        string viewRTransFrequency { get; set; }
    }
}
