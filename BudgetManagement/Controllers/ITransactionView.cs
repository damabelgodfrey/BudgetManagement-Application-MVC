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
        void ClearGrid();
        void AddTransactionToGrid(Transaction trans);
        void UpdateGridWithChangedTransaction(Transaction trans);
        void RemoveTransactionFromGrid(Transaction trans);
        string GetIdOfSelectedTransactionInGrid();
        void SetSelectedTransactionInGrid(Transaction trans);

        string ViewTransDate { get; set; }
        bool CanModifyID { set; }
        string ViewTransID { get; set; }
        string ViewTransNote { get; set; }
        string ViewTransContact { get; set; }
        double ViewTransAmount { get; set; }
        string ViewTransType { get; set; }
        string ViewTransName { get; set; }

        void ClearRGrid();
       // void AddRTransactionToGrid(RecurringTransaction trans);
       // void UpdateGridWithChangedRTransaction(RecurringTransaction trans);
       // void RemoveRTransactionFromGrid(RecurringTransaction trans);
        string GetIdOfSelectedRTransactionInGrid();
       // void SetSelectedRTransactionInGrid(RecurringTransaction trans);

        bool CanModifyRID { set; }
        string ViewRTransID { get; set; }
        string ViewRTransNote { get; set; }
        string ViewRTransContact { get; set; }
        double ViewRTransAmount { get; set; }
        string ViewRTransType { get; set; }
        string ViewRTransName { get; set; }
        string ViewRTransStartDate { get; set; }
        string ViewRTransEndDate { get; set; }
        string viewRTransFrequency { get; set; }
    }
}
