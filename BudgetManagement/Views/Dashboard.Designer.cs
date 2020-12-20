using System.Windows.Forms;

namespace BudgetManagement.Views
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Home = new MaterialSkin.Controls.MaterialFlatButton();
            this.ManageTransaction = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ManageEvent = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ExpensePrediction = new MaterialSkin.Controls.MaterialFlatButton();
            this.ManageContact = new MaterialSkin.Controls.MaterialRaisedButton();
            this.PredictionPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.predictionValueLabel = new System.Windows.Forms.Button();
            this.GeneratePrediction = new System.Windows.Forms.Button();
            this.PredictionDate = new System.Windows.Forms.DateTimePicker();
            this.GenerateReport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RecuringAppRunner = new System.ComponentModel.BackgroundWorker();
            this.myTransactionPanel = new System.Windows.Forms.Panel();
            this.DailyTransView = new MaterialSkin.Controls.MaterialFlatButton();
            this.UserName = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ViewEvent = new MaterialSkin.Controls.MaterialFlatButton();
            this.EventPanel = new System.Windows.Forms.Panel();
            this.RecurringDateStamp = new MaterialSkin.Controls.MaterialFlatButton();
            this.button2 = new System.Windows.Forms.Button();
            this.EventListView = new MaterialSkin.Controls.MaterialListView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.materialRaisedButton2 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.mainTransactionPanel = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.UserDetails = new MaterialSkin.Controls.MaterialFlatButton();
            this.UserAccount = new System.Windows.Forms.Panel();
            this.Logout = new MaterialSkin.Controls.MaterialFlatButton();
            this.UserDetailTab = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DeleteUser = new MaterialSkin.Controls.MaterialFlatButton();
            this.EventRecuring = new MaterialSkin.Controls.MaterialLabel();
            this.UpdateUser = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.NameTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.EmailTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ShowUserPassword = new System.Windows.Forms.CheckBox();
            this.ChangePassword = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.PasswordConfirmTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.PasswordTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.PredictionPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.EventPanel.SuspendLayout();
            this.mainTransactionPanel.SuspendLayout();
            this.UserAccount.SuspendLayout();
            this.UserDetailTab.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(0, 0);
            this.materialRaisedButton1.MinimumSize = new System.Drawing.Size(175, 532);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(175, 532);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Home.BackColor = System.Drawing.SystemColors.Control;
            this.Home.Depth = 0;
            this.Home.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.Home.FlatAppearance.BorderSize = 50;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Home.Icon = null;
            this.Home.Location = new System.Drawing.Point(1, 137);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Home.MinimumSize = new System.Drawing.Size(175, 56);
            this.Home.MouseState = MaterialSkin.MouseState.HOVER;
            this.Home.Name = "Home";
            this.Home.Primary = false;
            this.Home.Size = new System.Drawing.Size(175, 56);
            this.Home.TabIndex = 7;
            this.Home.Text = "HOME";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // ManageTransaction
            // 
            this.ManageTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManageTransaction.AutoSize = true;
            this.ManageTransaction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ManageTransaction.Depth = 0;
            this.ManageTransaction.Icon = null;
            this.ManageTransaction.Location = new System.Drawing.Point(377, 8);
            this.ManageTransaction.MinimumSize = new System.Drawing.Size(200, 36);
            this.ManageTransaction.MouseState = MaterialSkin.MouseState.HOVER;
            this.ManageTransaction.Name = "ManageTransaction";
            this.ManageTransaction.Primary = true;
            this.ManageTransaction.Size = new System.Drawing.Size(200, 36);
            this.ManageTransaction.TabIndex = 9;
            this.ManageTransaction.Text = "MANAGE TRANSACTION";
            this.ManageTransaction.UseVisualStyleBackColor = true;
            this.ManageTransaction.Click += new System.EventHandler(this.ManageTransaction_Click);
            // 
            // ManageEvent
            // 
            this.ManageEvent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManageEvent.AutoSize = true;
            this.ManageEvent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ManageEvent.Depth = 0;
            this.ManageEvent.Icon = null;
            this.ManageEvent.Location = new System.Drawing.Point(578, 8);
            this.ManageEvent.MinimumSize = new System.Drawing.Size(200, 36);
            this.ManageEvent.MouseState = MaterialSkin.MouseState.HOVER;
            this.ManageEvent.Name = "ManageEvent";
            this.ManageEvent.Primary = true;
            this.ManageEvent.Size = new System.Drawing.Size(200, 36);
            this.ManageEvent.TabIndex = 10;
            this.ManageEvent.Text = "MANAGE EVENT";
            this.ManageEvent.UseVisualStyleBackColor = true;
            this.ManageEvent.Click += new System.EventHandler(this.ManageEvent_Click);
            // 
            // ExpensePrediction
            // 
            this.ExpensePrediction.AutoSize = true;
            this.ExpensePrediction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExpensePrediction.Depth = 0;
            this.ExpensePrediction.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ExpensePrediction.Icon = null;
            this.ExpensePrediction.Location = new System.Drawing.Point(1, 239);
            this.ExpensePrediction.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ExpensePrediction.MinimumSize = new System.Drawing.Size(175, 56);
            this.ExpensePrediction.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExpensePrediction.Name = "ExpensePrediction";
            this.ExpensePrediction.Primary = false;
            this.ExpensePrediction.Size = new System.Drawing.Size(175, 56);
            this.ExpensePrediction.TabIndex = 12;
            this.ExpensePrediction.Text = "EXPENSE PREDICTION";
            this.ExpensePrediction.UseVisualStyleBackColor = true;
            this.ExpensePrediction.Click += new System.EventHandler(this.ExpensePrediction_Click);
            // 
            // ManageContact
            // 
            this.ManageContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ManageContact.AutoSize = true;
            this.ManageContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ManageContact.Depth = 0;
            this.ManageContact.Icon = null;
            this.ManageContact.Location = new System.Drawing.Point(176, 8);
            this.ManageContact.MinimumSize = new System.Drawing.Size(200, 36);
            this.ManageContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.ManageContact.Name = "ManageContact";
            this.ManageContact.Primary = true;
            this.ManageContact.Size = new System.Drawing.Size(200, 36);
            this.ManageContact.TabIndex = 14;
            this.ManageContact.Text = "MANAGE CONTACT";
            this.ManageContact.UseVisualStyleBackColor = true;
            this.ManageContact.Click += new System.EventHandler(this.ManageContact_Click_1);
            // 
            // PredictionPanel
            // 
            this.PredictionPanel.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PredictionPanel.Controls.Add(this.groupBox1);
            this.PredictionPanel.Location = new System.Drawing.Point(178, 57);
            this.PredictionPanel.Name = "PredictionPanel";
            this.PredictionPanel.Size = new System.Drawing.Size(883, 475);
            this.PredictionPanel.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.predictionValueLabel);
            this.groupBox1.Controls.Add(this.GeneratePrediction);
            this.groupBox1.Controls.Add(this.PredictionDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(88, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 329);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate Expense Prediction";
            // 
            // predictionValueLabel
            // 
            this.predictionValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.predictionValueLabel.ForeColor = System.Drawing.Color.Maroon;
            this.predictionValueLabel.Location = new System.Drawing.Point(176, 152);
            this.predictionValueLabel.Name = "predictionValueLabel";
            this.predictionValueLabel.Size = new System.Drawing.Size(280, 83);
            this.predictionValueLabel.TabIndex = 2;
            this.predictionValueLabel.UseVisualStyleBackColor = true;
            // 
            // GeneratePrediction
            // 
            this.GeneratePrediction.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.GeneratePrediction.Location = new System.Drawing.Point(377, 47);
            this.GeneratePrediction.Name = "GeneratePrediction";
            this.GeneratePrediction.Size = new System.Drawing.Size(150, 62);
            this.GeneratePrediction.TabIndex = 1;
            this.GeneratePrediction.Text = "Generate Prediction";
            this.GeneratePrediction.UseVisualStyleBackColor = false;
            this.GeneratePrediction.Click += new System.EventHandler(this.GeneratePrediction_Click);
            // 
            // PredictionDate
            // 
            this.PredictionDate.Location = new System.Drawing.Point(126, 66);
            this.PredictionDate.Name = "PredictionDate";
            this.PredictionDate.Size = new System.Drawing.Size(200, 26);
            this.PredictionDate.TabIndex = 0;
            // 
            // GenerateReport
            // 
            this.GenerateReport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateReport.AutoSize = true;
            this.GenerateReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenerateReport.Depth = 0;
            this.GenerateReport.Icon = null;
            this.GenerateReport.Location = new System.Drawing.Point(779, 8);
            this.GenerateReport.MinimumSize = new System.Drawing.Size(200, 36);
            this.GenerateReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Primary = true;
            this.GenerateReport.Size = new System.Drawing.Size(200, 36);
            this.GenerateReport.TabIndex = 16;
            this.GenerateReport.Text = "Generate Report";
            this.GenerateReport.UseVisualStyleBackColor = true;
            this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
            // 
            // RecuringAppRunner
            // 
            this.RecuringAppRunner.WorkerReportsProgress = true;
            this.RecuringAppRunner.WorkerSupportsCancellation = true;
            this.RecuringAppRunner.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.RecuringAppRunner.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.RecurringBackground_ProgressChanged);
            // 
            // myTransactionPanel
            // 
            this.myTransactionPanel.AutoScroll = true;
            this.myTransactionPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.myTransactionPanel.Location = new System.Drawing.Point(229, 41);
            this.myTransactionPanel.Name = "myTransactionPanel";
            this.myTransactionPanel.Size = new System.Drawing.Size(654, 440);
            this.myTransactionPanel.TabIndex = 17;
            // 
            // DailyTransView
            // 
            this.DailyTransView.AutoSize = true;
            this.DailyTransView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DailyTransView.Depth = 0;
            this.DailyTransView.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DailyTransView.Icon = null;
            this.DailyTransView.Location = new System.Drawing.Point(1, 340);
            this.DailyTransView.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DailyTransView.MinimumSize = new System.Drawing.Size(175, 56);
            this.DailyTransView.MouseState = MaterialSkin.MouseState.HOVER;
            this.DailyTransView.Name = "DailyTransView";
            this.DailyTransView.Primary = false;
            this.DailyTransView.Size = new System.Drawing.Size(175, 56);
            this.DailyTransView.TabIndex = 18;
            this.DailyTransView.Text = "VIEW TRANSACTION";
            this.DailyTransView.UseVisualStyleBackColor = true;
            this.DailyTransView.Click += new System.EventHandler(this.DailyTransView_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UserName.Depth = 0;
            this.UserName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Icon = null;
            this.UserName.Location = new System.Drawing.Point(0, 57);
            this.UserName.MaximumSize = new System.Drawing.Size(175, 36);
            this.UserName.MinimumSize = new System.Drawing.Size(175, 36);
            this.UserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserName.Name = "UserName";
            this.UserName.Primary = true;
            this.UserName.Size = new System.Drawing.Size(175, 36);
            this.UserName.TabIndex = 19;
            this.UserName.Text = "User Name";
            this.UserName.UseVisualStyleBackColor = true;
            // 
            // ViewEvent
            // 
            this.ViewEvent.AutoSize = true;
            this.ViewEvent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ViewEvent.Depth = 0;
            this.ViewEvent.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ViewEvent.Icon = null;
            this.ViewEvent.Location = new System.Drawing.Point(1, 438);
            this.ViewEvent.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ViewEvent.MinimumSize = new System.Drawing.Size(175, 56);
            this.ViewEvent.MouseState = MaterialSkin.MouseState.HOVER;
            this.ViewEvent.Name = "ViewEvent";
            this.ViewEvent.Primary = false;
            this.ViewEvent.Size = new System.Drawing.Size(175, 56);
            this.ViewEvent.TabIndex = 21;
            this.ViewEvent.Text = "VIEW EVENT";
            this.ViewEvent.UseVisualStyleBackColor = true;
            this.ViewEvent.Click += new System.EventHandler(this.ViewEvent_Click);
            // 
            // EventPanel
            // 
            this.EventPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.EventPanel.Controls.Add(this.RecurringDateStamp);
            this.EventPanel.Controls.Add(this.button2);
            this.EventPanel.Controls.Add(this.EventListView);
            this.EventPanel.Controls.Add(this.monthCalendar1);
            this.EventPanel.Location = new System.Drawing.Point(176, 52);
            this.EventPanel.Name = "EventPanel";
            this.EventPanel.Size = new System.Drawing.Size(883, 480);
            this.EventPanel.TabIndex = 22;
            // 
            // RecurringDateStamp
            // 
            this.RecurringDateStamp.AutoSize = true;
            this.RecurringDateStamp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RecurringDateStamp.BackColor = System.Drawing.SystemColors.ControlLight;
            this.RecurringDateStamp.Depth = 0;
            this.RecurringDateStamp.ForeColor = System.Drawing.Color.White;
            this.RecurringDateStamp.Icon = null;
            this.RecurringDateStamp.Location = new System.Drawing.Point(245, -1);
            this.RecurringDateStamp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RecurringDateStamp.MinimumSize = new System.Drawing.Size(634, 36);
            this.RecurringDateStamp.MouseState = MaterialSkin.MouseState.HOVER;
            this.RecurringDateStamp.Name = "RecurringDateStamp";
            this.RecurringDateStamp.Primary = false;
            this.RecurringDateStamp.Size = new System.Drawing.Size(634, 36);
            this.RecurringDateStamp.TabIndex = 3;
            this.RecurringDateStamp.Text = "Last Recurring Event Update Check";
            this.RecurringDateStamp.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(243, 26);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(636, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "DAY EVENT TABLE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // EventListView
            // 
            this.EventListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventListView.Depth = 0;
            this.EventListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.EventListView.FullRowSelect = true;
            this.EventListView.GridLines = true;
            this.EventListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.EventListView.HideSelection = false;
            this.EventListView.Location = new System.Drawing.Point(245, 56);
            this.EventListView.MouseLocation = new System.Drawing.Point(-1, -1);
            this.EventListView.MouseState = MaterialSkin.MouseState.OUT;
            this.EventListView.Name = "EventListView";
            this.EventListView.OwnerDraw = true;
            this.EventListView.Size = new System.Drawing.Size(631, 411);
            this.EventListView.TabIndex = 1;
            this.EventListView.UseCompatibleStateImageBehavior = false;
            this.EventListView.View = System.Windows.Forms.View.Details;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(6, 26);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // materialRaisedButton2
            // 
            this.materialRaisedButton2.AutoSize = true;
            this.materialRaisedButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton2.Depth = 0;
            this.materialRaisedButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialRaisedButton2.Icon = null;
            this.materialRaisedButton2.Location = new System.Drawing.Point(175, 0);
            this.materialRaisedButton2.MinimumSize = new System.Drawing.Size(893, 54);
            this.materialRaisedButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton2.Name = "materialRaisedButton2";
            this.materialRaisedButton2.Primary = true;
            this.materialRaisedButton2.Size = new System.Drawing.Size(893, 54);
            this.materialRaisedButton2.TabIndex = 23;
            this.materialRaisedButton2.UseVisualStyleBackColor = true;
            // 
            // mainTransactionPanel
            // 
            this.mainTransactionPanel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mainTransactionPanel.Controls.Add(this.button3);
            this.mainTransactionPanel.Controls.Add(this.button1);
            this.mainTransactionPanel.Controls.Add(this.monthCalendar2);
            this.mainTransactionPanel.Controls.Add(this.myTransactionPanel);
            this.mainTransactionPanel.Location = new System.Drawing.Point(176, 51);
            this.mainTransactionPanel.Name = "mainTransactionPanel";
            this.mainTransactionPanel.Size = new System.Drawing.Size(883, 481);
            this.mainTransactionPanel.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(-1, 1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(230, 43);
            this.button3.TabIndex = 20;
            this.button3.Text = "Choose Date";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(229, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(654, 44);
            this.button1.TabIndex = 19;
            this.button1.Text = "DAILY TRANSACTION  TABLE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(2, 42);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 18;
            this.monthCalendar2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar2_DateChanged);
            // 
            // UserDetails
            // 
            this.UserDetails.AutoSize = true;
            this.UserDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UserDetails.Depth = 0;
            this.UserDetails.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UserDetails.Icon = null;
            this.UserDetails.Location = new System.Drawing.Point(981, 8);
            this.UserDetails.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UserDetails.MaximumSize = new System.Drawing.Size(76, 36);
            this.UserDetails.MinimumSize = new System.Drawing.Size(76, 36);
            this.UserDetails.MouseState = MaterialSkin.MouseState.HOVER;
            this.UserDetails.Name = "UserDetails";
            this.UserDetails.Primary = false;
            this.UserDetails.Size = new System.Drawing.Size(76, 36);
            this.UserDetails.TabIndex = 24;
            this.UserDetails.Text = "USER";
            this.UserDetails.UseVisualStyleBackColor = true;
            this.UserDetails.Click += new System.EventHandler(this.UserDetails_Click);
            // 
            // UserAccount
            // 
            this.UserAccount.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.UserAccount.Controls.Add(this.Logout);
            this.UserAccount.Controls.Add(this.UserDetailTab);
            this.UserAccount.Location = new System.Drawing.Point(175, 55);
            this.UserAccount.Name = "UserAccount";
            this.UserAccount.Size = new System.Drawing.Size(886, 477);
            this.UserAccount.TabIndex = 3;
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Logout.Depth = 0;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Logout.Icon = null;
            this.Logout.Location = new System.Drawing.Point(743, 8);
            this.Logout.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Logout.MouseState = MaterialSkin.MouseState.HOVER;
            this.Logout.Name = "Logout";
            this.Logout.Primary = false;
            this.Logout.Size = new System.Drawing.Size(74, 36);
            this.Logout.TabIndex = 1;
            this.Logout.Text = "LOGOUT";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // UserDetailTab
            // 
            this.UserDetailTab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.UserDetailTab.Controls.Add(this.tabPage3);
            this.UserDetailTab.Controls.Add(this.tabPage4);
            this.UserDetailTab.Location = new System.Drawing.Point(91, 53);
            this.UserDetailTab.Name = "UserDetailTab";
            this.UserDetailTab.SelectedIndex = 0;
            this.UserDetailTab.Size = new System.Drawing.Size(726, 375);
            this.UserDetailTab.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage3.Controls.Add(this.DeleteUser);
            this.tabPage3.Controls.Add(this.EventRecuring);
            this.tabPage3.Controls.Add(this.UpdateUser);
            this.tabPage3.Controls.Add(this.materialLabel2);
            this.tabPage3.Controls.Add(this.NameTxt);
            this.tabPage3.Controls.Add(this.materialLabel1);
            this.tabPage3.Controls.Add(this.EmailTxt);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(718, 346);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "User Details";
            // 
            // DeleteUser
            // 
            this.DeleteUser.AutoSize = true;
            this.DeleteUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteUser.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DeleteUser.Depth = 0;
            this.DeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.DeleteUser.ForeColor = System.Drawing.Color.Maroon;
            this.DeleteUser.Icon = null;
            this.DeleteUser.Location = new System.Drawing.Point(582, 310);
            this.DeleteUser.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Primary = false;
            this.DeleteUser.Size = new System.Drawing.Size(136, 36);
            this.DeleteUser.TabIndex = 4;
            this.DeleteUser.Text = "Delete Account";
            this.DeleteUser.UseVisualStyleBackColor = false;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // EventRecuring
            // 
            this.EventRecuring.AutoSize = true;
            this.EventRecuring.Depth = 0;
            this.EventRecuring.Enabled = false;
            this.EventRecuring.Font = new System.Drawing.Font("Roboto", 11F);
            this.EventRecuring.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.EventRecuring.Location = new System.Drawing.Point(215, 18);
            this.EventRecuring.MouseState = MaterialSkin.MouseState.HOVER;
            this.EventRecuring.Name = "EventRecuring";
            this.EventRecuring.Size = new System.Drawing.Size(92, 19);
            this.EventRecuring.TabIndex = 12;
            this.EventRecuring.Text = "Last Access";
            // 
            // UpdateUser
            // 
            this.UpdateUser.AutoSize = true;
            this.UpdateUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateUser.Depth = 0;
            this.UpdateUser.Icon = null;
            this.UpdateUser.Location = new System.Drawing.Point(308, 227);
            this.UpdateUser.MinimumSize = new System.Drawing.Size(197, 36);
            this.UpdateUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateUser.Name = "UpdateUser";
            this.UpdateUser.Primary = true;
            this.UpdateUser.Size = new System.Drawing.Size(197, 36);
            this.UpdateUser.TabIndex = 4;
            this.UpdateUser.Text = "UPDATE";
            this.UpdateUser.UseVisualStyleBackColor = true;
            this.UpdateUser.Click += new System.EventHandler(this.UpdateUser_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(131, 71);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(57, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "EMAIL:";
            // 
            // NameTxt
            // 
            this.NameTxt.Depth = 0;
            this.NameTxt.Hint = "";
            this.NameTxt.Location = new System.Drawing.Point(221, 139);
            this.NameTxt.MaxLength = 32767;
            this.NameTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.PasswordChar = '\0';
            this.NameTxt.SelectedText = "";
            this.NameTxt.SelectionLength = 0;
            this.NameTxt.SelectionStart = 0;
            this.NameTxt.Size = new System.Drawing.Size(336, 23);
            this.NameTxt.TabIndex = 10;
            this.NameTxt.TabStop = false;
            this.NameTxt.Text = "NAME";
            this.NameTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(131, 143);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(56, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "NAME:";
            // 
            // EmailTxt
            // 
            this.EmailTxt.Depth = 0;
            this.EmailTxt.Enabled = false;
            this.EmailTxt.Hint = "";
            this.EmailTxt.Location = new System.Drawing.Point(221, 67);
            this.EmailTxt.MaxLength = 32767;
            this.EmailTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.PasswordChar = '\0';
            this.EmailTxt.SelectedText = "";
            this.EmailTxt.SelectionLength = 0;
            this.EmailTxt.SelectionStart = 0;
            this.EmailTxt.Size = new System.Drawing.Size(336, 23);
            this.EmailTxt.TabIndex = 11;
            this.EmailTxt.TabStop = false;
            this.EmailTxt.Text = "Email";
            this.EmailTxt.UseSystemPasswordChar = false;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage4.Controls.Add(this.ShowUserPassword);
            this.tabPage4.Controls.Add(this.ChangePassword);
            this.tabPage4.Controls.Add(this.materialLabel5);
            this.tabPage4.Controls.Add(this.PasswordConfirmTxt);
            this.tabPage4.Controls.Add(this.materialLabel4);
            this.tabPage4.Controls.Add(this.PasswordTxt);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(718, 346);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Change Password";
            // 
            // ShowUserPassword
            // 
            this.ShowUserPassword.AutoSize = true;
            this.ShowUserPassword.Location = new System.Drawing.Point(459, 185);
            this.ShowUserPassword.Name = "ShowUserPassword";
            this.ShowUserPassword.Size = new System.Drawing.Size(102, 17);
            this.ShowUserPassword.TabIndex = 17;
            this.ShowUserPassword.Text = "Show Password";
            this.ShowUserPassword.UseVisualStyleBackColor = true;
            this.ShowUserPassword.CheckedChanged += new System.EventHandler(this.ShowUserPassword_CheckedChanged);
            // 
            // ChangePassword
            // 
            this.ChangePassword.AutoSize = true;
            this.ChangePassword.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChangePassword.Depth = 0;
            this.ChangePassword.Icon = null;
            this.ChangePassword.Location = new System.Drawing.Point(291, 207);
            this.ChangePassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Primary = true;
            this.ChangePassword.Size = new System.Drawing.Size(144, 36);
            this.ChangePassword.TabIndex = 14;
            this.ChangePassword.Text = "CHANGE PASWORD";
            this.ChangePassword.UseVisualStyleBackColor = true;
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(168, 143);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(63, 19);
            this.materialLabel5.TabIndex = 16;
            this.materialLabel5.Text = "Confirm";
            // 
            // PasswordConfirmTxt
            // 
            this.PasswordConfirmTxt.Depth = 0;
            this.PasswordConfirmTxt.Hint = "";
            this.PasswordConfirmTxt.Location = new System.Drawing.Point(275, 143);
            this.PasswordConfirmTxt.MaxLength = 32767;
            this.PasswordConfirmTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordConfirmTxt.Name = "PasswordConfirmTxt";
            this.PasswordConfirmTxt.PasswordChar = '*';
            this.PasswordConfirmTxt.SelectedText = "";
            this.PasswordConfirmTxt.SelectionLength = 0;
            this.PasswordConfirmTxt.SelectionStart = 0;
            this.PasswordConfirmTxt.Size = new System.Drawing.Size(214, 23);
            this.PasswordConfirmTxt.TabIndex = 13;
            this.PasswordConfirmTxt.TabStop = false;
            this.PasswordConfirmTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(168, 88);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(75, 19);
            this.materialLabel4.TabIndex = 15;
            this.materialLabel4.Text = "Password";
            // 
            // PasswordTxt
            // 
            this.PasswordTxt.Depth = 0;
            this.PasswordTxt.Hint = "";
            this.PasswordTxt.Location = new System.Drawing.Point(275, 84);
            this.PasswordTxt.MaxLength = 32767;
            this.PasswordTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.PasswordTxt.Name = "PasswordTxt";
            this.PasswordTxt.PasswordChar = '*';
            this.PasswordTxt.SelectedText = "";
            this.PasswordTxt.SelectionLength = 0;
            this.PasswordTxt.SelectionStart = 0;
            this.PasswordTxt.Size = new System.Drawing.Size(214, 23);
            this.PasswordTxt.TabIndex = 12;
            this.PasswordTxt.TabStop = false;
            this.PasswordTxt.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(45, 16);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(72, 19);
            this.materialLabel3.TabIndex = 26;
            this.materialLabel3.Text = "Welcome";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1059, 531);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.UserDetails);
            this.Controls.Add(this.ViewEvent);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.DailyTransView);
            this.Controls.Add(this.GenerateReport);
            this.Controls.Add(this.ManageContact);
            this.Controls.Add(this.ExpensePrediction);
            this.Controls.Add(this.ManageEvent);
            this.Controls.Add(this.ManageTransaction);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.materialRaisedButton2);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.UserAccount);
            this.Controls.Add(this.PredictionPanel);
            this.Controls.Add(this.EventPanel);
            this.Controls.Add(this.mainTransactionPanel);
            this.MaximumSize = new System.Drawing.Size(1075, 570);
            this.MinimumSize = new System.Drawing.Size(1075, 570);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.PredictionPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.EventPanel.ResumeLayout(false);
            this.EventPanel.PerformLayout();
            this.mainTransactionPanel.ResumeLayout(false);
            this.UserAccount.ResumeLayout(false);
            this.UserAccount.PerformLayout();
            this.UserDetailTab.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialFlatButton Home;
        private MaterialSkin.Controls.MaterialRaisedButton ManageTransaction;
        private MaterialSkin.Controls.MaterialRaisedButton ManageEvent;
        private MaterialSkin.Controls.MaterialFlatButton ExpensePrediction;
        private MaterialSkin.Controls.MaterialRaisedButton ManageContact;
        private System.Windows.Forms.Panel PredictionPanel;
        private MaterialSkin.Controls.MaterialRaisedButton GenerateReport;
        private System.ComponentModel.BackgroundWorker RecuringAppRunner;
        private System.Windows.Forms.Button GeneratePrediction;
        private System.Windows.Forms.DateTimePicker PredictionDate;
        private System.Windows.Forms.Panel myTransactionPanel;
        private MaterialSkin.Controls.MaterialFlatButton DailyTransView;
        private MaterialSkin.Controls.MaterialRaisedButton UserName;
        private MaterialSkin.Controls.MaterialFlatButton ViewEvent;
        private System.Windows.Forms.Panel EventPanel;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private MaterialSkin.Controls.MaterialListView EventListView;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button predictionValueLabel;
        private System.Windows.Forms.Panel mainTransactionPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private MaterialSkin.Controls.MaterialFlatButton UserDetails;
        private Panel UserAccount;
        private MaterialSkin.Controls.MaterialFlatButton Logout;
        private MaterialSkin.Controls.MaterialSingleLineTextField PasswordConfirmTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField PasswordTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField EmailTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField NameTxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton UpdateUser;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private TabControl UserDetailTab;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private MaterialSkin.Controls.MaterialLabel EventRecuring;
        private MaterialSkin.Controls.MaterialFlatButton DeleteUser;
        private CheckBox ShowUserPassword;
        private MaterialSkin.Controls.MaterialRaisedButton ChangePassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFlatButton RecurringDateStamp;
    }
}