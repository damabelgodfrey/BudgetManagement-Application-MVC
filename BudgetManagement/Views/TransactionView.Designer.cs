using System.Windows.Forms;

namespace BudgetManagement.Views
{
    partial class TransactionView
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
            this.transDetailBox = new System.Windows.Forms.GroupBox();
            this.RefreshView = new System.Windows.Forms.Button();
            this.tAmountTbox = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tNoteTbox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcontactTbox = new System.Windows.Forms.TextBox();
            this.tContactCombobox = new System.Windows.Forms.ComboBox();
            this.tDatePicker = new System.Windows.Forms.DateTimePicker();
            this.tID = new System.Windows.Forms.Label();
            this.tIDtbox = new System.Windows.Forms.TextBox();
            this.tNameTbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.expenseTRbtn = new System.Windows.Forms.RadioButton();
            this.incomeTRbtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateTBtn = new System.Windows.Forms.Button();
            this.DeleteTBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SubmitTrans = new System.Windows.Forms.Button();
            this.cancelTBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.transGridView = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.addTBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.SubmitRTransaction = new System.Windows.Forms.Button();
            this.CancelRTransaction = new System.Windows.Forms.Button();
            this.UpdateRTransaction = new System.Windows.Forms.Button();
            this.DeleteRTransaction = new System.Windows.Forms.Button();
            this.RTransListView = new System.Windows.Forms.ListView();
            this.rTransDetailBox = new System.Windows.Forms.GroupBox();
            this.RefreshRView = new System.Windows.Forms.Button();
            this.rTransAmount = new System.Windows.Forms.NumericUpDown();
            this.rTransFrequency = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rExpense = new System.Windows.Forms.RadioButton();
            this.rIncome = new System.Windows.Forms.RadioButton();
            this.rTransFrequencyList = new System.Windows.Forms.ComboBox();
            this.rTransContactList = new System.Windows.Forms.ComboBox();
            this.rTransEndPeriod = new System.Windows.Forms.DateTimePicker();
            this.rTransStartPeriod = new System.Windows.Forms.DateTimePicker();
            this.rTransNote = new System.Windows.Forms.RichTextBox();
            this.rTransContact = new System.Windows.Forms.TextBox();
            this.rTransName = new System.Windows.Forms.TextBox();
            this.rID = new System.Windows.Forms.TextBox();
            this.AddRTransaction = new System.Windows.Forms.Button();
            this.transDetailBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAmountTbox)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.rTransDetailBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rTransAmount)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // transDetailBox
            // 
            this.transDetailBox.Controls.Add(this.RefreshView);
            this.transDetailBox.Controls.Add(this.tAmountTbox);
            this.transDetailBox.Controls.Add(this.groupBox5);
            this.transDetailBox.Controls.Add(this.groupBox1);
            this.transDetailBox.Controls.Add(this.tDatePicker);
            this.transDetailBox.Controls.Add(this.tID);
            this.transDetailBox.Controls.Add(this.tIDtbox);
            this.transDetailBox.Controls.Add(this.tNameTbox);
            this.transDetailBox.Controls.Add(this.groupBox2);
            this.transDetailBox.Controls.Add(this.label3);
            this.transDetailBox.Controls.Add(this.label2);
            this.transDetailBox.Controls.Add(this.label1);
            this.transDetailBox.Location = new System.Drawing.Point(6, 3);
            this.transDetailBox.Name = "transDetailBox";
            this.transDetailBox.Size = new System.Drawing.Size(828, 156);
            this.transDetailBox.TabIndex = 0;
            this.transDetailBox.TabStop = false;
            this.transDetailBox.Text = "Transaction Details";
            // 
            // RefreshView
            // 
            this.RefreshView.Location = new System.Drawing.Point(757, 127);
            this.RefreshView.Name = "RefreshView";
            this.RefreshView.Size = new System.Drawing.Size(69, 23);
            this.RefreshView.TabIndex = 22;
            this.RefreshView.Text = "Refresh";
            this.RefreshView.UseVisualStyleBackColor = true;
            this.RefreshView.Click += new System.EventHandler(this.RefreshView_Click);
            // 
            // tAmountTbox
            // 
            this.tAmountTbox.DecimalPlaces = 2;
            this.tAmountTbox.Location = new System.Drawing.Point(249, 35);
            this.tAmountTbox.Maximum = new decimal(new int[] {
            1316134912,
            2328,
            0,
            0});
            this.tAmountTbox.Name = "tAmountTbox";
            this.tAmountTbox.Size = new System.Drawing.Size(177, 20);
            this.tAmountTbox.TabIndex = 21;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tNoteTbox);
            this.groupBox5.Location = new System.Drawing.Point(453, 69);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(303, 79);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Note";
            // 
            // tNoteTbox
            // 
            this.tNoteTbox.Location = new System.Drawing.Point(19, 17);
            this.tNoteTbox.Name = "tNoteTbox";
            this.tNoteTbox.Size = new System.Drawing.Size(265, 51);
            this.tNoteTbox.TabIndex = 15;
            this.tNoteTbox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tcontactTbox);
            this.groupBox1.Controls.Add(this.tContactCombobox);
            this.groupBox1.Location = new System.Drawing.Point(243, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 79);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact";
            // 
            // tcontactTbox
            // 
            this.tcontactTbox.Location = new System.Drawing.Point(6, 17);
            this.tcontactTbox.Name = "tcontactTbox";
            this.tcontactTbox.Size = new System.Drawing.Size(177, 20);
            this.tcontactTbox.TabIndex = 16;
            // 
            // tContactCombobox
            // 
            this.tContactCombobox.DropDownHeight = 200;
            this.tContactCombobox.FormattingEnabled = true;
            this.tContactCombobox.IntegralHeight = false;
            this.tContactCombobox.Location = new System.Drawing.Point(6, 47);
            this.tContactCombobox.Name = "tContactCombobox";
            this.tContactCombobox.Size = new System.Drawing.Size(177, 21);
            this.tContactCombobox.TabIndex = 9;
            this.tContactCombobox.Text = "--Select a Contact--";
            this.tContactCombobox.SelectedIndexChanged += new System.EventHandler(this.TContactCombobox_SelectedIndexChanged);
            // 
            // tDatePicker
            // 
            this.tDatePicker.CustomFormat = "dd-MM-yyyy hh:mm";
            this.tDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tDatePicker.Location = new System.Drawing.Point(472, 34);
            this.tDatePicker.Name = "tDatePicker";
            this.tDatePicker.Size = new System.Drawing.Size(284, 20);
            this.tDatePicker.TabIndex = 17;
            this.tDatePicker.Value = new System.DateTime(2019, 12, 2, 0, 0, 0, 0);
            // 
            // tID
            // 
            this.tID.AutoSize = true;
            this.tID.Location = new System.Drawing.Point(8, 19);
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(18, 13);
            this.tID.TabIndex = 13;
            this.tID.Text = "ID";
            // 
            // tIDtbox
            // 
            this.tIDtbox.Location = new System.Drawing.Point(9, 34);
            this.tIDtbox.Name = "tIDtbox";
            this.tIDtbox.ReadOnly = true;
            this.tIDtbox.Size = new System.Drawing.Size(56, 20);
            this.tIDtbox.TabIndex = 12;
            // 
            // tNameTbox
            // 
            this.tNameTbox.Location = new System.Drawing.Point(71, 34);
            this.tNameTbox.MaxLength = 32;
            this.tNameTbox.Name = "tNameTbox";
            this.tNameTbox.Size = new System.Drawing.Size(172, 20);
            this.tNameTbox.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.expenseTRbtn);
            this.groupBox2.Controls.Add(this.incomeTRbtn);
            this.groupBox2.Location = new System.Drawing.Point(6, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 77);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Type";
            // 
            // expenseTRbtn
            // 
            this.expenseTRbtn.AutoSize = true;
            this.expenseTRbtn.Location = new System.Drawing.Point(133, 29);
            this.expenseTRbtn.Name = "expenseTRbtn";
            this.expenseTRbtn.Size = new System.Drawing.Size(66, 17);
            this.expenseTRbtn.TabIndex = 1;
            this.expenseTRbtn.TabStop = true;
            this.expenseTRbtn.Text = "Expense";
            this.expenseTRbtn.UseVisualStyleBackColor = true;
            // 
            // incomeTRbtn
            // 
            this.incomeTRbtn.AutoSize = true;
            this.incomeTRbtn.Location = new System.Drawing.Point(26, 29);
            this.incomeTRbtn.Name = "incomeTRbtn";
            this.incomeTRbtn.Size = new System.Drawing.Size(60, 17);
            this.incomeTRbtn.TabIndex = 0;
            this.incomeTRbtn.TabStop = true;
            this.incomeTRbtn.Text = "Income";
            this.incomeTRbtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // UpdateTBtn
            // 
            this.UpdateTBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.UpdateTBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateTBtn.Location = new System.Drawing.Point(11, 35);
            this.UpdateTBtn.Name = "UpdateTBtn";
            this.UpdateTBtn.Size = new System.Drawing.Size(155, 30);
            this.UpdateTBtn.TabIndex = 2;
            this.UpdateTBtn.Text = "Update Transaction";
            this.UpdateTBtn.UseVisualStyleBackColor = true;
            this.UpdateTBtn.Click += new System.EventHandler(this.UpdateTBtn_Click);
            // 
            // DeleteTBtn
            // 
            this.DeleteTBtn.Location = new System.Drawing.Point(12, 98);
            this.DeleteTBtn.Name = "DeleteTBtn";
            this.DeleteTBtn.Size = new System.Drawing.Size(155, 30);
            this.DeleteTBtn.TabIndex = 3;
            this.DeleteTBtn.Text = "DeleteTransation";
            this.DeleteTBtn.UseVisualStyleBackColor = true;
            this.DeleteTBtn.Click += new System.EventHandler(this.DeleteTBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SubmitTrans);
            this.groupBox3.Controls.Add(this.cancelTBtn);
            this.groupBox3.Controls.Add(this.DeleteTBtn);
            this.groupBox3.Controls.Add(this.UpdateTBtn);
            this.groupBox3.Location = new System.Drawing.Point(846, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 155);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // SubmitTrans
            // 
            this.SubmitTrans.Location = new System.Drawing.Point(12, 35);
            this.SubmitTrans.Name = "SubmitTrans";
            this.SubmitTrans.Size = new System.Drawing.Size(155, 31);
            this.SubmitTrans.TabIndex = 5;
            this.SubmitTrans.Text = "Submit";
            this.SubmitTrans.UseVisualStyleBackColor = true;
            this.SubmitTrans.Visible = false;
            this.SubmitTrans.Click += new System.EventHandler(this.SubmitTrans_Click);
            // 
            // cancelTBtn
            // 
            this.cancelTBtn.ForeColor = System.Drawing.Color.Maroon;
            this.cancelTBtn.Location = new System.Drawing.Point(12, 102);
            this.cancelTBtn.Name = "cancelTBtn";
            this.cancelTBtn.Size = new System.Drawing.Size(155, 28);
            this.cancelTBtn.TabIndex = 4;
            this.cancelTBtn.Text = "Cancel";
            this.cancelTBtn.UseVisualStyleBackColor = true;
            this.cancelTBtn.Visible = false;
            this.cancelTBtn.Click += new System.EventHandler(this.CancelTBtn_Click);
            // 
            // transGridView
            // 
            this.transGridView.AllowColumnReorder = true;
            this.transGridView.AutoArrange = false;
            this.transGridView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.transGridView.FullRowSelect = true;
            this.transGridView.GridLines = true;
            this.transGridView.HideSelection = false;
            this.transGridView.Location = new System.Drawing.Point(0, 204);
            this.transGridView.Name = "transGridView";
            this.transGridView.ShowItemToolTips = true;
            this.transGridView.Size = new System.Drawing.Size(834, 281);
            this.transGridView.TabIndex = 5;
            this.transGridView.UseCompatibleStateImageBehavior = false;
            this.transGridView.View = System.Windows.Forms.View.Details;
            this.transGridView.SelectedIndexChanged += new System.EventHandler(this.TransGridView_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1056, 517);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.addTBtn);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.transDetailBox);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.transGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1048, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Transaction";
            // 
            // addTBtn
            // 
            this.addTBtn.BackColor = System.Drawing.Color.SkyBlue;
            this.addTBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTBtn.Location = new System.Drawing.Point(858, 166);
            this.addTBtn.Name = "addTBtn";
            this.addTBtn.Size = new System.Drawing.Size(155, 116);
            this.addTBtn.TabIndex = 7;
            this.addTBtn.Text = "ADD TRANSACTION";
            this.addTBtn.UseVisualStyleBackColor = false;
            this.addTBtn.Click += new System.EventHandler(this.adTBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(831, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "TRANSACTION TABLE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.RTransListView);
            this.tabPage2.Controls.Add(this.rTransDetailBox);
            this.tabPage2.Controls.Add(this.AddRTransaction);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1048, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recurrent Transaction";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(3, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1042, 30);
            this.button2.TabIndex = 12;
            this.button2.Text = "RECURRING TRANSACTION TABLE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.SubmitRTransaction);
            this.groupBox4.Controls.Add(this.CancelRTransaction);
            this.groupBox4.Controls.Add(this.UpdateRTransaction);
            this.groupBox4.Controls.Add(this.DeleteRTransaction);
            this.groupBox4.Location = new System.Drawing.Point(888, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(154, 195);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Controls";
            // 
            // SubmitRTransaction
            // 
            this.SubmitRTransaction.BackColor = System.Drawing.SystemColors.Control;
            this.SubmitRTransaction.Location = new System.Drawing.Point(20, 40);
            this.SubmitRTransaction.Name = "SubmitRTransaction";
            this.SubmitRTransaction.Size = new System.Drawing.Size(120, 30);
            this.SubmitRTransaction.TabIndex = 10;
            this.SubmitRTransaction.Text = "Submit";
            this.SubmitRTransaction.UseVisualStyleBackColor = false;
            this.SubmitRTransaction.Visible = false;
            this.SubmitRTransaction.Click += new System.EventHandler(this.RegisterRTransaction_Click_1);
            // 
            // CancelRTransaction
            // 
            this.CancelRTransaction.BackColor = System.Drawing.SystemColors.Control;
            this.CancelRTransaction.ForeColor = System.Drawing.Color.Maroon;
            this.CancelRTransaction.Location = new System.Drawing.Point(20, 112);
            this.CancelRTransaction.Name = "CancelRTransaction";
            this.CancelRTransaction.Size = new System.Drawing.Size(120, 32);
            this.CancelRTransaction.TabIndex = 8;
            this.CancelRTransaction.Text = "Cancel";
            this.CancelRTransaction.UseVisualStyleBackColor = false;
            this.CancelRTransaction.Visible = false;
            this.CancelRTransaction.Click += new System.EventHandler(this.CancelRTransaction_Click);
            // 
            // UpdateRTransaction
            // 
            this.UpdateRTransaction.BackColor = System.Drawing.SystemColors.Control;
            this.UpdateRTransaction.Location = new System.Drawing.Point(20, 39);
            this.UpdateRTransaction.Name = "UpdateRTransaction";
            this.UpdateRTransaction.Size = new System.Drawing.Size(120, 31);
            this.UpdateRTransaction.TabIndex = 6;
            this.UpdateRTransaction.Text = "Update Transaction";
            this.UpdateRTransaction.UseVisualStyleBackColor = false;
            this.UpdateRTransaction.Click += new System.EventHandler(this.UpdateRecurring_Click);
            // 
            // DeleteRTransaction
            // 
            this.DeleteRTransaction.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteRTransaction.Location = new System.Drawing.Point(20, 112);
            this.DeleteRTransaction.Name = "DeleteRTransaction";
            this.DeleteRTransaction.Size = new System.Drawing.Size(120, 32);
            this.DeleteRTransaction.TabIndex = 7;
            this.DeleteRTransaction.Text = "Delete";
            this.DeleteRTransaction.UseVisualStyleBackColor = false;
            this.DeleteRTransaction.Click += new System.EventHandler(this.DeleteRTransaction_Click_1);
            // 
            // RTransListView
            // 
            this.RTransListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTransListView.FullRowSelect = true;
            this.RTransListView.GridLines = true;
            this.RTransListView.HideSelection = false;
            this.RTransListView.Location = new System.Drawing.Point(3, 241);
            this.RTransListView.Name = "RTransListView";
            this.RTransListView.Size = new System.Drawing.Size(879, 247);
            this.RTransListView.TabIndex = 4;
            this.RTransListView.UseCompatibleStateImageBehavior = false;
            this.RTransListView.View = System.Windows.Forms.View.Details;
            this.RTransListView.SelectedIndexChanged += new System.EventHandler(this.RTransListView_SelectedIndexChanged);
            // 
            // rTransDetailBox
            // 
            this.rTransDetailBox.Controls.Add(this.RefreshRView);
            this.rTransDetailBox.Controls.Add(this.rTransAmount);
            this.rTransDetailBox.Controls.Add(this.rTransFrequency);
            this.rTransDetailBox.Controls.Add(this.materialLabel1);
            this.rTransDetailBox.Controls.Add(this.label11);
            this.rTransDetailBox.Controls.Add(this.label10);
            this.rTransDetailBox.Controls.Add(this.label9);
            this.rTransDetailBox.Controls.Add(this.label8);
            this.rTransDetailBox.Controls.Add(this.label7);
            this.rTransDetailBox.Controls.Add(this.label6);
            this.rTransDetailBox.Controls.Add(this.label5);
            this.rTransDetailBox.Controls.Add(this.groupBox7);
            this.rTransDetailBox.Controls.Add(this.rTransFrequencyList);
            this.rTransDetailBox.Controls.Add(this.rTransContactList);
            this.rTransDetailBox.Controls.Add(this.rTransEndPeriod);
            this.rTransDetailBox.Controls.Add(this.rTransStartPeriod);
            this.rTransDetailBox.Controls.Add(this.rTransNote);
            this.rTransDetailBox.Controls.Add(this.rTransContact);
            this.rTransDetailBox.Controls.Add(this.rTransName);
            this.rTransDetailBox.Controls.Add(this.rID);
            this.rTransDetailBox.Location = new System.Drawing.Point(8, 6);
            this.rTransDetailBox.Name = "rTransDetailBox";
            this.rTransDetailBox.Size = new System.Drawing.Size(874, 195);
            this.rTransDetailBox.TabIndex = 0;
            this.rTransDetailBox.TabStop = false;
            this.rTransDetailBox.Text = "Update Recurrent Transaction";
            // 
            // RefreshRView
            // 
            this.RefreshRView.Location = new System.Drawing.Point(797, 170);
            this.RefreshRView.Name = "RefreshRView";
            this.RefreshRView.Size = new System.Drawing.Size(75, 23);
            this.RefreshRView.TabIndex = 22;
            this.RefreshRView.Text = "Refresh";
            this.RefreshRView.UseVisualStyleBackColor = true;
            this.RefreshRView.Click += new System.EventHandler(this.RefreshRView_Click);
            // 
            // rTransAmount
            // 
            this.rTransAmount.DecimalPlaces = 2;
            this.rTransAmount.Location = new System.Drawing.Point(400, 62);
            this.rTransAmount.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.rTransAmount.Name = "rTransAmount";
            this.rTransAmount.Size = new System.Drawing.Size(176, 20);
            this.rTransAmount.TabIndex = 21;
            // 
            // rTransFrequency
            // 
            this.rTransFrequency.Location = new System.Drawing.Point(668, 104);
            this.rTransFrequency.Name = "rTransFrequency";
            this.rTransFrequency.ReadOnly = true;
            this.rTransFrequency.Size = new System.Drawing.Size(200, 20);
            this.rTransFrequency.TabIndex = 19;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(333, 105);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(62, 19);
            this.materialLabel1.TabIndex = 17;
            this.materialLabel1.Text = "Contact";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(163, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Note";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(591, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "End Period";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(591, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Occurance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(591, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Start Period";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(334, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.rExpense);
            this.groupBox7.Controls.Add(this.rIncome);
            this.groupBox7.Location = new System.Drawing.Point(9, 77);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(148, 103);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Type";
            // 
            // rExpense
            // 
            this.rExpense.AutoSize = true;
            this.rExpense.Location = new System.Drawing.Point(72, 50);
            this.rExpense.Name = "rExpense";
            this.rExpense.Size = new System.Drawing.Size(66, 17);
            this.rExpense.TabIndex = 1;
            this.rExpense.TabStop = true;
            this.rExpense.Text = "Expense";
            this.rExpense.UseVisualStyleBackColor = true;
            // 
            // rIncome
            // 
            this.rIncome.AutoSize = true;
            this.rIncome.Location = new System.Drawing.Point(6, 50);
            this.rIncome.Name = "rIncome";
            this.rIncome.Size = new System.Drawing.Size(60, 17);
            this.rIncome.TabIndex = 0;
            this.rIncome.TabStop = true;
            this.rIncome.Text = "Income";
            this.rIncome.UseVisualStyleBackColor = true;
            // 
            // rTransFrequencyList
            // 
            this.rTransFrequencyList.FormattingEnabled = true;
            this.rTransFrequencyList.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.rTransFrequencyList.Location = new System.Drawing.Point(668, 142);
            this.rTransFrequencyList.Name = "rTransFrequencyList";
            this.rTransFrequencyList.Size = new System.Drawing.Size(200, 21);
            this.rTransFrequencyList.TabIndex = 8;
            this.rTransFrequencyList.Text = "--Select Frequency--";
            this.rTransFrequencyList.SelectedIndexChanged += new System.EventHandler(this.rTransFrequencyList_SelectedIndexChanged);
            // 
            // rTransContactList
            // 
            this.rTransContactList.FormattingEnabled = true;
            this.rTransContactList.Location = new System.Drawing.Point(400, 144);
            this.rTransContactList.Name = "rTransContactList";
            this.rTransContactList.Size = new System.Drawing.Size(176, 21);
            this.rTransContactList.TabIndex = 7;
            this.rTransContactList.Text = "--Select a Contact";
            this.rTransContactList.SelectedIndexChanged += new System.EventHandler(this.rTransContactList_SelectedIndexChanged);
            // 
            // rTransEndPeriod
            // 
            this.rTransEndPeriod.CustomFormat = "dd-MM-yyyy hh:mm";
            this.rTransEndPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rTransEndPeriod.Location = new System.Drawing.Point(668, 62);
            this.rTransEndPeriod.Name = "rTransEndPeriod";
            this.rTransEndPeriod.Size = new System.Drawing.Size(200, 20);
            this.rTransEndPeriod.TabIndex = 6;
            // 
            // rTransStartPeriod
            // 
            this.rTransStartPeriod.CustomFormat = "dd-MM-yyyy hh:mm";
            this.rTransStartPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rTransStartPeriod.Location = new System.Drawing.Point(668, 26);
            this.rTransStartPeriod.Name = "rTransStartPeriod";
            this.rTransStartPeriod.Size = new System.Drawing.Size(200, 20);
            this.rTransStartPeriod.TabIndex = 5;
            // 
            // rTransNote
            // 
            this.rTransNote.Location = new System.Drawing.Point(163, 98);
            this.rTransNote.Name = "rTransNote";
            this.rTransNote.Size = new System.Drawing.Size(164, 82);
            this.rTransNote.TabIndex = 4;
            this.rTransNote.Text = "";
            // 
            // rTransContact
            // 
            this.rTransContact.Location = new System.Drawing.Point(400, 104);
            this.rTransContact.Name = "rTransContact";
            this.rTransContact.Size = new System.Drawing.Size(176, 20);
            this.rTransContact.TabIndex = 3;
            // 
            // rTransName
            // 
            this.rTransName.Location = new System.Drawing.Point(166, 21);
            this.rTransName.MaxLength = 32;
            this.rTransName.Name = "rTransName";
            this.rTransName.Size = new System.Drawing.Size(410, 20);
            this.rTransName.TabIndex = 2;
            // 
            // rID
            // 
            this.rID.Location = new System.Drawing.Point(36, 21);
            this.rID.Name = "rID";
            this.rID.ReadOnly = true;
            this.rID.Size = new System.Drawing.Size(80, 20);
            this.rID.TabIndex = 0;
            // 
            // AddRTransaction
            // 
            this.AddRTransaction.BackColor = System.Drawing.SystemColors.Control;
            this.AddRTransaction.Location = new System.Drawing.Point(908, 248);
            this.AddRTransaction.Name = "AddRTransaction";
            this.AddRTransaction.Size = new System.Drawing.Size(120, 88);
            this.AddRTransaction.TabIndex = 9;
            this.AddRTransaction.Text = "ADD";
            this.AddRTransaction.UseVisualStyleBackColor = false;
            this.AddRTransaction.Click += new System.EventHandler(this.AddRTransaction_Click_1);
            // 
            // TransactionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 531);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1075, 570);
            this.MinimumSize = new System.Drawing.Size(1075, 570);
            this.Name = "TransactionView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionView";
            this.transDetailBox.ResumeLayout(false);
            this.transDetailBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAmountTbox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.rTransDetailBox.ResumeLayout(false);
            this.rTransDetailBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rTransAmount)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox transDetailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UpdateTBtn;
        private System.Windows.Forms.Button DeleteTBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton expenseTRbtn;
        private System.Windows.Forms.RadioButton incomeTRbtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tNameTbox;
        private System.Windows.Forms.Label tID;
        private System.Windows.Forms.TextBox tIDtbox;
        internal System.Windows.Forms.ListView transGridView;
        private System.Windows.Forms.Button cancelTBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox tNoteTbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker tDatePicker;
        private GroupBox rTransDetailBox;
        private TextBox rTransFrequency;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private GroupBox groupBox7;
        private RadioButton rExpense;
        private RadioButton rIncome;
        private ComboBox rTransFrequencyList;
        private DateTimePicker rTransEndPeriod;
        private DateTimePicker rTransStartPeriod;
        private RichTextBox rTransNote;
        private TextBox rTransContact;
        private TextBox rTransName;
        private TextBox rID;
        private ListView RTransListView;
        private NumericUpDown tAmountTbox;
        private NumericUpDown rTransAmount;
        private Button UpdateRTransaction;
        private Button DeleteRTransaction;
        private Button CancelRTransaction;
        private Button AddRTransaction;
        private Button SubmitRTransaction;
        private Button button1;
        private GroupBox groupBox4;
        private Button button2;
        private Button addTBtn;
        private Button SubmitTrans;
        private TextBox tcontactTbox;
        internal ComboBox tContactCombobox;
        internal ComboBox rTransContactList;
        private Button RefreshView;
        private Button RefreshRView;
    }
}