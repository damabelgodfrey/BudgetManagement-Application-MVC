using System.Drawing;

namespace BudgetManagement.Views
{
    partial class ContactView
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
            this.MenuTab = new System.Windows.Forms.TabControl();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TransactionC = new System.Windows.Forms.TabControl();
            this.TransactionPage = new System.Windows.Forms.TabPage();
            this.RecurringTPage = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Event = new System.Windows.Forms.TabPage();
            this.Task = new System.Windows.Forms.TabControl();
            this.TaskPage = new System.Windows.Forms.TabPage();
            this.AppointmentPage = new System.Windows.Forms.TabPage();
            this.Contact = new System.Windows.Forms.TabPage();
            this.contactListView = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DeleteCbtn = new System.Windows.Forms.Button();
            this.updateCBtn = new System.Windows.Forms.Button();
            this.addCBtn = new System.Windows.Forms.Button();
            this.contactGbox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameCtxt = new System.Windows.Forms.TextBox();
            this.idCTxt = new System.Windows.Forms.TextBox();
            this.addressCtxt = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.payerRBtn = new System.Windows.Forms.RadioButton();
            this.payeeRBtn = new System.Windows.Forms.RadioButton();
            this.PredictionPage = new System.Windows.Forms.TabPage();
            this.MenuTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.TransactionC.SuspendLayout();
            this.RecurringTPage.SuspendLayout();
            this.Event.SuspendLayout();
            this.Task.SuspendLayout();
            this.Contact.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.contactGbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuTab
            // 
            this.MenuTab.AllowDrop = true;
            this.MenuTab.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.MenuTab.Controls.Add(this.HomePage);
            this.MenuTab.Controls.Add(this.tabPage2);
            this.MenuTab.Controls.Add(this.Event);
            this.MenuTab.Controls.Add(this.Contact);
            this.MenuTab.Controls.Add(this.PredictionPage);
            this.MenuTab.ItemSize = new System.Drawing.Size(45, 35);
            this.MenuTab.Location = new System.Drawing.Point(0, 0);
            this.MenuTab.Name = "MenuTab";
            this.MenuTab.Padding = new System.Drawing.Point(6, 6);
            this.MenuTab.SelectedIndex = 0;
            this.MenuTab.Size = new System.Drawing.Size(1019, 543);
            this.MenuTab.TabIndex = 1;
            // 
            // HomePage
            // 
            this.HomePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(26)))));
            this.HomePage.Location = new System.Drawing.Point(4, 39);
            this.HomePage.Name = "HomePage";
            this.HomePage.Padding = new System.Windows.Forms.Padding(3);
            this.HomePage.Size = new System.Drawing.Size(1011, 500);
            this.HomePage.TabIndex = 0;
            this.HomePage.Text = "   Home    ";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(26)))));
            this.tabPage2.Controls.Add(this.TransactionC);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1011, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transaction Manager";
            // 
            // TransactionC
            // 
            this.TransactionC.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TransactionC.Controls.Add(this.TransactionPage);
            this.TransactionC.Controls.Add(this.RecurringTPage);
            this.TransactionC.ItemSize = new System.Drawing.Size(171, 26);
            this.TransactionC.Location = new System.Drawing.Point(-4, 0);
            this.TransactionC.Name = "TransactionC";
            this.TransactionC.SelectedIndex = 0;
            this.TransactionC.Size = new System.Drawing.Size(1019, 508);
            this.TransactionC.TabIndex = 0;
            // 
            // TransactionPage
            // 
            this.TransactionPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(26)))));
            this.TransactionPage.Location = new System.Drawing.Point(4, 30);
            this.TransactionPage.Name = "TransactionPage";
            this.TransactionPage.Padding = new System.Windows.Forms.Padding(3);
            this.TransactionPage.Size = new System.Drawing.Size(1011, 474);
            this.TransactionPage.TabIndex = 0;
            this.TransactionPage.Text = "Manage Transaction";
            // 
            // RecurringTPage
            // 
            this.RecurringTPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(26)))));
            this.RecurringTPage.Controls.Add(this.checkBox1);
            this.RecurringTPage.Location = new System.Drawing.Point(4, 30);
            this.RecurringTPage.Name = "RecurringTPage";
            this.RecurringTPage.Padding = new System.Windows.Forms.Padding(3);
            this.RecurringTPage.Size = new System.Drawing.Size(1011, 474);
            this.RecurringTPage.TabIndex = 1;
            this.RecurringTPage.Text = "Manage Recurring Transaction";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(258, 89);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Event
            // 
            this.Event.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(26)))));
            this.Event.Controls.Add(this.Task);
            this.Event.Location = new System.Drawing.Point(4, 39);
            this.Event.Name = "Event";
            this.Event.Padding = new System.Windows.Forms.Padding(3);
            this.Event.Size = new System.Drawing.Size(1011, 500);
            this.Event.TabIndex = 2;
            this.Event.Text = "Event Manager";
            // 
            // Task
            // 
            this.Task.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Task.Controls.Add(this.TaskPage);
            this.Task.Controls.Add(this.AppointmentPage);
            this.Task.ItemSize = new System.Drawing.Size(35, 25);
            this.Task.Location = new System.Drawing.Point(-4, 0);
            this.Task.Name = "Task";
            this.Task.SelectedIndex = 0;
            this.Task.Size = new System.Drawing.Size(1019, 504);
            this.Task.TabIndex = 0;
            // 
            // TaskPage
            // 
            this.TaskPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(26)))));
            this.TaskPage.Location = new System.Drawing.Point(4, 29);
            this.TaskPage.Name = "TaskPage";
            this.TaskPage.Padding = new System.Windows.Forms.Padding(3);
            this.TaskPage.Size = new System.Drawing.Size(1011, 471);
            this.TaskPage.TabIndex = 1;
            this.TaskPage.Text = "Manage Task";
            // 
            // AppointmentPage
            // 
            this.AppointmentPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(26)))));
            this.AppointmentPage.Location = new System.Drawing.Point(4, 29);
            this.AppointmentPage.Name = "AppointmentPage";
            this.AppointmentPage.Padding = new System.Windows.Forms.Padding(3);
            this.AppointmentPage.Size = new System.Drawing.Size(1011, 471);
            this.AppointmentPage.TabIndex = 2;
            this.AppointmentPage.Text = "Manage Appointment";
            // 
            // Contact
            // 
            this.Contact.BackColor = System.Drawing.SystemColors.Control;
            this.Contact.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Contact.Controls.Add(this.contactListView);
            this.Contact.Controls.Add(this.groupBox3);
            this.Contact.Controls.Add(this.contactGbox);
            this.Contact.Location = new System.Drawing.Point(4, 39);
            this.Contact.Name = "Contact";
            this.Contact.Padding = new System.Windows.Forms.Padding(3);
            this.Contact.Size = new System.Drawing.Size(1011, 500);
            this.Contact.TabIndex = 3;
            this.Contact.Text = "Contact Manager";
            // 
            // contactListView
            // 
            this.contactListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contactListView.FullRowSelect = true;
            this.contactListView.GridLines = true;
            this.contactListView.HideSelection = false;
            this.contactListView.Location = new System.Drawing.Point(3, 208);
            this.contactListView.Name = "contactListView";
            this.contactListView.ShowItemToolTips = true;
            this.contactListView.Size = new System.Drawing.Size(1001, 285);
            this.contactListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.contactListView.TabIndex = 35;
            this.contactListView.UseCompatibleStateImageBehavior = false;
            this.contactListView.View = System.Windows.Forms.View.Details;
            this.contactListView.SelectedIndexChanged += new System.EventHandler(this.contactListView_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DeleteCbtn);
            this.groupBox3.Controls.Add(this.updateCBtn);
            this.groupBox3.Controls.Add(this.addCBtn);
            this.groupBox3.Location = new System.Drawing.Point(775, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(223, 177);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // DeleteCbtn
            // 
            this.DeleteCbtn.Location = new System.Drawing.Point(19, 115);
            this.DeleteCbtn.Name = "DeleteCbtn";
            this.DeleteCbtn.Size = new System.Drawing.Size(181, 39);
            this.DeleteCbtn.TabIndex = 5;
            this.DeleteCbtn.Text = "Delete Contact";
            this.DeleteCbtn.UseVisualStyleBackColor = true;
            this.DeleteCbtn.Click += new System.EventHandler(this.DeleteCbtn_Click);
            // 
            // updateCBtn
            // 
            this.updateCBtn.Location = new System.Drawing.Point(19, 61);
            this.updateCBtn.Name = "updateCBtn";
            this.updateCBtn.Size = new System.Drawing.Size(181, 39);
            this.updateCBtn.TabIndex = 4;
            this.updateCBtn.Text = "Update Contact";
            this.updateCBtn.UseVisualStyleBackColor = true;
            this.updateCBtn.Click += new System.EventHandler(this.updateCBtn_Click);
            // 
            // addCBtn
            // 
            this.addCBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.addCBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.addCBtn.FlatAppearance.BorderSize = 0;
            this.addCBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addCBtn.Location = new System.Drawing.Point(19, 16);
            this.addCBtn.Name = "addCBtn";
            this.addCBtn.Size = new System.Drawing.Size(181, 39);
            this.addCBtn.TabIndex = 3;
            this.addCBtn.Text = "Add New Contact";
            this.addCBtn.UseVisualStyleBackColor = false;
            this.addCBtn.Click += new System.EventHandler(this.addCBtn_Click);
            // 
            // contactGbox
            // 
            this.contactGbox.BackColor = System.Drawing.SystemColors.Control;
            this.contactGbox.Controls.Add(this.label3);
            this.contactGbox.Controls.Add(this.label1);
            this.contactGbox.Controls.Add(this.label2);
            this.contactGbox.Controls.Add(this.nameCtxt);
            this.contactGbox.Controls.Add(this.idCTxt);
            this.contactGbox.Controls.Add(this.addressCtxt);
            this.contactGbox.Controls.Add(this.groupBox2);
            this.contactGbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contactGbox.Location = new System.Drawing.Point(8, 6);
            this.contactGbox.Name = "contactGbox";
            this.contactGbox.Size = new System.Drawing.Size(761, 177);
            this.contactGbox.TabIndex = 0;
            this.contactGbox.TabStop = false;
            this.contactGbox.Text = "Update Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contact Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contact Name";
            // 
            // nameCtxt
            // 
            this.nameCtxt.Location = new System.Drawing.Point(120, 49);
            this.nameCtxt.Name = "nameCtxt";
            this.nameCtxt.Size = new System.Drawing.Size(261, 20);
            this.nameCtxt.TabIndex = 5;
            // 
            // idCTxt
            // 
            this.idCTxt.Location = new System.Drawing.Point(120, 19);
            this.idCTxt.Name = "idCTxt";
            this.idCTxt.Size = new System.Drawing.Size(261, 20);
            this.idCTxt.TabIndex = 4;
            // 
            // addressCtxt
            // 
            this.addressCtxt.Location = new System.Drawing.Point(513, 22);
            this.addressCtxt.Name = "addressCtxt";
            this.addressCtxt.Size = new System.Drawing.Size(229, 142);
            this.addressCtxt.TabIndex = 3;
            this.addressCtxt.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.payerRBtn);
            this.groupBox2.Controls.Add(this.payeeRBtn);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Location = new System.Drawing.Point(28, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 79);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contact Type";
            // 
            // payerRBtn
            // 
            this.payerRBtn.AutoSize = true;
            this.payerRBtn.Location = new System.Drawing.Point(150, 31);
            this.payerRBtn.Name = "payerRBtn";
            this.payerRBtn.Size = new System.Drawing.Size(52, 17);
            this.payerRBtn.TabIndex = 1;
            this.payerRBtn.TabStop = true;
            this.payerRBtn.Text = "Payer";
            this.payerRBtn.UseVisualStyleBackColor = true;
            // 
            // payeeRBtn
            // 
            this.payeeRBtn.AutoSize = true;
            this.payeeRBtn.Location = new System.Drawing.Point(30, 31);
            this.payeeRBtn.Name = "payeeRBtn";
            this.payeeRBtn.Size = new System.Drawing.Size(55, 17);
            this.payeeRBtn.TabIndex = 0;
            this.payeeRBtn.TabStop = true;
            this.payeeRBtn.Text = "Payee";
            this.payeeRBtn.UseVisualStyleBackColor = true;
            // 
            // PredictionPage
            // 
            this.PredictionPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(2)))), ((int)(((byte)(26)))));
            this.PredictionPage.ForeColor = System.Drawing.SystemColors.Control;
            this.PredictionPage.Location = new System.Drawing.Point(4, 39);
            this.PredictionPage.Name = "PredictionPage";
            this.PredictionPage.Padding = new System.Windows.Forms.Padding(3);
            this.PredictionPage.Size = new System.Drawing.Size(1011, 500);
            this.PredictionPage.TabIndex = 4;
            this.PredictionPage.Text = "Spending Projection";
            // 
            // ContactView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(11)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1016, 544);
            this.Controls.Add(this.MenuTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ContactView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Contact Board";
            this.MenuTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.TransactionC.ResumeLayout(false);
            this.RecurringTPage.ResumeLayout(false);
            this.RecurringTPage.PerformLayout();
            this.Event.ResumeLayout(false);
            this.Task.ResumeLayout(false);
            this.Contact.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.contactGbox.ResumeLayout(false);
            this.contactGbox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MenuTab;
        private System.Windows.Forms.TabPage HomePage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl TransactionC;
        private System.Windows.Forms.TabPage TransactionPage;
        private System.Windows.Forms.TabPage RecurringTPage;
        private System.Windows.Forms.TabPage Event;
        private System.Windows.Forms.TabPage Contact;
        private System.Windows.Forms.TabPage PredictionPage;
        private System.Windows.Forms.TabControl Task;
        private System.Windows.Forms.TabPage TaskPage;
        private System.Windows.Forms.TabPage AppointmentPage;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button DeleteCbtn;
        private System.Windows.Forms.Button updateCBtn;
        private System.Windows.Forms.Button addCBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameCtxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox idCTxt;
        private System.Windows.Forms.RichTextBox addressCtxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox contactGbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton payerRBtn;
        private System.Windows.Forms.RadioButton payeeRBtn;
        internal System.Windows.Forms.ListView contactListView;
    }
}