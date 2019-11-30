using BudgetManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement.Controllers
{
    public interface IDashboardView
    {
        void SetContactController(ContactController controller);
        void ClearGrid();
        void AddContactToGrid(Contact user);
        void UpdateGridWithChangedContact(Contact user);
        void RemoveContactFromGrid(Contact user);
        string GetIdOfSelectedContactInGrid();
        void SetSelectedContactInGrid(Contact user);

        string Name { get; set; }
        string Address { get; set; }
        string CID { get; set; }
        string ContactType { get; set; }
        bool CanModifyID { set; }
    }
}
