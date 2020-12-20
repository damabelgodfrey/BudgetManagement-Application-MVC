using BudgetManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement.Controllers
{
   public interface IContactView
    {
        void SetContactController(ContactController controller);
        void ClearGrid();
        void AddContactToGrid(Contact contact);
        void UpdateGridWithChangedContact(Contact contact);
        void RemoveContactFromGrid(Contact contact);
        string GetIdOfSelectedContactInGrid();
        void SetSelectedContactInGrid(Contact contact);

        string ContactName { get; set; }
        string Address { get; set; }
        int CID { get; set; }
        string ContactType { get; set; }
    }
}
