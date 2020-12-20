using BudgetManagement.Controllers;
using BudgetManagement.Models;
using BudgetManagement.Repository;
using NLog;
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
using Tulpep.NotificationWindow;

namespace BudgetManagement.Views
{
    public partial class Dashboard : Form
    {
        private bool _previouslyAdded = false;
        private Logger _logger = LogManager.GetCurrentClassLogger();
        User user;
        Thread applicationthread;

        public Dashboard()
        {
            InitializeComponent();
            PredictionPanel.Visible = false;
            UserAccount.Visible = false;
            mainTransactionPanel.Visible = false;
            ClearEventGrid();
            LoadEventView();
            DateTime today = DateTime.Now;
            ExpensePredictionController predict = new ExpensePredictionController(today);

            double myPrediction = predict.GetPrediction();
            predictionValueLabel.Text = "Predicted Expense is: £" + myPrediction.ToString("0.00");

            user = UserRepository.GetUser();
            UserName.Text = user.uName;
            RecurringDateStamp.Text = "Last Recurring Event Update Check =>  " + user.uLastAccess;

            UserRepository accessObj = new UserRepository();
            applicationthread = new Thread(ProgramThread);
            applicationthread.Start();
            if (!RecuringAppRunner.IsBusy)
                RecuringAppRunner.RunWorkerAsync();

        }

        //program thread
        public void ProgramThread()
        {
            Authentication.SetUpUserDetails();


        }

        private void ManageTransaction_Click(object sender, EventArgs e)
        {



            // TransactionController rTcontroller = new TransactionController(TransactionForm, myRecurringtrans);
            TransactionController tcontroller = new TransactionController();


        }

        private void ManageContact_Click_1(object sender, EventArgs e)
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

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime theDay = monthCalendar2.SelectionEnd.Date;
            generateDynamic(theDay);
        }

