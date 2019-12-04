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
            this.transDetailBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tContactCombobox.Location = new System.Drawing.Point(6, 47);
            this.tContactCombobox.Name = "tContactCombobox";
            this.tContactCombobox.Size = new System.Drawing.Size(177, 21);
            this.tContactCombobox.TabIndex = 9;
            this.tContactCombobox.SelectedIndexChanged += new System.EventHandler(this.tContactCombobox_SelectedIndexChanged);
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
            this.addTBtn.Click += new System.EventHandler(this.addTBtn_Click);
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
            this.cancelTBtn.Click += new System.EventHandler(this.cancelTBtn_Click);
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
            this.transGridView.SelectedIndexChanged += new System.EventHandler(this.transGridView_SelectedIndexChanged);
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
            this.tabPage1.Text = "tabPage1";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1048, 491);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
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
    }
}