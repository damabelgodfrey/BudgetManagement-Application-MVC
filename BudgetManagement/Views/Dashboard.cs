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

            RecuringAppRunner.RunWorkerAsync();
        }

        //program thread
        public void ProgramThread()
        {
            Authentication.SetUpUserDetails();
        }

        //Events update Thread
        private void UpdateRecurrentEvents()
        {
           while(2==1)
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
           
            ContactController controller = new ContactController();
        }

        private void ManageTransaction_Click(object sender, EventArgs e)
        {

          

            // TransactionController rTcontroller = new TransactionController(TransactionForm, myRecurringtrans);
            TransactionController tcontroller = new TransactionController();

      
        }

        private  void ManageContact_Click_1(object sender, EventArgs e)
        {

            ContactController CController = new ContactController();

        }

        private void ManageEvent_Click(object sender, EventArgs e)
        {
            EventController EController = new EventController();

        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            ReportController tcontroller = new ReportController();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            bool checkIfFirst = true;
            List<User> usl = UserRepository.GetUserList();
            TransactionRepository getSaveTransaction = new TransactionRepository();
            getSaveTransaction.GetSavedRecurringTransaction(usl[0].uID);

            BackgroundWorker backgroundWorker = (BackgroundWorker)sender;
            while (!backgroundWorker.CancellationPending)
            {
                RunRecurringTransaction();
                RunRecurringEvent();
                if (checkIfFirst == true)
                {
                    checkIfFirst = false;
                }
            }





            UserRepository accessObj = new UserRepository();
            bool a = accessObj.UpdateLogDate(usl[0].uID);
            MessageBox.Show(a.ToString());

        }

        private async void RunRecurringEvent()
        {
            List<RecurringEvent> REvent = await Task.Run(() => EventRepository.RequestRecurringEventList());
            foreach (RecurringEvent myEvent in REvent)
            {

                // MessageBox.Show("I am checking recurring");
                if (DateTime.Now > myEvent.EventEndDate && myEvent.EventEndDate != DateTime.MinValue) continue;

                DateTime accTime = UserRepository.GetUserLogDate();
                DateTime nowTime = DateTime.Now;
                int days = (nowTime - accTime).Days;
                DateTime recTime = UserRepository.GetUserLogDate();
                TimeSpan ts = new TimeSpan(
                    myEvent.EventDate.Hour,
                    myEvent.EventDate.Minute,
                    myEvent.EventDate.Second
                    );
                recTime = recTime.Date + ts;
                for (int i = 0; i <= days; i++)
                {
                    if (myEvent.EventFreQuency.Equals("Weekly"))
                    {
                        if (recTime.DayOfWeek != myEvent.EventDate.DayOfWeek)
                        {
                            recTime = recTime.AddDays(1);
                            continue;
                        }
                    }
                    if (myEvent.EventFreQuency.Equals("Monthly"))
                    {
                        if (recTime.Day != myEvent.EventDate.Day)
                        {
                            recTime = recTime.AddDays(1);
                            continue;
                        }
                    }
                    if (myEvent.EventFreQuency.Equals("Yearly"))
                    {
                        string recTimeString = recTime.ToString("dd/MM");
                        string createdDateString = myEvent.EventDate.ToString("dd/MM");
                        if (!recTimeString.Equals(createdDateString))
                        {
                            recTime = recTime.AddDays(1);
                            continue;
                        }
                    }
                    if (recTime > accTime && recTime <= nowTime && recTime > myEvent.EventDate)
                    {
                        int id = myEvent.EventID;
                        int UserId = myEvent.EventUserID;
                        string Name = myEvent.EventName;
                        string Type = myEvent.EventType;
                        string Note = myEvent.EventNote;
                        string CountactName = myEvent.EventContact;
                        DateTime TransDate = myEvent.EventDate;
                        Event eventObj = new Event(id, UserId, Name, Note, TransDate, Type, CountactName);

                        EventRepository eventRepoObj = new EventRepository();
                        string returnMsg = await Task.Run(() => eventRepoObj.AddEvent(eventObj));
                        RecuringAppRunner.ReportProgress(0);
                    }
                    recTime = recTime.AddDays(1);
                }
            }


        }

        private async void RunRecurringTransaction()
        {
           
             List<RecurringTransaction> recurringtransaction = await Task.Run(() => TransactionRepository.RequestRecurringTransactionList());
            foreach (RecurringTransaction myTransaction in recurringtransaction.ToList())
            {

               //MessageBox.Show("I am checking recurring");
                if (DateTime.Now > myTransaction.transEndDate && myTransaction.transEndDate != DateTime.MinValue) continue;

                DateTime accTime = UserRepository.GetUserLogDate();
                DateTime nowTime = DateTime.Now;
                int days = (nowTime - accTime).Days;
                DateTime recTime = UserRepository.GetUserLogDate();
                TimeSpan ts = new TimeSpan(
                    myTransaction.TransDate.Hour,
                    myTransaction.TransDate.Minute,
                    myTransaction.TransDate.Second
                    );
                recTime = recTime.Date + ts;
                for (int i = 0; i <= days; i++)
                {
                    if (myTransaction.transFreQuency.Equals("Weekly"))
                    {
                        if (recTime.DayOfWeek != myTransaction.TransDate.DayOfWeek)
                        {
                            recTime = recTime.AddDays(1);
                            continue;
                        }
                    }
                    if (myTransaction.transFreQuency.Equals("Monthly"))
                    {
                        if (recTime.Day != myTransaction.TransDate.Day)
                        {
                            recTime = recTime.AddDays(1);
                            continue;
                        }
                    }
                    if (myTransaction.transFreQuency.Equals("Yearly"))
                    {
                        string recTimeString = recTime.ToString("dd/MM");
                        string createdDateString = myTransaction.TransDate.ToString("dd/MM");
                        if (!recTimeString.Equals(createdDateString))
                        {
                            recTime = recTime.AddDays(1);
                            continue;
                        }
                    }
                    if (recTime > accTime && recTime <= nowTime && recTime > myTransaction.TransDate)
                    {
                        int id = myTransaction.transID;
                        int UserId = myTransaction.transUserID;
                        string Name = myTransaction.transName;
                        string Type = myTransaction.transType;
                        double Amount = myTransaction.transAmount;
                        string Note = myTransaction.transNote;
                        string CountactName = myTransaction.transContact;
                        DateTime TransDate = myTransaction.TransDate;
                        Transaction transaction = new Transaction(id, UserId, Name, Note, TransDate, Amount, Type, CountactName);

                        TransactionRepository transactionRepoObj = new TransactionRepository();
                        string returnMsg = await Task.Run(() => transactionRepoObj.AddTransaction(transaction));
                        RecuringAppRunner.ReportProgress(0);
                    }
                    recTime = recTime.AddDays(1);
                }
            }


        }

        private void ViewReport_Click(object sender, EventArgs e)
        {

        }

        private void ExpensePrediction_Click(object sender, EventArgs e)
        {
            PredictionPanel.Visible = true;
            PredictionPanel.BringToFront();
        }

        private  void GeneratePrediction_Click(object sender, EventArgs e)
        {

            ExpensePredictionController predict = new ExpensePredictionController(PredictionDate.Value);
            // predictionValueLabel.Text = "Predicted Expense is: £"+prediction.ToString();
            Panel mainPanel = new Panel();
            mainPanel.BackColor = Color.Black;
            mainPanel.Size = new Size(500, 500);
            mainPanel.Location = new Point(300, 300);
            mainPanel.AutoScroll = true;
            this.Controls.Add(mainPanel);

            Panel insidePanel = new Panel();
            insidePanel.BackColor = Color.Red;
            insidePanel.Size = new Size(100, 100);
            insidePanel.Location = new Point(0, 0);
            insidePanel.AutoScroll = true;
            mainPanel.Controls.Add(insidePanel);
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            PredictionPanel.Visible = false;
        }
    }
}