        private async void generateDynamic(DateTime day)
        {
            int position = 0;
            User usl = UserRepository.GetUser();
            TransactionRepository getSaveTransaction = new TransactionRepository();
            List<Transaction> mytransaction = await Task.Run(() => getSaveTransaction.GetSavedTransaction(usl.uID));
            myTransactionPanel.Controls.Clear();
            Panel transactionPanelGride = new Panel();
            transactionPanelGride.BackColor = System.Drawing.SystemColors.Window;
            transactionPanelGride.Location = new System.Drawing.Point(0, 0);
            transactionPanelGride.MaximumSize = new System.Drawing.Size(653, 40);
            transactionPanelGride.MinimumSize = new System.Drawing.Size(653, 40);
            transactionPanelGride.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            transactionPanelGride.Name = "GeneratePanelGride";
            transactionPanelGride.Size = new System.Drawing.Size(653, 40);
            transactionPanelGride.TabIndex = 0;
            myTransactionPanel.Controls.Add(transactionPanelGride);
            Label TName = new Label();
            TName.BackColor = System.Drawing.SystemColors.Window;
            TName.Location = new System.Drawing.Point(3, 0);
            TName.MaximumSize = new System.Drawing.Size(209, 32);
            TName.MinimumSize = new System.Drawing.Size(209, 32);
            TName.Size = new System.Drawing.Size(209, 32);
            TName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            TName.TabIndex = 0;
            TName.Text = "Name";
            transactionPanelGride.Controls.Add(TName);
            // 
            // tAmount
            // 
            Label TAMount = new Label();
            TAMount.BackColor = System.Drawing.SystemColors.Window;
            TAMount.Location = new System.Drawing.Point(215, -3);
            TAMount.MaximumSize = new System.Drawing.Size(144, 35);
            TAMount.MinimumSize = new System.Drawing.Size(144, 35);
            TAMount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            TAMount.Size = new System.Drawing.Size(144, 35);
            TAMount.Name = "tAmount";
            TAMount.TabIndex = 1;
            TAMount.Text = "Amount";
            transactionPanelGride.Controls.Add(TAMount);
            // 
            // tType
            // 
            Label TType = new Label();

            TType.Location = new System.Drawing.Point(362, 0);
            TType.MaximumSize = new System.Drawing.Size(135, 32);
            TType.MinimumSize = new System.Drawing.Size(135, 32);
            TType.Size = new System.Drawing.Size(135, 32);
            TType.TabIndex = 2;
            TType.Text = "Type";
            TType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            TType.BackColor = System.Drawing.SystemColors.Window;
            transactionPanelGride.Controls.Add(TType);
            // 
            // tdate
            // 
            Label TContact = new Label();
            TContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter; 
            TContact.BackColor = System.Drawing.SystemColors.Window;
            TContact.Location = new System.Drawing.Point(499, 0);
            TContact.MaximumSize = new System.Drawing.Size(154, 32);
            TContact.MinimumSize = new System.Drawing.Size(154, 32);
            TContact.Name = "tcontact";
            TContact.Size = new System.Drawing.Size(154, 32);
            TContact.TabIndex = 3;
            TContact.Text = "Contact/Reference";
            transactionPanelGride.Controls.Add(TContact);

            foreach (Transaction transaction in mytransaction.ToList())
            {
                if (transaction.TransDate.Date == day)
                {
                    position++;
                    transactionPanelGride = new Panel();
                    transactionPanelGride.BackColor = System.Drawing.SystemColors.HighlightText;
                    transactionPanelGride.Location = new System.Drawing.Point(0, position * 40);
                    transactionPanelGride.MaximumSize = new System.Drawing.Size(653, 40);
                    transactionPanelGride.MinimumSize = new System.Drawing.Size(653, 40);
                    transactionPanelGride.Name = "GeneratePanelGride";
                    transactionPanelGride.Size = new System.Drawing.Size(653, 40);
                    transactionPanelGride.TabIndex = 0;
                    myTransactionPanel.Controls.Add(transactionPanelGride);
                    // 
                    // tName
                    // 
                    TName = new Label();
                    TName.BackColor = System.Drawing.SystemColors.Info;
                    TName.Location = new System.Drawing.Point(3, 0);
                    TName.MaximumSize = new System.Drawing.Size(209, 32);
                    TName.MinimumSize = new System.Drawing.Size(209, 32);
                    TName.Size = new System.Drawing.Size(209, 32);
                    TName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    TName.TabIndex = 0;
                    TName.Text = transaction.transName;
                    transactionPanelGride.Controls.Add(TName);
                    // 
                    // tAmount
                    // 
                    TAMount = new Label();
                    TAMount.BackColor = System.Drawing.SystemColors.Info;
                    TAMount.Location = new System.Drawing.Point(215, -3);
                    TAMount.MaximumSize = new System.Drawing.Size(144, 35);
                    TAMount.MinimumSize = new System.Drawing.Size(144, 35);
                    TAMount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    TAMount.Size = new System.Drawing.Size(144, 35);
                    TAMount.Name = "tAmount";
                    TAMount.Size = new System.Drawing.Size(182, 23);
                    TAMount.TabIndex = 1;
                    TAMount.Text = transaction.transAmount.ToString();
                    transactionPanelGride.Controls.Add(TAMount);

                    // 
                    // tType
                    // 
                    TType = new Label();

                    TType.BackColor = System.Drawing.SystemColors.Info;
                    TType.Location = new System.Drawing.Point(362, 0);
                    TType.MaximumSize = new System.Drawing.Size(135, 32);
                    TType.MinimumSize = new System.Drawing.Size(135, 32);
                    TType.Size = new System.Drawing.Size(135, 32);
                    TType.Text = "Type";
                    TType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    TType.Name = transaction.transType;
                    TType.TabIndex = 2;
                    TType.Text = transaction.transType;
                    transactionPanelGride.Controls.Add(TType);

                    // 
                    // tdate
                    // 
                    TContact = new Label();
                    TContact.BackColor = System.Drawing.SystemColors.Info;
                    TContact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    TContact.Location = new System.Drawing.Point(499, 0);
                    TContact.MaximumSize = new System.Drawing.Size(154, 32);
                    TContact.MinimumSize = new System.Drawing.Size(154, 32);
                    TContact.Name = "tcontact";
                    TContact.TabIndex = 3;
                    TContact.Text = transaction.transContact.ToString();
                    transactionPanelGride.Controls.Add(TContact);

                }
            }



        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker backgroundWorker = (BackgroundWorker)sender;
            while (!backgroundWorker.CancellationPending)
            {
                Thread.Sleep(10000);
                try
                {
                    RunRecurringTransaction();
                    RunRecurringEvent();
                    if (!_previouslyAdded)
                    {

                        _previouslyAdded = true;
                        UserRepository accessObj = new UserRepository();
                        User usl = UserRepository.GetUser();

                        bool a = accessObj.UpdateUser(usl, "Log");
                    }
                }
                catch (Exception ex)
                {

                _logger.Error(ex);

                }
               

            }

        }
        private void RecurringBackground_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (_previouslyAdded)
            {
                string message = (string)e.UserState;
                PopupNotifier popup = new PopupNotifier();
                popup.TitleText = "RECURRING EVENT ALERT";
                popup.ContentText = message;
                popup.Popup();
            }
        }

        private async void RunRecurringEvent()
        {

            User usl = UserRepository.GetUser();
            EventRepository getSaveEvents = new EventRepository();
            List<RecurringEvent> recurringEvent = await Task.Run(() => getSaveEvents.GetSavedRecurringEvent(usl.uID));


            foreach (RecurringEvent myRecurringEvent in recurringEvent.ToList())
            {
                int noOfDays = (DateTime.Now - usl.uLastAccess).Days;

                DateTime recurringTime = usl.uLastAccess;
                TimeSpan timeSpan = new TimeSpan(myRecurringEvent.EventDate.Hour, myRecurringEvent.EventDate.Minute, myRecurringEvent.EventDate.Second);
                recurringTime = recurringTime.Date + timeSpan;

                for (int i = 0; i <= noOfDays; i++)
                {
                    if (myRecurringEvent.EventFreQuency.Equals("Weekly"))
                    {
                        if (recurringTime.DayOfWeek != myRecurringEvent.EventDate.DayOfWeek)
                        {
                            recurringTime = recurringTime.AddDays(1);
                            continue;
                        }
                    }

                    if (myRecurringEvent.EventFreQuency.Equals("Monthly"))
                    {
                        if (recurringTime.Day != myRecurringEvent.EventDate.Day)
                        {
                            recurringTime = recurringTime.AddDays(1);
                            continue;
                        }
                    }

                    if (myRecurringEvent.EventFreQuency.Equals("Yearly"))
                    {
                        string recurringTimeString = recurringTime.ToString("dd/MM");
                        string createdDateString = myRecurringEvent.EventDate.ToString("dd/MM");
                        if (!recurringTimeString.Equals(createdDateString))
                        {
                            recurringTime = recurringTime.AddDays(1);
                            continue;
                        }
                    }

                    if (recurringTime > usl.uLastAccess && recurringTime <= DateTime.Now && recurringTime > myRecurringEvent.EventDate)
                    {
                        int id = myRecurringEvent.EventID;
                        int UserId = usl.uID;
                        string Name = myRecurringEvent.EventName;
                        string Type = myRecurringEvent.EventType;
                        string Note = myRecurringEvent.EventNote;
                        string CountactName = myRecurringEvent.EventContact;
                        DateTime TransDate = recurringTime;
                        Event myEvent = new Event(id, UserId, Name, Note, TransDate, Type, CountactName);

                        EventRepository EventRepoObj = new EventRepository();
                        string returnMsg = EventRepoObj.AddEvent(myEvent);
                        PopupNotifier popup = new PopupNotifier();

                        popup.TitleText = "RECURRING EVENT ALERT";
                        popup.ContentText = "EVENT added from Recurring EVENT runner";
                        popup.Popup();// show
                        RecuringAppRunner.ReportProgress(0);

                    }
                    recurringTime = recurringTime.AddDays(1);
                }
            }


        }

        private async void RunRecurringTransaction()
        {
            User usl = UserRepository.GetUser();
            TransactionRepository getSaveTransaction = new TransactionRepository();
            List<RecurringTransaction> recurringtransaction = await Task.Run(() => getSaveTransaction.GetSavedRecurringTransaction(usl.uID));

            foreach (RecurringTransaction myRecurringTransaction in recurringtransaction.ToList())
            {
                int noOfDays = (DateTime.Now - usl.uLastAccess).Days;

                DateTime recurringTime = usl.uLastAccess;
                TimeSpan timeSpan = new TimeSpan(myRecurringTransaction.TransDate.Hour, myRecurringTransaction.TransDate.Minute, myRecurringTransaction.TransDate.Second);
                recurringTime = recurringTime.Date + timeSpan;
                for (int i = 0; i <= noOfDays; i++)
                {
                    if (myRecurringTransaction.transFreQuency.Equals("Weekly"))
                    {
                        if (recurringTime.DayOfWeek != myRecurringTransaction.TransDate.DayOfWeek)
                        {
                            recurringTime = recurringTime.AddDays(1);
                            continue;
                        }
                    }

                    if (myRecurringTransaction.transFreQuency.Equals("Monthly"))
                    {
                        if (recurringTime.Day != myRecurringTransaction.TransDate.Day)
                        {
                            recurringTime = recurringTime.AddDays(1);
                            continue;
                        }
                    }

                    if (myRecurringTransaction.transFreQuency.Equals("Yearly"))
                    {
                        string recurringTimeString = recurringTime.ToString("dd/MM");
                        string createdDateString = myRecurringTransaction.TransDate.ToString("dd/MM");
                        if (!recurringTimeString.Equals(createdDateString))
                        {
                            recurringTime = recurringTime.AddDays(1);
                            continue;
                        }
                    }

                    if ((recurringTime > usl.uLastAccess) && (recurringTime <= DateTime.Now) && (recurringTime > myRecurringTransaction.TransDate))
                    {
                        int id = myRecurringTransaction.transID;
                        int UserId = usl.uID;
                        string Name = myRecurringTransaction.transName;
                        string Type = myRecurringTransaction.transType;
                        double Amount = myRecurringTransaction.transAmount;
                        string Note = myRecurringTransaction.transNote;
                        string CountactName = myRecurringTransaction.transContact;
                        DateTime TransDate = recurringTime;
                        Transaction transaction = new Transaction(id, UserId, Name, Note, TransDate, Amount, Type, CountactName);

                        TransactionRepository transactionRepoObj = new TransactionRepository();
                        string returnMsg = transactionRepoObj.AddTransaction(transaction);
                        RecuringAppRunner.ReportProgress(0);


                        // RecurringBackground.ReportProgress(1, "New Transaction has been Added");
                        RecuringAppRunner.ReportProgress(0);
                         PopupNotifier popup = new PopupNotifier();

                        popup.TitleText = "RECURRING TRANSACTION ALERT";
                        popup.ContentText = "TRANSACTION Added from Recurring TRANSACTION Runner";
                        popup.Popup();// show
                    }
                    recurringTime = recurringTime.AddDays(1);
                }
            }




        }

        private void ExpensePrediction_Click(object sender, EventArgs e)
        {
            PredictionPanel.Visible = true;
            mainTransactionPanel.Visible = false;
            UserAccount.Visible = false;
            // myTransactionPanel.Visible = false;
            PredictionPanel.BringToFront();
        }

        private void GeneratePrediction_Click(object sender, EventArgs e)
        {

            DateTime today = DateTime.Now.Date;
            DateTime chosenTime = PredictionDate.Value;
            try
            {
                if (chosenTime < today && chosenTime  != today)
                {
                    MessageBox.Show("Please choose a future date", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                ExpensePredictionController predict = new ExpensePredictionController(chosenTime);

                double myPrediction = predict.GetPrediction();
                predictionValueLabel.Text = "Predicted Expense is: £" + myPrediction.ToString("0.00");
            }
            catch (Exception er)
            {
                _logger.Error(er);

             }
        

        }

        private void Home_Click(object sender, EventArgs e)
        {
            PredictionPanel.Visible = false;
            EventPanel.Visible = true;
            mainTransactionPanel.Visible = false;
            UserAccount.Visible = false;
           // myTransactionPanel.Visible = false;

            PredictionPanel.Visible = false;
            EventPanel.BringToFront();
            ClearEventGrid();
            LoadEventView();
        }

        private void DailyTransView_Click(object sender, EventArgs e)
        {
            DateTime theDay = DateTime.Now.Date;
            generateDynamic(theDay);
            mainTransactionPanel.Visible = true;
            UserAccount.Visible = false;

            PredictionPanel.Visible = false;
            mainTransactionPanel.BringToFront();
           // myTransactionPanel.BringToFront();
        }

        public async void LoadEventView()
        {
            int sn = 1;
            DateTime theDay = DateTime.Now.Date;
            User usl = UserRepository.GetUser();
            EventRepository getSaveEvents = new EventRepository();
            List<Event> myEvent = await Task.Run(() => getSaveEvents.GetSavedEvent(usl.uID));
            ClearEventGrid();
            foreach (Event dEvent in myEvent.ToList())
            {
                if (dEvent.EventDate.Date == theDay && dEvent != null)
                {
                    AddEventToGrid(dEvent, sn);
                    sn++;
                }
            }
        }

        private async void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            int sn = 1;
            DateTime theDay = monthCalendar1.SelectionEnd.Date;
            User usl = UserRepository.GetUser();
            RecurringDateStamp.Text = "Last Recurring Event Update Check =>  "+usl.uLastAccess;
            EventRepository getSaveEvents = new EventRepository();
            List<Event> myEvent = await Task.Run(() => getSaveEvents.GetSavedEvent(usl.uID));
            ClearEventGrid();
            foreach (Event dEvent in myEvent.ToList())
            {
                if (dEvent.EventDate.Date == theDay)
                {
                    AddEventToGrid(dEvent, sn);
                    sn++;
                }
            }

        }

        public void ClearEventGrid()
        {
            // Define columns and clear item
            this.EventListView.Columns.Clear();

            this.EventListView.Columns.Add("S/N", 80, HorizontalAlignment.Left);
            this.EventListView.Columns.Add("Name", 100, HorizontalAlignment.Left);
            this.EventListView.Columns.Add("Type", 100, HorizontalAlignment.Left);
            this.EventListView.Columns.Add("Contact", 100, HorizontalAlignment.Left);
            this.EventListView.Columns.Add("Note", 250, HorizontalAlignment.Left);
            this.EventListView.Items.Clear();
        }

        public void AddEventToGrid(Event myEvent, int sn)
        {
            ListViewItem parent;
            parent = this.EventListView.Items.Add(sn.ToString());
            parent.SubItems.Add(myEvent.EventName);
            parent.SubItems.Add(myEvent.EventType);
            if (myEvent.EventContact == "")
            {
                parent.SubItems.Add("-");
            }
            else
            {
                parent.SubItems.Add(myEvent.EventContact);
            }
            if (myEvent.EventNote == "")
            {
                parent.SubItems.Add("-");
            }
            else
            {
                parent.SubItems.Add(myEvent.EventNote);
            }

            // ApplyStripeToTransactionGrid();
        }

        private void ViewEvent_Click(object sender, EventArgs e)
        {
            RecurringDateStamp.Text = "Last Recurring Event Update Check =>  " + user.uLastAccess;
            EventPanel.Visible = true;
            UserAccount.Visible = false;
            mainTransactionPanel.Visible = false;
            PredictionPanel.Visible = false;
            EventPanel.BringToFront();
            ClearEventGrid();
            LoadEventView();
        }



        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.WindowsShutDown
                || e.CloseReason == CloseReason.ApplicationExitCall
                || e.CloseReason == CloseReason.TaskManagerClosing)
            {
                return;
            }
            try
            {
                switch (MessageBox.Show(this, "Are you sure you want to close apllication? ", "Closing", MessageBoxButtons.YesNo))
                {
                    case DialogResult.No:
                        e.Cancel = true;
                        break;
                    default:
                        MyLoginForm.GetLoginForm().Dispose();
                        break;
                }
            }
            catch (Exception)
            {

               
            }
       
        }
        private void Logout_Click(object sender, EventArgs e)
        {
            LogoutDetails();
        }

        private void LogoutDetails()
        {
            ContactView.DisposeContactForm();
            EventView.DisposeEventForm();
            ReportView.DisposeReportForm();
            TransactionView.DisposeTransactionForm();
            this.Dispose();
            MyLoginForm.GetLoginForm().WindowState = FormWindowState.Normal;
            MyLoginForm.GetLoginForm().Activate();
            MyLoginForm.GetLoginForm().Show();
        }

        private void UserDetails_Click(object sender, EventArgs e)
        {
            EmailTxt.Text= user.uEmail;
            EventRecuring.Text = "Background Recurring Event Last Update Date: " + user.uLastAccess;
            NameTxt.Text = user.uName;
            PredictionPanel.Visible = false;
            mainTransactionPanel.Visible = false;
            EventPanel.Visible = false;
            UserAccount.Visible = true;
            UserAccount.BringToFront();
        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NameTxt.Text))
            {
                MessageBox.Show("Please Enter Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User dUser = new User(user.uID, NameTxt.Text, user.uEmail, user.uPassword,user.uLastAccess);

            UserRepository update = new UserRepository();
           bool status= update.UpdateUser(dUser,"Details");
            if (status)
            {
                MessageBox.Show("Update Successfull");
                UserName.Text = dUser.uName;
                LogoutDetails();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PasswordTxt.Text))
            {
                MessageBox.Show("Please Enter password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           if (string.IsNullOrWhiteSpace(PasswordConfirmTxt.Text))
            {
                MessageBox.Show("Please Enter Confirm Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (PasswordTxt.Text != PasswordConfirmTxt.Text)
            {
                MessageBox.Show("Please Enter Same Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User dUser = new User(user.uID, NameTxt.Text, user.uEmail, PasswordTxt.Text, user.uLastAccess);
            UserRepository update = new UserRepository();
           bool status = update.UpdateUser(dUser,"Password");
            if (status)
            {
                MessageBox.Show("Update Successfull");
                LogoutDetails();
            }
            else
            {
                MessageBox.Show("Update Failed");
            }
        }

        private void ShowUserPassword_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTxt.PasswordChar = ShowUserPassword.Checked ? '\0' : '*';
            PasswordConfirmTxt.PasswordChar = ShowUserPassword.Checked ? '\0' : '*';
        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I am instructed not to do that at this time");
        }

    }
}
