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
            this.contactGrdViewheader = new MaterialSkin.Controls.MaterialListView();
            this.contactGrdView = new System.Windows.Forms.ListView();
            this.groupBox3.SuspendLayout();
            this.contactGbox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DeleteCbtn);
            this.groupBox3.Controls.Add(this.updateCBtn);
            this.groupBox3.Controls.Add(this.addCBtn);
            this.groupBox3.Location = new System.Drawing.Point(785, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 177);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // DeleteCbtn
            // 
            this.DeleteCbtn.Location = new System.Drawing.Point(19, 124);
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
            // contactGrdViewheader
            // 
            this.contactGrdViewheader.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contactGrdViewheader.CheckBoxes = true;
            this.contactGrdViewheader.Depth = 0;
            this.contactGrdViewheader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.contactGrdViewheader.FullRowSelect = true;
            this.contactGrdViewheader.GridLines = true;
            this.contactGrdViewheader.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.contactGrdViewheader.HideSelection = false;
            this.contactGrdViewheader.Location = new System.Drawing.Point(0, 197);
            this.contactGrdViewheader.MouseLocation = new System.Drawing.Point(-1, -1);
            this.contactGrdViewheader.MouseState = MaterialSkin.MouseState.OUT;
            this.contactGrdViewheader.Name = "contactGrdViewheader";
            this.contactGrdViewheader.OwnerDraw = true;
            this.contactGrdViewheader.Size = new System.Drawing.Size(1059, 49);
            this.contactGrdViewheader.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.contactGrdViewheader.TabIndex = 37;
            this.contactGrdViewheader.UseCompatibleStateImageBehavior = false;
            this.contactGrdViewheader.View = System.Windows.Forms.View.Details;
            // 
            // contactGrdView
            // 
            this.contactGrdView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contactGrdView.GridLines = true;
            this.contactGrdView.HideSelection = false;
            this.contactGrdView.Location = new System.Drawing.Point(0, 247);
            this.contactGrdView.Name = "contactGrdView";
            this.contactGrdView.Size = new System.Drawing.Size(1059, 284);
            this.contactGrdView.TabIndex = 38;
            this.contactGrdView.UseCompatibleStateImageBehavior = false;
            this.contactGrdView.View = System.Windows.Forms.View.Details;
            this.contactGrdView.SelectedIndexChanged += new System.EventHandler(this.contactGrdView_SelectedIndexChanged_1);
            // 
            // ContactView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1059, 531);
            this.Controls.Add(this.contactGrdView);
            this.Controls.Add(this.contactGrdViewheader);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.contactGbox);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
        private MaterialSkin.Controls.MaterialListView contactGrdViewheader;
        private ListView contactGrdView;
    }
}