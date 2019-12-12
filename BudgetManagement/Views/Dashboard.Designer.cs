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
            this.contactView = new System.Windows.Forms.Button();
            this.transactionview = new System.Windows.Forms.Button();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.ManageUser = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ManageTransaction = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ManageEvent = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ViewReport = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton3 = new MaterialSkin.Controls.MaterialFlatButton();
            this.ManageContact = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // contactView
            // 
            this.contactView.Location = new System.Drawing.Point(291, 178);
            this.contactView.Name = "contactView";
            this.contactView.Size = new System.Drawing.Size(278, 174);
            this.contactView.TabIndex = 0;
            this.contactView.Text = "Contacts";
            this.contactView.UseVisualStyleBackColor = true;
            this.contactView.Click += new System.EventHandler(this.button1_Click);
            // 
            // transactionview
            // 
            this.transactionview.Location = new System.Drawing.Point(618, 178);
            this.transactionview.Name = "transactionview";
            this.transactionview.Size = new System.Drawing.Size(305, 174);
            this.transactionview.TabIndex = 1;
            this.transactionview.Text = "Transactions";
            this.transactionview.UseVisualStyleBackColor = true;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(1, -1);
            this.materialRaisedButton1.MinimumSize = new System.Drawing.Size(195, 532);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(195, 532);
            this.materialRaisedButton1.TabIndex = 5;
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Icon = null;
            this.materialFlatButton2.Location = new System.Drawing.Point(1, 128);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MinimumSize = new System.Drawing.Size(195, 63);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(195, 63);
            this.materialFlatButton2.TabIndex = 7;
            this.materialFlatButton2.Text = "HOME";
            this.materialFlatButton2.UseVisualStyleBackColor = true;
            // 
            // ManageUser
            // 
            this.ManageUser.AutoSize = true;
            this.ManageUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ManageUser.Depth = 0;
            this.ManageUser.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ManageUser.FlatAppearance.BorderSize = 10;
            this.ManageUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ManageUser.Icon = null;
            this.ManageUser.Location = new System.Drawing.Point(854, -1);
            this.ManageUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.ManageUser.Name = "ManageUser";
            this.ManageUser.Primary = true;
            this.ManageUser.Size = new System.Drawing.Size(115, 36);
            this.ManageUser.TabIndex = 8;
            this.ManageUser.Text = "MANAGE USER";
            this.ManageUser.UseVisualStyleBackColor = true;
            // 
            // ManageTransaction
            // 
            this.ManageTransaction.AutoSize = true;
            this.ManageTransaction.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ManageTransaction.Depth = 0;
            this.ManageTransaction.Icon = null;
            this.ManageTransaction.Location = new System.Drawing.Point(403, -1);
            this.ManageTransaction.MouseState = MaterialSkin.MouseState.HOVER;
            this.ManageTransaction.Name = "ManageTransaction";
            this.ManageTransaction.Primary = true;
            this.ManageTransaction.Size = new System.Drawing.Size(175, 36);
            this.ManageTransaction.TabIndex = 9;
            this.ManageTransaction.Text = "MANAGE TRANSACTION";
            this.ManageTransaction.UseVisualStyleBackColor = true;
            this.ManageTransaction.Click += new System.EventHandler(this.ManageTransaction_Click);
            // 
            // ManageEvent
            // 
            this.ManageEvent.AutoSize = true;
            this.ManageEvent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ManageEvent.Depth = 0;
            this.ManageEvent.Icon = null;
            this.ManageEvent.Location = new System.Drawing.Point(618, -1);
            this.ManageEvent.MouseState = MaterialSkin.MouseState.HOVER;
            this.ManageEvent.Name = "ManageEvent";
            this.ManageEvent.Primary = true;
            this.ManageEvent.Size = new System.Drawing.Size(124, 36);
            this.ManageEvent.TabIndex = 10;
            this.ManageEvent.Text = "MANAGE EVENT";
            this.ManageEvent.UseVisualStyleBackColor = true;
            // 
            // ViewReport
            // 
            this.ViewReport.AutoSize = true;
            this.ViewReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ViewReport.Depth = 0;
            this.ViewReport.Icon = null;
            this.ViewReport.Location = new System.Drawing.Point(1, 266);
            this.ViewReport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ViewReport.MinimumSize = new System.Drawing.Size(195, 63);
            this.ViewReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.ViewReport.Name = "ViewReport";
            this.ViewReport.Primary = false;
            this.ViewReport.Size = new System.Drawing.Size(195, 63);
            this.ViewReport.TabIndex = 11;
            this.ViewReport.Text = "VIEW REPORT";
            this.ViewReport.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton3
            // 
            this.materialFlatButton3.AutoSize = true;
            this.materialFlatButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton3.Depth = 0;
            this.materialFlatButton3.Icon = null;
            this.materialFlatButton3.Location = new System.Drawing.Point(1, 396);
            this.materialFlatButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton3.MinimumSize = new System.Drawing.Size(195, 63);
            this.materialFlatButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton3.Name = "materialFlatButton3";
            this.materialFlatButton3.Primary = false;
            this.materialFlatButton3.Size = new System.Drawing.Size(195, 63);
            this.materialFlatButton3.TabIndex = 12;
            this.materialFlatButton3.Text = "EXPENSE PREDICTION";
            this.materialFlatButton3.UseVisualStyleBackColor = true;
            // 
            // ManageContact
            // 
            this.ManageContact.AutoSize = true;
            this.ManageContact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ManageContact.Depth = 0;
            this.ManageContact.Icon = null;
            this.ManageContact.Location = new System.Drawing.Point(193, -1);
            this.ManageContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.ManageContact.Name = "ManageContact";
            this.ManageContact.Primary = true;
            this.ManageContact.Size = new System.Drawing.Size(145, 36);
            this.ManageContact.TabIndex = 14;
            this.ManageContact.Text = "MANAGE CONTACT";
            this.ManageContact.UseVisualStyleBackColor = true;
            this.ManageContact.Click += new System.EventHandler(this.ManageContact_Click_1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(1059, 531);
            this.Controls.Add(this.ManageContact);
            this.Controls.Add(this.materialFlatButton3);
            this.Controls.Add(this.ViewReport);
            this.Controls.Add(this.ManageEvent);
            this.Controls.Add(this.ManageTransaction);
            this.Controls.Add(this.ManageUser);
            this.Controls.Add(this.materialFlatButton2);
            this.Controls.Add(this.transactionview);
            this.Controls.Add(this.contactView);
            this.Controls.Add(this.materialRaisedButton1);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button contactView;
        private System.Windows.Forms.Button transactionview;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialRaisedButton ManageUser;
        private MaterialSkin.Controls.MaterialRaisedButton ManageTransaction;
        private MaterialSkin.Controls.MaterialRaisedButton ManageEvent;
        private MaterialSkin.Controls.MaterialFlatButton ViewReport;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton3;
        private MaterialSkin.Controls.MaterialRaisedButton ManageContact;
    }
}