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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // contactView
            // 
            this.contactView.Location = new System.Drawing.Point(88, 103);
            this.contactView.Name = "contactView";
            this.contactView.Size = new System.Drawing.Size(278, 174);
            this.contactView.TabIndex = 0;
            this.contactView.Text = "Contacts";
            this.contactView.UseVisualStyleBackColor = true;
            this.contactView.Click += new System.EventHandler(this.button1_Click);
            // 
            // transactionview
            // 
            this.transactionview.Location = new System.Drawing.Point(394, 103);
            this.transactionview.Name = "transactionview";
            this.transactionview.Size = new System.Drawing.Size(305, 174);
            this.transactionview.TabIndex = 1;
            this.transactionview.Text = "Transactions";
            this.transactionview.UseVisualStyleBackColor = true;
            this.transactionview.Click += new System.EventHandler(this.transactionview_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(814, 103);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 531);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.transactionview);
            this.Controls.Add(this.contactView);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button contactView;
        private System.Windows.Forms.Button transactionview;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}