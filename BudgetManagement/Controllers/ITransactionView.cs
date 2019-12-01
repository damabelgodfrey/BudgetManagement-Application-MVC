using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement.Controllers
{
    public interface ITransactionsView
    {
        public void SetTransactionController(TransactionController controller);
        void ClearGrid();
        void AddTransToGrid(Transaction trans);
        void UpdateGridWithChangedtrans(Transaction trans);
        void RemoveTransFromGrid(Transaction trans);
        string GetIdOfSelectedTransInGrid();
        void SetSelectedTransInGrid(Transaction trans);

        string TID { get; set; }
        string TName { get; set; }
        string TOccurance { get; set; }
        string TDate { get; set; }
        double TAmount { get; set; }
        string TransactionType { get; set; }
        string TContact { get; set; }
        bool CanModifyTID { set; }
    }
}
