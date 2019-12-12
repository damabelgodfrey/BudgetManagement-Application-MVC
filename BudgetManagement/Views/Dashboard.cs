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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManagement.Views
{
    public partial class Dashboard : Form
    {
       
        public Dashboard()
        {
            InitializeComponent();
            Thread applicationthread = new Thread(ProgramThread);
            applicationthread.Start();
            Thread RecurringEventThread = new Thread(UpdateRecurrentEvents);
            RecurringEventThread.Start();

            // call a new thread 
        }

        //program thread
        public void ProgramThread()
        {
            Authentication.SetUpUserDetails();
        }

        //Events update Thread
        private void UpdateRecurrentEvents()
        {
           while(true)
            {

                List<RecurringTransaction> getReTrans = TransactionRepository.RequestRecurringTransactionList();
               // DateTime now = DateTime.Now;
                DateTime now = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy hh:mm"));
                try
                {
                    foreach (RecurringTransaction rTransaction in getReTrans)
                    {
                        int start = DateTime.Compare(now, Convert.ToDateTime(rTransaction.TransDate));
                        int end = DateTime.Compare(now, Convert.ToDateTime(rTransaction.transEndDate));
                       // MessageBox.Show(start.ToString() + " " + end.ToString() + "  " + rTransaction.TransDate + "  Running recurring event thread");

                        if (rTransaction.transFreQuency == "Daily" && start >= 0 && end <= 0)
                        {


                            //MessageBox.Show(rTransaction.transName + " " + now.ToString() + "  " + rTransaction.TransDate + "  Running recurring event thread");

                        }
                    }
                }
                catch (Exception)
                {

                   
                }
               
                Thread.Sleep(10000); //every 10 seconds


            }
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            
        }



        private void ManageContact_Click(object sender, EventArgs e)
        {
            ContactView view = new ContactView

            {
                //TransactionView Tview = new TransactionView();
                //Tview.ShowDialog();
                Visible = false
            };
            List<Contact> mycontact = ContactRepository.GetContactList();
            // List<Contact> mycontact = new List<Contact>();

            ContactController controller = new ContactController(view, mycontact);
            controller.LoadContactView();
            view.ShowDialog();
        }

        private void ManageTransaction_Click(object sender, EventArgs e)
        {

          

            // TransactionController rTcontroller = new TransactionController(TransactionForm, myRecurringtrans);
            TransactionController tcontroller = new TransactionController();

      
        }

        private  async void ManageContact_Click_1(object sender, EventArgs e)
        {
            ContactView ContactForm =  ContactView.GetContactForm();
           // ContactForm.Visible = false;
            List<Contact> mycontact = await Task.Run(() => ContactRepository.GetContactList());
            ContactController controller = new ContactController(ContactForm, mycontact);
            controller.LoadContactView();

            ContactForm.Show();

        }

    }
}
