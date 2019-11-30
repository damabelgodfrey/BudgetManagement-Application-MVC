using BudgetManagement.Controllers;
using BudgetManagement.Models;
using BudgetManagement.Repository;
using System;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            MainFormController.SetUpUserDetails();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactView view = new ContactView

            {
                //TransactionView Tview = new TransactionView();
                //Tview.ShowDialog();
                Visible = false
            };
            List<Contact> mycontact = ContactRepositoryController.ContactList;
           // List<Contact> mycontact = new List<Contact>();

            ContactController controller = new ContactController(view, mycontact);
            controller.LoadContactView();
            view.ShowDialog();
        }
    }
}
