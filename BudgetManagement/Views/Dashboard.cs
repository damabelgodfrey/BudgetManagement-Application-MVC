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
            Authentication.SetUpUserDetails();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactView view = new ContactView

            {
                //TransactionView Tview = new TransactionView();
                //Tview.ShowDialog();
                Visible = false
            };
            List<Contact> mycontact = ContactRepository.ContactList;
           // List<Contact> mycontact = new List<Contact>();

            ContactController controller = new ContactController(view, mycontact);
            controller.LoadContactView();
            view.ShowDialog();
        }

        private void transactionview_Click(object sender, EventArgs e)
        {
            TransactionView tview = new TransactionView
            {
                //TransactionView Tview = new TransactionView();
                //Tview.ShowDialog();
                Visible = false
            };
            List<Transaction> mytrans = TransactionRepository.TransactionList;
            for (int i = 1; i < 10; i++)
            {
                // mycontact.Add(new Contact("1", "Putin", "16 Oxford Road London", "payee"));
                //mycontact.Add(new Contact("2", "Putin", "16 Presbide prestden London", "payer"));
                if (i % 2 == 0)
                {
                   // yyyyMMddHHmmss

                   // mytrans.Add(new Transaction(i, i, "John", "better than usual", "", 200+i, "Income","peter"));
                }
                else
                {
                   // mytrans.Add(new Transaction(i, i, "Uncle", "better than usual", "", 600+i, "expense","james"));
                }
            }

            TransactionController tcontroller = new TransactionController(tview, mytrans);
            tcontroller.LoadTransactionView();
            tview.ShowDialog();
        }
    }
}
