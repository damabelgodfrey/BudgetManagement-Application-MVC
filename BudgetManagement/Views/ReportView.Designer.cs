using System.Windows.Forms;

namespace BudgetManagement.Views
{
    partial class ReportView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.transDetailBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rNameTbox = new System.Windows.Forms.TextBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.AllName = new System.Windows.Forms.CheckBox();
            this.rEndDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AllContact = new System.Windows.Forms.CheckBox();
            this.rcontactTbox = new System.Windows.Forms.TextBox();
            this.rContactCombobox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GenerateReport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ReportViewGrid = new MaterialSkin.Controls.MaterialListView();
            this.button1 = new System.Windows.Forms.Button();
            this.totalIncome = new MaterialSkin.Controls.MaterialLabel();
            this.totalExpenses = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TName = new MaterialSkin.Controls.MaterialLabel();
            this.TContact = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.ReportPeriod = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.ReportDiff = new System.Windows.Forms.Button();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PlotGraph = new MaterialSkin.Controls.MaterialRaisedButton();
            this.MonthlyGraphPicker = new System.Windows.Forms.DateTimePicker();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TransactionReportMsg = new MaterialSkin.Controls.MaterialLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.IncomeTotalMsg = new MaterialSkin.Controls.MaterialLabel();
            this.IncomeBarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.IncomeLineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.ExpenseTotalMsg = new MaterialSkin.Controls.MaterialLabel();
            this.ExpenseBarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ExpenseLineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.transDetailBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeBarChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeLineChart)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseBarChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseLineChart)).BeginInit();
            this.SuspendLayout();
            // 
            // transDetailBox
            // 
            this.transDetailBox.BackColor = System.Drawing.SystemColors.Control;
            this.transDetailBox.Controls.Add(this.groupBox2);
            this.transDetailBox.Controls.Add(this.rEndDate);
            this.transDetailBox.Controls.Add(this.materialLabel2);
            this.transDetailBox.Controls.Add(this.StartTime);
            this.transDetailBox.Controls.Add(this.materialLabel1);
            this.transDetailBox.Controls.Add(this.groupBox1);
            this.transDetailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transDetailBox.Location = new System.Drawing.Point(6, 6);
            this.transDetailBox.Name = "transDetailBox";
            this.transDetailBox.Size = new System.Drawing.Size(827, 158);
            this.transDetailBox.TabIndex = 0;
            this.transDetailBox.TabStop = false;
            this.transDetailBox.Text = "Report Sort Criteria";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rNameTbox);
            this.groupBox2.Controls.Add(this.materialLabel3);
            this.groupBox2.Controls.Add(this.AllName);
            this.groupBox2.Location = new System.Drawing.Point(331, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 134);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Name";
            // 
            // rNameTbox
            // 
            this.rNameTbox.Location = new System.Drawing.Point(20, 58);
            this.rNameTbox.Name = "rNameTbox";
            this.rNameTbox.Size = new System.Drawing.Size(172, 26);
            this.rNameTbox.TabIndex = 7;
            this.rNameTbox.Text = "All";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(51, 96);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(92, 19);
            this.materialLabel3.TabIndex = 22;
            this.materialLabel3.Text = " Enter Name";
            // 
            // AllName
            // 
            this.AllName.AutoSize = true;
            this.AllName.Location = new System.Drawing.Point(18, 28);
            this.AllName.Name = "AllName";
            this.AllName.Size = new System.Drawing.Size(45, 24);
            this.AllName.TabIndex = 23;
            this.AllName.Text = "All";
            this.AllName.UseVisualStyleBackColor = true;
            this.AllName.CheckedChanged += new System.EventHandler(this.AllName_CheckedChanged);
            // 
            // rEndDate
            // 
            this.rEndDate.CustomFormat = "dd-MM-yyyy";
            this.rEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rEndDate.Location = new System.Drawing.Point(85, 83);
            this.rEndDate.Name = "rEndDate";
            this.rEndDate.Size = new System.Drawing.Size(199, 26);
            this.rEndDate.TabIndex = 21;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(7, 85);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(69, 19);
            this.materialLabel2.TabIndex = 20;
            this.materialLabel2.Text = "End Date";
            // 
            // StartTime
            // 
            this.StartTime.CustomFormat = "dd-MM-yyyy";
            this.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTime.Location = new System.Drawing.Point(85, 37);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(199, 26);
            this.StartTime.TabIndex = 17;
            this.StartTime.Value = new System.DateTime(2019, 12, 2, 0, 0, 0, 0);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(5, 36);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 19);
            this.materialLabel1.TabIndex = 19;
            this.materialLabel1.Text = "Start Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AllContact);
            this.groupBox1.Controls.Add(this.rcontactTbox);
            this.groupBox1.Controls.Add(this.rContactCombobox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(557, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(239, 135);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact";
            // 
            // AllContact
            // 
            this.AllContact.AutoSize = true;
            this.AllContact.Location = new System.Drawing.Point(14, 29);
            this.AllContact.Name = "AllContact";
            this.AllContact.Size = new System.Drawing.Size(42, 21);
            this.AllContact.TabIndex = 17;
            this.AllContact.Text = "All";
            this.AllContact.UseVisualStyleBackColor = true;
            this.AllContact.CheckedChanged += new System.EventHandler(this.AllContact_CheckedChanged);
            // 
            // rcontactTbox
            // 
            this.rcontactTbox.Location = new System.Drawing.Point(14, 59);
            this.rcontactTbox.Name = "rcontactTbox";
            this.rcontactTbox.Size = new System.Drawing.Size(177, 23);
            this.rcontactTbox.TabIndex = 16;
            this.rcontactTbox.Text = "All";
            // 
            // rContactCombobox
            // 
            this.rContactCombobox.DropDownHeight = 200;
            this.rContactCombobox.FormattingEnabled = true;
            this.rContactCombobox.IntegralHeight = false;
            this.rContactCombobox.Location = new System.Drawing.Point(15, 94);
            this.rContactCombobox.Name = "rContactCombobox";
            this.rContactCombobox.Size = new System.Drawing.Size(177, 24);
            this.rContactCombobox.TabIndex = 9;
            this.rContactCombobox.SelectedIndexChanged += new System.EventHandler(this.TContactCombobox_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.GenerateReport);
            this.groupBox3.Location = new System.Drawing.Point(839, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 157);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // GenerateReport
            // 
            this.GenerateReport.AutoSize = true;
            this.GenerateReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenerateReport.Depth = 0;
            this.GenerateReport.Icon = null;
            this.GenerateReport.Location = new System.Drawing.Point(28, 27);
            this.GenerateReport.MinimumSize = new System.Drawing.Size(144, 99);
            this.GenerateReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Primary = true;
            this.GenerateReport.Size = new System.Drawing.Size(144, 99);
            this.GenerateReport.TabIndex = 0;
            this.GenerateReport.Text = "Generate Report";
            this.GenerateReport.UseVisualStyleBackColor = true;
            this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
            // 
            // ReportViewGrid
            // 
            this.ReportViewGrid.AutoArrange = false;
            this.ReportViewGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReportViewGrid.CheckBoxes = true;
            this.ReportViewGrid.Depth = 0;
            this.ReportViewGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ReportViewGrid.FullRowSelect = true;
            this.ReportViewGrid.GridLines = true;
            this.ReportViewGrid.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ReportViewGrid.HideSelection = false;
            this.ReportViewGrid.Location = new System.Drawing.Point(0, 170);
            this.ReportViewGrid.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ReportViewGrid.MouseState = MaterialSkin.MouseState.OUT;
            this.ReportViewGrid.MultiSelect = false;
            this.ReportViewGrid.Name = "ReportViewGrid";
            this.ReportViewGrid.OwnerDraw = true;
            this.ReportViewGrid.ShowGroups = false;
            this.ReportViewGrid.Size = new System.Drawing.Size(759, 334);
            this.ReportViewGrid.TabIndex = 8;
            this.ReportViewGrid.UseCompatibleStateImageBehavior = false;
            this.ReportViewGrid.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Report Summary";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // totalIncome
            // 
            this.totalIncome.AutoSize = true;
            this.totalIncome.Depth = 0;
            this.totalIncome.Font = new System.Drawing.Font("Roboto", 11F);
            this.totalIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalIncome.Location = new System.Drawing.Point(141, 215);
            this.totalIncome.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalIncome.Name = "totalIncome";
            this.totalIncome.Size = new System.Drawing.Size(40, 19);
            this.totalIncome.TabIndex = 10;
            this.totalIncome.Text = "total";
            // 
            // totalExpenses
            // 
            this.totalExpenses.AutoSize = true;
            this.totalExpenses.Depth = 0;
            this.totalExpenses.Font = new System.Drawing.Font("Roboto", 11F);
            this.totalExpenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalExpenses.Location = new System.Drawing.Point(141, 178);
            this.totalExpenses.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalExpenses.Name = "totalExpenses";
            this.totalExpenses.Size = new System.Drawing.Size(40, 19);
            this.totalExpenses.TabIndex = 10;
            this.totalExpenses.Text = "total";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.TName);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TContact);
            this.panel1.Controls.Add(this.materialLabel8);
            this.panel1.Controls.Add(this.materialLabel7);
            this.panel1.Controls.Add(this.ReportPeriod);
            this.panel1.Controls.Add(this.materialLabel6);
            this.panel1.Controls.Add(this.ReportDiff);
            this.panel1.Controls.Add(this.materialLabel5);
            this.panel1.Controls.Add(this.materialLabel4);
            this.panel1.Controls.Add(this.totalExpenses);
            this.panel1.Controls.Add(this.totalIncome);
            this.panel1.Location = new System.Drawing.Point(765, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 310);
            this.panel1.TabIndex = 11;
            // 
            // TName
            // 
            this.TName.Depth = 0;
            this.TName.Font = new System.Drawing.Font("Roboto", 11F);
            this.TName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TName.Location = new System.Drawing.Point(141, 89);
            this.TName.MaximumSize = new System.Drawing.Size(125, 19);
            this.TName.MouseState = MaterialSkin.MouseState.HOVER;
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(125, 19);
            this.TName.TabIndex = 20;
            this.TName.Text = "All";
            // 
            // TContact
            // 
            this.TContact.Depth = 0;
            this.TContact.Font = new System.Drawing.Font("Roboto", 11F);
            this.TContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TContact.Location = new System.Drawing.Point(141, 126);
            this.TContact.MaximumSize = new System.Drawing.Size(125, 19);
            this.TContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.TContact.Name = "TContact";
            this.TContact.Size = new System.Drawing.Size(125, 19);
            this.TContact.TabIndex = 19;
            this.TContact.Text = "All";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(12, 125);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(92, 19);
            this.materialLabel8.TabIndex = 18;
            this.materialLabel8.Text = "Contact Ref:";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(13, 90);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(79, 19);
            this.materialLabel7.TabIndex = 17;
            this.materialLabel7.Text = "Name Ref:";
            // 
            // ReportPeriod
            // 
            this.ReportPeriod.Depth = 0;
            this.ReportPeriod.Font = new System.Drawing.Font("Roboto", 11F);
            this.ReportPeriod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ReportPeriod.Location = new System.Drawing.Point(91, 41);
            this.ReportPeriod.MouseState = MaterialSkin.MouseState.HOVER;
            this.ReportPeriod.Name = "ReportPeriod";
            this.ReportPeriod.Size = new System.Drawing.Size(181, 31);
            this.ReportPeriod.TabIndex = 15;
            this.ReportPeriod.Text = "period";
            this.ReportPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(14, 46);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(75, 24);
            this.materialLabel6.TabIndex = 14;
            this.materialLabel6.Text = "Period:";
            // 
            // ReportDiff
            // 
            this.ReportDiff.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ReportDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportDiff.Location = new System.Drawing.Point(5, 249);
            this.ReportDiff.Name = "ReportDiff";
            this.ReportDiff.Size = new System.Drawing.Size(258, 33);
            this.ReportDiff.TabIndex = 13;
            this.ReportDiff.Text = "diff";
            this.ReportDiff.UseVisualStyleBackColor = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(14, 214);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(111, 19);
            this.materialLabel5.TabIndex = 12;
            this.materialLabel5.Text = "Total Income £";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 177);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(117, 19);
            this.materialLabel4.TabIndex = 11;
            this.materialLabel4.Text = "Total Expense £";
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 531);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.transDetailBox);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.ReportViewGrid);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1051, 498);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generate Report";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage2.Controls.Add(this.PlotGraph);
            this.tabPage2.Controls.Add(this.MonthlyGraphPicker);
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.materialFlatButton1);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1051, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Monthly Graph View";
            // 
            // PlotGraph
            // 
            this.PlotGraph.AutoSize = true;
            this.PlotGraph.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PlotGraph.Depth = 0;
            this.PlotGraph.Icon = null;
            this.PlotGraph.Location = new System.Drawing.Point(646, 6);
            this.PlotGraph.MaximumSize = new System.Drawing.Size(0, 26);
            this.PlotGraph.MouseState = MaterialSkin.MouseState.HOVER;
            this.PlotGraph.Name = "PlotGraph";
            this.PlotGraph.Primary = true;
            this.PlotGraph.Size = new System.Drawing.Size(55, 26);
            this.PlotGraph.TabIndex = 5;
            this.PlotGraph.Text = "Plot";
            this.PlotGraph.UseVisualStyleBackColor = true;
            this.PlotGraph.Click += new System.EventHandler(this.PlotGraph_Click);
            // 
            // MonthlyGraphPicker
            // 
            this.MonthlyGraphPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthlyGraphPicker.Location = new System.Drawing.Point(442, 7);
            this.MonthlyGraphPicker.Name = "MonthlyGraphPicker";
            this.MonthlyGraphPicker.Size = new System.Drawing.Size(200, 23);
            this.MonthlyGraphPicker.TabIndex = 2;
            this.MonthlyGraphPicker.ValueChanged += new System.EventHandler(this.MonthlyGraphPicker_ValueChanged);
            // 
            // tabControl2
            // 
            this.tabControl2.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1037, 487);
            this.tabControl2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tabPage3.Controls.Add(this.TransactionReportMsg);
            this.tabPage3.Controls.Add(this.chart1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1029, 458);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Transaction Graph";
            // 
            // TransactionReportMsg
            // 
            this.TransactionReportMsg.AutoSize = true;
            this.TransactionReportMsg.BackColor = System.Drawing.Color.LightSalmon;
            this.TransactionReportMsg.Depth = 0;
            this.TransactionReportMsg.Font = new System.Drawing.Font("Roboto", 11F);
            this.TransactionReportMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TransactionReportMsg.Location = new System.Drawing.Point(380, 210);
            this.TransactionReportMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.TransactionReportMsg.Name = "TransactionReportMsg";
            this.TransactionReportMsg.Size = new System.Drawing.Size(329, 19);
            this.TransactionReportMsg.TabIndex = 2;
            this.TransactionReportMsg.Text = "No Income and Expense Recorded in this period";
            this.TransactionReportMsg.Visible = false;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 3);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(1023, 452);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.IncomeTotalMsg);
            this.tabPage4.Controls.Add(this.IncomeBarChart);
            this.tabPage4.Controls.Add(this.IncomeLineChart);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1029, 458);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Income Graph";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // IncomeTotalMsg
            // 
            this.IncomeTotalMsg.AutoSize = true;
            this.IncomeTotalMsg.BackColor = System.Drawing.Color.LightSalmon;
            this.IncomeTotalMsg.Depth = 0;
            this.IncomeTotalMsg.Font = new System.Drawing.Font("Roboto", 11F);
            this.IncomeTotalMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IncomeTotalMsg.Location = new System.Drawing.Point(391, 172);
            this.IncomeTotalMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.IncomeTotalMsg.Name = "IncomeTotalMsg";
            this.IncomeTotalMsg.Size = new System.Drawing.Size(258, 19);
            this.IncomeTotalMsg.TabIndex = 2;
            this.IncomeTotalMsg.Text = "No Income  Recorded in this Period...";
            this.IncomeTotalMsg.Visible = false;
            // 
            // IncomeBarChart
            // 
            this.IncomeBarChart.BackColor = System.Drawing.SystemColors.AppWorkspace;
            chartArea2.Name = "ChartArea1";
            this.IncomeBarChart.ChartAreas.Add(chartArea2);
            this.IncomeBarChart.Location = new System.Drawing.Point(532, 17);
            this.IncomeBarChart.Name = "IncomeBarChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.IncomeBarChart.Series.Add(series1);
            this.IncomeBarChart.Size = new System.Drawing.Size(491, 435);
            this.IncomeBarChart.TabIndex = 1;
            this.IncomeBarChart.Text = "chart3";
            // 
            // IncomeLineChart
            // 
            this.IncomeLineChart.BackColor = System.Drawing.SystemColors.AppWorkspace;
            chartArea3.Name = "ChartArea1";
            this.IncomeLineChart.ChartAreas.Add(chartArea3);
            this.IncomeLineChart.Location = new System.Drawing.Point(6, 17);
            this.IncomeLineChart.Name = "IncomeLineChart";
            this.IncomeLineChart.Size = new System.Drawing.Size(511, 435);
            this.IncomeLineChart.TabIndex = 0;
            this.IncomeLineChart.Text = "chart2";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.ExpenseTotalMsg);
            this.tabPage5.Controls.Add(this.ExpenseBarChart);
            this.tabPage5.Controls.Add(this.ExpenseLineChart);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1029, 458);
            this.tabPage5.TabIndex = 2;
            this.tabPage5.Text = "Expense Graph";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // ExpenseTotalMsg
            // 
            this.ExpenseTotalMsg.AutoSize = true;
            this.ExpenseTotalMsg.BackColor = System.Drawing.Color.LightSalmon;
            this.ExpenseTotalMsg.Depth = 0;
            this.ExpenseTotalMsg.Font = new System.Drawing.Font("Roboto", 11F);
            this.ExpenseTotalMsg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExpenseTotalMsg.Location = new System.Drawing.Point(381, 172);
            this.ExpenseTotalMsg.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExpenseTotalMsg.Name = "ExpenseTotalMsg";
            this.ExpenseTotalMsg.Size = new System.Drawing.Size(264, 19);
            this.ExpenseTotalMsg.TabIndex = 2;
            this.ExpenseTotalMsg.Text = "No Expense  Recorded in this Period...";
            // 
            // ExpenseBarChart
            // 
            this.ExpenseBarChart.BackColor = System.Drawing.SystemColors.AppWorkspace;
            chartArea4.Name = "ChartArea1";
            this.ExpenseBarChart.ChartAreas.Add(chartArea4);
            this.ExpenseBarChart.Location = new System.Drawing.Point(516, 7);
            this.ExpenseBarChart.Name = "ExpenseBarChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ExpenseBarChart.Series.Add(series2);
            this.ExpenseBarChart.Size = new System.Drawing.Size(507, 445);
            this.ExpenseBarChart.TabIndex = 1;
            this.ExpenseBarChart.Text = "chart3";
            // 
            // ExpenseLineChart
            // 
            this.ExpenseLineChart.BackColor = System.Drawing.SystemColors.AppWorkspace;
            chartArea5.Name = "ChartArea1";
            this.ExpenseLineChart.ChartAreas.Add(chartArea5);
            this.ExpenseLineChart.Location = new System.Drawing.Point(6, 6);
            this.ExpenseLineChart.Name = "ExpenseLineChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ExpenseLineChart.Series.Add(series3);
            this.ExpenseLineChart.Size = new System.Drawing.Size(504, 446);
            this.ExpenseLineChart.TabIndex = 0;
            this.ExpenseLineChart.Text = "chart2";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Icon = null;
            this.materialFlatButton1.Location = new System.Drawing.Point(0, -14);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(16, 36);
            this.materialFlatButton1.TabIndex = 3;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 531);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1075, 570);
            this.MinimumSize = new System.Drawing.Size(1075, 570);
            this.Name = "ReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORT VIEW BOARD";
            this.transDetailBox.ResumeLayout(false);
            this.transDetailBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeBarChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IncomeLineChart)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseBarChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpenseLineChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox transDetailBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox rNameTbox;
        private System.Windows.Forms.ComboBox rContactCombobox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox rcontactTbox;
        private System.Windows.Forms.DateTimePicker StartTime;
        private MaterialSkin.Controls.MaterialListView ReportViewGrid;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton GenerateReport;
        private DateTimePicker rEndDate;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private Button button1;
        private MaterialSkin.Controls.MaterialLabel totalIncome;
        private MaterialSkin.Controls.MaterialLabel totalExpenses;
        private Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private Button ReportDiff;
        private GroupBox groupBox2;
        private CheckBox AllName;
        private CheckBox AllContact;
        private MaterialSkin.Controls.MaterialLabel ReportPeriod;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel TName;
        private MaterialSkin.Controls.MaterialLabel TContact;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private DateTimePicker MonthlyGraphPicker;
        private TabControl tabControl2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private MaterialSkin.Controls.MaterialRaisedButton PlotGraph;
        private System.Windows.Forms.DataVisualization.Charting.Chart IncomeBarChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart IncomeLineChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ExpenseBarChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ExpenseLineChart;
        private MaterialSkin.Controls.MaterialLabel TransactionReportMsg;
        private MaterialSkin.Controls.MaterialLabel IncomeTotalMsg;
        private MaterialSkin.Controls.MaterialLabel ExpenseTotalMsg;
    }
}