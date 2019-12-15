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
            this.transDetailBox = new System.Windows.Forms.GroupBox();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.rEndDate = new System.Windows.Forms.DateTimePicker();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rcontactTbox = new System.Windows.Forms.TextBox();
            this.rContactCombobox = new System.Windows.Forms.ComboBox();
            this.rNameTbox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.GenerateReport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.ReportViewGrid = new MaterialSkin.Controls.MaterialListView();
            this.button1 = new System.Windows.Forms.Button();
            this.totalIncome = new MaterialSkin.Controls.MaterialLabel();
            this.totalExpenses = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.transDetailBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // transDetailBox
            // 
            this.transDetailBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.transDetailBox.Controls.Add(this.materialLabel3);
            this.transDetailBox.Controls.Add(this.rEndDate);
            this.transDetailBox.Controls.Add(this.materialLabel2);
            this.transDetailBox.Controls.Add(this.StartTime);
            this.transDetailBox.Controls.Add(this.materialLabel1);
            this.transDetailBox.Controls.Add(this.groupBox1);
            this.transDetailBox.Controls.Add(this.rNameTbox);
            this.transDetailBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transDetailBox.Location = new System.Drawing.Point(12, 12);
            this.transDetailBox.Name = "transDetailBox";
            this.transDetailBox.Size = new System.Drawing.Size(827, 144);
            this.transDetailBox.TabIndex = 0;
            this.transDetailBox.TabStop = false;
            this.transDetailBox.Text = "Report Sort Criteria";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(356, 82);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(133, 19);
            this.materialLabel3.TabIndex = 22;
            this.materialLabel3.Text = "Transaction Name";
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
            this.groupBox1.Controls.Add(this.rcontactTbox);
            this.groupBox1.Controls.Add(this.rContactCombobox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(588, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 99);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact";
            // 
            // rcontactTbox
            // 
            this.rcontactTbox.Location = new System.Drawing.Point(14, 21);
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
            this.rContactCombobox.Location = new System.Drawing.Point(15, 58);
            this.rContactCombobox.Name = "rContactCombobox";
            this.rContactCombobox.Size = new System.Drawing.Size(177, 24);
            this.rContactCombobox.TabIndex = 9;
            this.rContactCombobox.SelectedIndexChanged += new System.EventHandler(this.TContactCombobox_SelectedIndexChanged);
            // 
            // rNameTbox
            // 
            this.rNameTbox.Location = new System.Drawing.Point(360, 44);
            this.rNameTbox.Name = "rNameTbox";
            this.rNameTbox.Size = new System.Drawing.Size(172, 26);
            this.rNameTbox.TabIndex = 7;
            this.rNameTbox.Text = "All";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.GenerateReport);
            this.groupBox3.Location = new System.Drawing.Point(854, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 143);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // GenerateReport
            // 
            this.GenerateReport.AutoSize = true;
            this.GenerateReport.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenerateReport.Depth = 0;
            this.GenerateReport.Icon = null;
            this.GenerateReport.Location = new System.Drawing.Point(16, 23);
            this.GenerateReport.MouseState = MaterialSkin.MouseState.HOVER;
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Primary = true;
            this.GenerateReport.Size = new System.Drawing.Size(144, 36);
            this.GenerateReport.TabIndex = 0;
            this.GenerateReport.Text = "Generate Report";
            this.GenerateReport.UseVisualStyleBackColor = true;
            this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
            // 
            // ReportViewGrid
            // 
            this.ReportViewGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReportViewGrid.CheckBoxes = true;
            this.ReportViewGrid.Depth = 0;
            this.ReportViewGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.ReportViewGrid.FullRowSelect = true;
            this.ReportViewGrid.GridLines = true;
            this.ReportViewGrid.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ReportViewGrid.Location = new System.Drawing.Point(0, 201);
            this.ReportViewGrid.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ReportViewGrid.MouseState = MaterialSkin.MouseState.OUT;
            this.ReportViewGrid.MultiSelect = false;
            this.ReportViewGrid.Name = "ReportViewGrid";
            this.ReportViewGrid.OwnerDraw = true;
            this.ReportViewGrid.ShowGroups = false;
            this.ReportViewGrid.Size = new System.Drawing.Size(770, 330);
            this.ReportViewGrid.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ReportViewGrid.TabIndex = 8;
            this.ReportViewGrid.UseCompatibleStateImageBehavior = false;
            this.ReportViewGrid.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(776, 201);
            this.button1.MinimumSize = new System.Drawing.Size(257, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 29);
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
            this.totalIncome.Location = new System.Drawing.Point(141, 75);
            this.totalIncome.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalIncome.Name = "totalIncome";
            this.totalIncome.Size = new System.Drawing.Size(108, 19);
            this.totalIncome.TabIndex = 10;
            this.totalIncome.Text = "materialLabel5";
            // 
            // totalExpenses
            // 
            this.totalExpenses.AutoSize = true;
            this.totalExpenses.Depth = 0;
            this.totalExpenses.Font = new System.Drawing.Font("Roboto", 11F);
            this.totalExpenses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalExpenses.Location = new System.Drawing.Point(141, 20);
            this.totalExpenses.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalExpenses.Name = "totalExpenses";
            this.totalExpenses.Size = new System.Drawing.Size(108, 19);
            this.totalExpenses.TabIndex = 10;
            this.totalExpenses.Text = "materialLabel5";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.totalExpenses);
            this.panel1.Controls.Add(this.totalIncome);
            this.panel1.Location = new System.Drawing.Point(776, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 126);
            this.panel1.TabIndex = 11;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReportViewGrid);
            this.Controls.Add(this.transDetailBox);
            this.Controls.Add(this.groupBox3);
            this.MaximumSize = new System.Drawing.Size(1075, 570);
            this.MinimumSize = new System.Drawing.Size(1075, 570);
            this.Name = "ReportView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REPORT VIEW BOARD";
            this.transDetailBox.ResumeLayout(false);
            this.transDetailBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}