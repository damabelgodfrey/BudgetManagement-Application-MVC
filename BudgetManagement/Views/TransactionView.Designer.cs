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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tNoteTbox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tcontactTbox = new System.Windows.Forms.TextBox();
            this.tContactCombobox = new System.Windows.Forms.ComboBox();
            this.tDatePicker = new System.Windows.Forms.DateTimePicker();
            this.tID = new System.Windows.Forms.Label();
            this.tIDtbox = new System.Windows.Forms.TextBox();
            this.tAmountTbox = new System.Windows.Forms.TextBox();
            this.tNameTbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.expenseTRbtn = new System.Windows.Forms.RadioButton();
            this.incomeTRbtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addTBtn = new System.Windows.Forms.Button();
            this.UpdateTBtn = new System.Windows.Forms.Button();
            this.DeleteTBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cancelTBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.transGridView = new System.Windows.Forms.ListView();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RTransListView = new System.Windows.Forms.ListView();
            this.DeleteRTransaction = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RegisterRTransaction = new MaterialSkin.Controls.MaterialRaisedButton();
            this.AddRTransaction = new MaterialSkin.Controls.MaterialRaisedButton();
            this.rTransDetailBox = new System.Windows.Forms.GroupBox();
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
            this.rTransAmount = new System.Windows.Forms.TextBox();
            this.rID = new System.Windows.Forms.TextBox();
            this.CancelAddRAction = new MaterialSkin.Controls.MaterialRaisedButton();
            this.transDetailBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.rTransDetailBox.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // transDetailBox
            // 
            this.transDetailBox.Controls.Add(this.groupBox5);
            this.transDetailBox.Controls.Add(this.groupBox1);
            this.transDetailBox.Controls.Add(this.tDatePicker);
            this.transDetailBox.Controls.Add(this.tID);
            this.transDetailBox.Controls.Add(this.tIDtbox);
            this.transDetailBox.Controls.Add(this.tAmountTbox);
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tNoteTbox);
            this.groupBox5.Location = new System.Drawing.Point(453, 69);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(346, 79);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Note";
            // 
            // tNoteTbox
            // 
            this.tNoteTbox.Location = new System.Drawing.Point(19, 17);
            this.tNoteTbox.Name = "tNoteTbox";
            this.tNoteTbox.Size = new System.Drawing.Size(306, 51);
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
            this.tContactCombobox.SelectedIndexChanged += new System.EventHandler(this.TContactCombobox_SelectedIndexChanged);
            // 
            // tDatePicker
            // 
            this.tDatePicker.CustomFormat = "dd-MM-yyyy hh:mm";
            this.tDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tDatePicker.Location = new System.Drawing.Point(494, 11);
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
            this.tIDtbox.Size = new System.Drawing.Size(56, 20);
            this.tIDtbox.TabIndex = 12;
            // 
            // tAmountTbox
            // 
            this.tAmountTbox.Location = new System.Drawing.Point(249, 34);
            this.tAmountTbox.Name = "tAmountTbox";
            this.tAmountTbox.Size = new System.Drawing.Size(177, 20);
            this.tAmountTbox.TabIndex = 8;
            // 
            // tNameTbox
            // 
            this.tNameTbox.Location = new System.Drawing.Point(71, 34);
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
            this.expenseTRbtn.Size = new System.Drawing.Size(71, 17);
            this.expenseTRbtn.TabIndex = 1;
            this.expenseTRbtn.TabStop = true;
            this.expenseTRbtn.Text = "Expenses";
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
            this.label2.Location = new System.Drawing.Point(459, 37);
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
            // addTBtn
            // 
            this.addTBtn.Location = new System.Drawing.Point(12, 18);
            this.addTBtn.Name = "addTBtn";
            this.addTBtn.Size = new System.Drawing.Size(155, 30);
            this.addTBtn.TabIndex = 1;
            this.addTBtn.Text = "Add Transaction";
            this.addTBtn.UseVisualStyleBackColor = true;
            this.addTBtn.Click += new System.EventHandler(this.AddTBtn_Click);
            // 
            // UpdateTBtn
            // 
            this.UpdateTBtn.Location = new System.Drawing.Point(12, 63);
            this.UpdateTBtn.Name = "UpdateTBtn";
            this.UpdateTBtn.Size = new System.Drawing.Size(155, 30);
            this.UpdateTBtn.TabIndex = 2;
            this.UpdateTBtn.Text = "Update Transaction";
            this.UpdateTBtn.UseVisualStyleBackColor = true;
            this.UpdateTBtn.Click += new System.EventHandler(this.UpdateTBtn_Click);
            // 
            // DeleteTBtn
            // 
            this.DeleteTBtn.Location = new System.Drawing.Point(12, 108);
            this.DeleteTBtn.Name = "DeleteTBtn";
            this.DeleteTBtn.Size = new System.Drawing.Size(155, 30);
            this.DeleteTBtn.TabIndex = 3;
            this.DeleteTBtn.Text = "DeleteTransation";
            this.DeleteTBtn.UseVisualStyleBackColor = true;
            this.DeleteTBtn.Click += new System.EventHandler(this.DeleteTBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cancelTBtn);
            this.groupBox3.Controls.Add(this.DeleteTBtn);
            this.groupBox3.Controls.Add(this.UpdateTBtn);
            this.groupBox3.Controls.Add(this.addTBtn);
            this.groupBox3.Location = new System.Drawing.Point(840, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 155);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // cancelTBtn
            // 
            this.cancelTBtn.Location = new System.Drawing.Point(12, 125);
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
            this.transGridView.FullRowSelect = true;
            this.transGridView.GridLines = true;
            this.transGridView.HideSelection = false;
            this.transGridView.Location = new System.Drawing.Point(3, 223);
            this.transGridView.Name = "transGridView";
            this.transGridView.ShowItemToolTips = true;
            this.transGridView.Size = new System.Drawing.Size(726, 262);
            this.transGridView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.transGridView.TabIndex = 5;
            this.transGridView.UseCompatibleStateImageBehavior = false;
            this.transGridView.View = System.Windows.Forms.View.Details;
            this.transGridView.SelectedIndexChanged += new System.EventHandler(this.TransGridView_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(331, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "TRANSACTION TABLE";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(8, 172);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(721, 26);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // tabControl1
            // 
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
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.transDetailBox);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.transGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1048, 491);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Transaction";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.CancelAddRAction);
            this.tabPage2.Controls.Add(this.RTransListView);
            this.tabPage2.Controls.Add(this.DeleteRTransaction);
            this.tabPage2.Controls.Add(this.RegisterRTransaction);
            this.tabPage2.Controls.Add(this.AddRTransaction);
            this.tabPage2.Controls.Add(this.rTransDetailBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1048, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recurrent Transaction";
            // 
            // RTransListView
            // 
            this.RTransListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RTransListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RTransListView.FullRowSelect = true;
            this.RTransListView.GridLines = true;
            this.RTransListView.HideSelection = false;
            this.RTransListView.Location = new System.Drawing.Point(3, 241);
            this.RTransListView.Name = "RTransListView";
            this.RTransListView.Size = new System.Drawing.Size(1042, 247);
            this.RTransListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.RTransListView.TabIndex = 4;
            this.RTransListView.UseCompatibleStateImageBehavior = false;
            this.RTransListView.View = System.Windows.Forms.View.Details;
            this.RTransListView.SelectedIndexChanged += new System.EventHandler(this.RTransListView_SelectedIndexChanged);
            // 
            // DeleteRTransaction
            // 
            this.DeleteRTransaction.AutoSize = true;
            this.DeleteRTransaction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteRTransaction.Depth = 0;
            this.DeleteRTransaction.Icon = null;
            this.DeleteRTransaction.Location = new System.Drawing.Point(898, 150);
            this.DeleteRTransaction.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteRTransaction.Name = "DeleteRTransaction";
            this.DeleteRTransaction.Primary = true;
            this.DeleteRTransaction.Size = new System.Drawing.Size(69, 36);
            this.DeleteRTransaction.TabIndex = 3;
            this.DeleteRTransaction.Text = "DELETE";
            this.DeleteRTransaction.UseVisualStyleBackColor = true;
            this.DeleteRTransaction.Click += new System.EventHandler(this.DeleteRTransaction_Click);
            // 
            // RegisterRTransaction
            // 
            this.RegisterRTransaction.AutoSize = true;
            this.RegisterRTransaction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegisterRTransaction.Depth = 0;
            this.RegisterRTransaction.Icon = null;
            this.RegisterRTransaction.Location = new System.Drawing.Point(900, 88);
            this.RegisterRTransaction.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterRTransaction.Name = "RegisterRTransaction";
            this.RegisterRTransaction.Primary = true;
            this.RegisterRTransaction.Size = new System.Drawing.Size(73, 36);
            this.RegisterRTransaction.TabIndex = 2;
            this.RegisterRTransaction.Text = "UPDATE";
            this.RegisterRTransaction.UseVisualStyleBackColor = true;
            this.RegisterRTransaction.Click += new System.EventHandler(this.RegisterRTransaction_Click);
            // 
            // AddRTransaction
            // 
            this.AddRTransaction.AutoSize = true;
            this.AddRTransaction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddRTransaction.Depth = 0;
            this.AddRTransaction.Icon = null;
            this.AddRTransaction.Location = new System.Drawing.Point(902, 27);
            this.AddRTransaction.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddRTransaction.Name = "AddRTransaction";
            this.AddRTransaction.Primary = true;
            this.AddRTransaction.Size = new System.Drawing.Size(129, 36);
            this.AddRTransaction.TabIndex = 1;
            this.AddRTransaction.Text = "Add Recurrent ";
            this.AddRTransaction.UseVisualStyleBackColor = true;
            this.AddRTransaction.Click += new System.EventHandler(this.AddRTransaction_Click);
            // 
            // rTransDetailBox
            // 
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
            this.rTransDetailBox.Controls.Add(this.rTransAmount);
            this.rTransDetailBox.Controls.Add(this.rID);
            this.rTransDetailBox.Location = new System.Drawing.Point(8, 6);
            this.rTransDetailBox.Name = "rTransDetailBox";
            this.rTransDetailBox.Size = new System.Drawing.Size(874, 195);
            this.rTransDetailBox.TabIndex = 0;
            this.rTransDetailBox.TabStop = false;
            this.rTransDetailBox.Text = "Update Recurrent Transaction";
            // 
            // rTransFrequency
            // 
            this.rTransFrequency.Location = new System.Drawing.Point(668, 104);
            this.rTransFrequency.Name = "rTransFrequency";
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
            this.groupBox7.Text = "groupBox7";
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
            this.rTransFrequencyList.SelectedIndexChanged += new System.EventHandler(this.rTransFrequencyList_SelectedIndexChanged);
            // 
            // rTransContactList
            // 
            this.rTransContactList.FormattingEnabled = true;
            this.rTransContactList.Location = new System.Drawing.Point(400, 144);
            this.rTransContactList.Name = "rTransContactList";
            this.rTransContactList.Size = new System.Drawing.Size(176, 21);
            this.rTransContactList.TabIndex = 7;
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
            this.rTransName.Name = "rTransName";
            this.rTransName.Size = new System.Drawing.Size(410, 20);
            this.rTransName.TabIndex = 2;
            // 
            // rTransAmount
            // 
            this.rTransAmount.Location = new System.Drawing.Point(400, 61);
            this.rTransAmount.MaxLength = 20;
            this.rTransAmount.Name = "rTransAmount";
            this.rTransAmount.Size = new System.Drawing.Size(176, 20);
            this.rTransAmount.TabIndex = 1;
            // 
            // rID
            // 
            this.rID.Location = new System.Drawing.Point(36, 21);
            this.rID.Name = "rID";
            this.rID.Size = new System.Drawing.Size(80, 20);
            this.rID.TabIndex = 0;
            // 
            // CancelAddRAction
            // 
            this.CancelAddRAction.AutoSize = true;
            this.CancelAddRAction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelAddRAction.Depth = 0;
            this.CancelAddRAction.Icon = null;
            this.CancelAddRAction.Location = new System.Drawing.Point(900, 114);
            this.CancelAddRAction.MouseState = MaterialSkin.MouseState.HOVER;
            this.CancelAddRAction.Name = "CancelAddRAction";
            this.CancelAddRAction.Primary = true;
            this.CancelAddRAction.Size = new System.Drawing.Size(73, 36);
            this.CancelAddRAction.TabIndex = 5;
            this.CancelAddRAction.Text = "Cancel";
            this.CancelAddRAction.UseVisualStyleBackColor = true;
            this.CancelAddRAction.Visible = false;
            this.CancelAddRAction.Click += new System.EventHandler(this.CancelAddRAction_Click);
            // 
            // TransactionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 531);
            this.Controls.Add(this.tabControl1);
            this.Name = "TransactionView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransactionView";
            this.transDetailBox.ResumeLayout(false);
            this.transDetailBox.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.rTransDetailBox.ResumeLayout(false);
            this.rTransDetailBox.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox transDetailBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addTBtn;
        private System.Windows.Forms.Button UpdateTBtn;
        private System.Windows.Forms.Button DeleteTBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton expenseTRbtn;
        private System.Windows.Forms.RadioButton incomeTRbtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox tAmountTbox;
        private System.Windows.Forms.TextBox tNameTbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox tContactCombobox;
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
        private System.Windows.Forms.TextBox tcontactTbox;
        private System.Windows.Forms.DateTimePicker tDatePicker;
        private MaterialSkin.Controls.MaterialRaisedButton DeleteRTransaction;
        private MaterialSkin.Controls.MaterialRaisedButton RegisterRTransaction;
        private MaterialSkin.Controls.MaterialRaisedButton AddRTransaction;
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
        private ComboBox rTransContactList;
        private DateTimePicker rTransEndPeriod;
        private DateTimePicker rTransStartPeriod;
        private RichTextBox rTransNote;
        private TextBox rTransContact;
        private TextBox rTransName;
        private TextBox rTransAmount;
        private TextBox rID;
        private ListView RTransListView;
        private MaterialSkin.Controls.MaterialRaisedButton CancelAddRAction;
    }
}