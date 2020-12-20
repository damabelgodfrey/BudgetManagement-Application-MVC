using System.Drawing;
using System.Windows.Forms;

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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.DeleteCbtn = new System.Windows.Forms.Button();
            this.UpdateCBtn = new System.Windows.Forms.Button();
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
            this.contactGrdView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SubmitContact = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.contactGbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SubmitContact);
            this.groupBox3.Controls.Add(this.Cancel);
            this.groupBox3.Controls.Add(this.DeleteCbtn);
            this.groupBox3.Controls.Add(this.UpdateCBtn);
            this.groupBox3.Location = new System.Drawing.Point(804, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 179);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel.ForeColor = System.Drawing.Color.Maroon;
            this.Cancel.Location = new System.Drawing.Point(19, 107);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(181, 40);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Visible = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // DeleteCbtn
            // 
            this.DeleteCbtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DeleteCbtn.Location = new System.Drawing.Point(19, 108);
            this.DeleteCbtn.Name = "DeleteCbtn";
            this.DeleteCbtn.Size = new System.Drawing.Size(181, 39);
            this.DeleteCbtn.TabIndex = 5;
            this.DeleteCbtn.Text = "Delete Contact";
            this.DeleteCbtn.UseVisualStyleBackColor = false;
            this.DeleteCbtn.Click += new System.EventHandler(this.DeleteCbtn_Click);
            // 
            // UpdateCBtn
            // 
            this.UpdateCBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.UpdateCBtn.Location = new System.Drawing.Point(19, 32);
            this.UpdateCBtn.Name = "UpdateCBtn";
            this.UpdateCBtn.Size = new System.Drawing.Size(181, 39);
            this.UpdateCBtn.TabIndex = 4;
            this.UpdateCBtn.Text = "Update Contact";
            this.UpdateCBtn.UseVisualStyleBackColor = false;
            this.UpdateCBtn.Click += new System.EventHandler(this.UpdateCBtn_Click);
            // 
            // addCBtn
            // 
            this.addCBtn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addCBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.addCBtn.FlatAppearance.BorderSize = 0;
            this.addCBtn.Location = new System.Drawing.Point(804, 238);
            this.addCBtn.Name = "addCBtn";
            this.addCBtn.Size = new System.Drawing.Size(217, 90);
            this.addCBtn.TabIndex = 3;
            this.addCBtn.Text = "Add New Contact";
            this.addCBtn.UseVisualStyleBackColor = false;
            this.addCBtn.Click += new System.EventHandler(this.AddCBtn_Click);
            // 
            // contactGbox
            // 
            this.contactGbox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.contactGbox.Controls.Add(this.label3);
            this.contactGbox.Controls.Add(this.label1);
            this.contactGbox.Controls.Add(this.label2);
            this.contactGbox.Controls.Add(this.nameCtxt);
            this.contactGbox.Controls.Add(this.idCTxt);
            this.contactGbox.Controls.Add(this.addressCtxt);
            this.contactGbox.Controls.Add(this.groupBox2);
            this.contactGbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contactGbox.Location = new System.Drawing.Point(12, 13);
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
            this.idCTxt.ReadOnly = true;
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
            // contactGrdView
            // 
            this.contactGrdView.AllowColumnReorder = true;
            this.contactGrdView.FullRowSelect = true;
            this.contactGrdView.GridLines = true;
            this.contactGrdView.HideSelection = false;
            this.contactGrdView.Location = new System.Drawing.Point(0, 238);
            this.contactGrdView.Name = "contactGrdView";
            this.contactGrdView.Size = new System.Drawing.Size(773, 293);
            this.contactGrdView.TabIndex = 38;
            this.contactGrdView.UseCompatibleStateImageBehavior = false;
            this.contactGrdView.View = System.Windows.Forms.View.Details;
            this.contactGrdView.VirtualListSize = 10;
            this.contactGrdView.SelectedIndexChanged += new System.EventHandler(this.ContactGrdView_SelectedIndexChanged_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(773, 30);
            this.button1.TabIndex = 39;
            this.button1.Text = "CONTACT TABLE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // SubmitContact
            // 
            this.SubmitContact.Location = new System.Drawing.Point(19, 32);
            this.SubmitContact.Name = "SubmitContact";
            this.SubmitContact.Size = new System.Drawing.Size(181, 38);
            this.SubmitContact.TabIndex = 40;
            this.SubmitContact.Text = "SUBMIT";
            this.SubmitContact.UseVisualStyleBackColor = true;
            this.SubmitContact.Visible = false;
            this.SubmitContact.Click += new System.EventHandler(this.SubmitContact_Click);
            // 
            // ContactView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1059, 531);
            this.Controls.Add(this.addCBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.contactGrdView);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.contactGbox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1075, 570);
            this.Name = "ContactView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Contact Board";
            this.groupBox3.ResumeLayout(false);
            this.contactGbox.ResumeLayout(false);
            this.contactGbox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DeleteCbtn;
        private System.Windows.Forms.Button UpdateCBtn;
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
        private ListView contactGrdView;
        private Button Cancel;
        private Button button1;
        private Button SubmitContact;
    }
}