using BudgetManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement.Controllers
{
    public interface IReportView
    {
        void SetReportController(ReportController controller);
        void ClearGrid();
        void AddTransactionToGrid(Transaction trans, int no);
    }
}
