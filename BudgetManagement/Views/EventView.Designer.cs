﻿using System.Windows.Forms;

namespace BudgetManagement.Views
{
    partial class EventView
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
            this.RefreshEventView = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.EventNote = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EventContact = new System.Windows.Forms.TextBox();
            this.AllEventContact = new System.Windows.Forms.ComboBox();
            this.EventDate = new System.Windows.Forms.DateTimePicker();
            this.tID = new System.Windows.Forms.Label();
            this.EventIDtbox = new System.Windows.Forms.TextBox();
            this.EventName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AppointmentRbtn = new System.Windows.Forms.RadioButton();
            this.TaskRbtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddEvent = new System.Windows.Forms.Button();
            this.UpdateEvent = new System.Windows.Forms.Button();
            this.DeleteEvent = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cancelEvent = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.EventGridView = new System.Windows.Forms.ListView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SubmitEvent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.SubmitReEvent = new System.Windows.Forms.Button();
            this.eventControl = new System.Windows.Forms.GroupBox();
            this.DeleteReEvent = new System.Windows.Forms.Button();
            this.UpdateReEvent = new System.Windows.Forms.Button();
            this.AddReEvent = new System.Windows.Forms.Button();
            this.REventListView = new System.Windows.Forms.ListView();
            this.rTransDetailBox = new System.Windows.Forms.GroupBox();
            this.RefreshRView = new System.Windows.Forms.Button();
            this.rEventFrequency = new System.Windows.Forms.TextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.rAppointment = new System.Windows.Forms.RadioButton();
            this.rTask = new System.Windows.Forms.RadioButton();
            this.rEventFrequencyList = new System.Windows.Forms.ComboBox();
            this.rEventContactList = new System.Windows.Forms.ComboBox();
            this.rEventEndPeriod = new System.Windows.Forms.DateTimePicker();
            this.rEventStartPeriod = new System.Windows.Forms.DateTimePicker();
            this.rEventNote = new System.Windows.Forms.RichTextBox();
            this.rEventContact = new System.Windows.Forms.TextBox();
            this.rEventName = new System.Windows.Forms.TextBox();
            this.EID = new System.Windows.Forms.TextBox();
            this.CancelREvent = new System.Windows.Forms.Button();
            this.transDetailBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.eventControl.SuspendLayout();
            this.rTransDetailBox.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // transDetailBox
            // 
            this.transDetailBox.Controls.Add(this.RefreshEventView);
            this.transDetailBox.Controls.Add(this.groupBox5);
            this.transDetailBox.Controls.Add(this.groupBox1);
            this.transDetailBox.Controls.Add(this.EventDate);
            this.transDetailBox.Controls.Add(this.tID);
            this.transDetailBox.Controls.Add(this.EventIDtbox);
            this.transDetailBox.Controls.Add(this.EventName);
            this.transDetailBox.Controls.Add(this.groupBox2);
            this.transDetailBox.Controls.Add(this.label2);
            this.transDetailBox.Controls.Add(this.label1);
            this.transDetailBox.Location = new System.Drawing.Point(6, 3);
            this.transDetailBox.Name = "transDetailBox";
            this.transDetailBox.Size = new System.Drawing.Size(828, 156);
            this.transDetailBox.TabIndex = 0;
            this.transDetailBox.TabStop = false;
            this.transDetailBox.Text = "Event Details";
            // 
            // RefreshEventView
            // 
            this.RefreshEventView.Location = new System.Drawing.Point(707, 135);
            this.RefreshEventView.Name = "RefreshEventView";
            this.RefreshEventView.Size = new System.Drawing.Size(121, 23);
            this.RefreshEventView.TabIndex = 20;
            this.RefreshEventView.Text = "Refresh View";
            this.RefreshEventView.UseVisualStyleBackColor = true;
            this.RefreshEventView.Click += new System.EventHandler(this.RefreshEventView_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.EventNote);
            this.groupBox5.Location = new System.Drawing.Point(453, 21);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(346, 116);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Note";
            // 
            // EventNote
            // 
            this.EventNote.Location = new System.Drawing.Point(19, 22);
            this.EventNote.Name = "EventNote";
            this.EventNote.Size = new System.Drawing.Size(306, 77);
            this.EventNote.TabIndex = 15;
            this.EventNote.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EventContact);
            this.groupBox1.Controls.Add(this.AllEventContact);
            this.groupBox1.Location = new System.Drawing.Point(243, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 79);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact";
            // 
            // EventContact
            // 
            this.EventContact.Location = new System.Drawing.Point(6, 17);
            this.EventContact.Name = "EventContact";
            this.EventContact.Size = new System.Drawing.Size(177, 20);
            this.EventContact.TabIndex = 16;
            // 
            // AllEventContact
            // 
            this.AllEventContact.DropDownHeight = 200;
            this.AllEventContact.FormattingEnabled = true;
            this.AllEventContact.IntegralHeight = false;
            this.AllEventContact.Location = new System.Drawing.Point(6, 47);
            this.AllEventContact.Name = "AllEventContact";
            this.AllEventContact.Size = new System.Drawing.Size(177, 21);
            this.AllEventContact.TabIndex = 9;
            this.AllEventContact.Text = "--Select a Contact--";
            this.AllEventContact.SelectedIndexChanged += new System.EventHandler(this.AllEventContact_SelectedIndexChanged);
            // 
            // EventDate
            // 
            this.EventDate.CustomFormat = "dd-MM-yyyy hh:mm";
            this.EventDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EventDate.Location = new System.Drawing.Point(249, 35);
            this.EventDate.Name = "EventDate";
            this.EventDate.Size = new System.Drawing.Size(177, 20);
            this.EventDate.TabIndex = 17;
            this.EventDate.Value = new System.DateTime(2019, 12, 2, 0, 0, 0, 0);
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
            // EventIDtbox
            // 
            this.EventIDtbox.Location = new System.Drawing.Point(9, 34);
            this.EventIDtbox.Name = "EventIDtbox";
            this.EventIDtbox.Size = new System.Drawing.Size(56, 20);
            this.EventIDtbox.TabIndex = 12;
            // 
            // EventName
            // 
            this.EventName.Location = new System.Drawing.Point(71, 34);
            this.EventName.Name = "EventName";
            this.EventName.Size = new System.Drawing.Size(172, 20);
            this.EventName.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AppointmentRbtn);
            this.groupBox2.Controls.Add(this.TaskRbtn);
            this.groupBox2.Location = new System.Drawing.Point(6, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 77);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transaction Type";
            // 
            // AppointmentRbtn
            // 
            this.AppointmentRbtn.AutoSize = true;
            this.AppointmentRbtn.Location = new System.Drawing.Point(133, 29);
            this.AppointmentRbtn.Name = "AppointmentRbtn";
            this.AppointmentRbtn.Size = new System.Drawing.Size(84, 17);
            this.AppointmentRbtn.TabIndex = 1;
            this.AppointmentRbtn.TabStop = true;
            this.AppointmentRbtn.Text = "Appointment";
            this.AppointmentRbtn.UseVisualStyleBackColor = true;
            // 
            // TaskRbtn
            // 
            this.TaskRbtn.AutoSize = true;
            this.TaskRbtn.Location = new System.Drawing.Point(26, 29);
            this.TaskRbtn.Name = "TaskRbtn";
            this.TaskRbtn.Size = new System.Drawing.Size(49, 17);
            this.TaskRbtn.TabIndex = 0;
            this.TaskRbtn.TabStop = true;
            this.TaskRbtn.Text = "Task";
            this.TaskRbtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 19);
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
            // AddEvent
            // 
            this.AddEvent.Location = new System.Drawing.Point(852, 237);
            this.AddEvent.Name = "AddEvent";
            this.AddEvent.Size = new System.Drawing.Size(155, 82);
            this.AddEvent.TabIndex = 1;
            this.AddEvent.Text = "Add Event";
            this.AddEvent.UseVisualStyleBackColor = true;
            this.AddEvent.Click += new System.EventHandler(this.AddEvent_Click);
            // 
            // UpdateEvent
            // 
            this.UpdateEvent.Location = new System.Drawing.Point(12, 36);
            this.UpdateEvent.Name = "UpdateEvent";
            this.UpdateEvent.Size = new System.Drawing.Size(155, 30);
            this.UpdateEvent.TabIndex = 2;
            this.UpdateEvent.Text = "Update Event";
            this.UpdateEvent.UseVisualStyleBackColor = true;
            this.UpdateEvent.Click += new System.EventHandler(this.UpdateEvent_Click);
            // 
            // DeleteEvent
            // 
            this.DeleteEvent.Location = new System.Drawing.Point(12, 96);
            this.DeleteEvent.Name = "DeleteEvent";
            this.DeleteEvent.Size = new System.Drawing.Size(155, 30);
            this.DeleteEvent.TabIndex = 3;
            this.DeleteEvent.Text = "DeleteEvent";
            this.DeleteEvent.UseVisualStyleBackColor = true;
            this.DeleteEvent.Click += new System.EventHandler(this.DeleteEvent_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SubmitEvent);
            this.groupBox3.Controls.Add(this.cancelEvent);
            this.groupBox3.Controls.Add(this.DeleteEvent);
            this.groupBox3.Controls.Add(this.UpdateEvent);
            this.groupBox3.Location = new System.Drawing.Point(840, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 155);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // cancelEvent
            // 
            this.cancelEvent.Location = new System.Drawing.Point(12, 97);
            this.cancelEvent.Name = "cancelEvent";
            this.cancelEvent.Size = new System.Drawing.Size(155, 28);
            this.cancelEvent.TabIndex = 4;
            this.cancelEvent.Text = "Cancel";
            this.cancelEvent.UseVisualStyleBackColor = true;
            this.cancelEvent.Visible = false;
            this.cancelEvent.Click += new System.EventHandler(this.cancelEvent_Click);
            // 
            // EventGridView
            // 
            this.EventGridView.AllowColumnReorder = true;
            this.EventGridView.FullRowSelect = true;
            this.EventGridView.GridLines = true;
            this.EventGridView.HideSelection = false;
            this.EventGridView.Location = new System.Drawing.Point(3, 212);
            this.EventGridView.Name = "EventGridView";
            this.EventGridView.ShowItemToolTips = true;
            this.EventGridView.Size = new System.Drawing.Size(802, 293);
            this.EventGridView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.EventGridView.TabIndex = 5;
            this.EventGridView.UseCompatibleStateImageBehavior = false;
            this.EventGridView.View = System.Windows.Forms.View.Details;
            this.EventGridView.SelectedIndexChanged += new System.EventHandler(this.EventGridView_SelectedIndexChanged);
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
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.transDetailBox);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.AddEvent);
            this.tabPage1.Controls.Add(this.EventGridView);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1048, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "My Event";
            // 
            // SubmitEvent
            // 
            this.SubmitEvent.Location = new System.Drawing.Point(12, 37);
            this.SubmitEvent.Name = "SubmitEvent";
            this.SubmitEvent.Size = new System.Drawing.Size(155, 28);
            this.SubmitEvent.TabIndex = 7;
            this.SubmitEvent.Text = "Submit";
            this.SubmitEvent.UseVisualStyleBackColor = true;
            this.SubmitEvent.Visible = false;
            this.SubmitEvent.Click += new System.EventHandler(this.SubmitEvent_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(6, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1039, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "EVENT TABLE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.eventControl);
            this.tabPage2.Controls.Add(this.REventListView);
            this.tabPage2.Controls.Add(this.rTransDetailBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1048, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Recurrent Event";
            // 
            // SubmitReEvent
            // 
            this.SubmitReEvent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SubmitReEvent.Location = new System.Drawing.Point(6, 30);
            this.SubmitReEvent.Name = "SubmitReEvent";
            this.SubmitReEvent.Size = new System.Drawing.Size(142, 30);
            this.SubmitReEvent.TabIndex = 5;
            this.SubmitReEvent.Text = "Submit";
            this.SubmitReEvent.UseVisualStyleBackColor = false;
            this.SubmitReEvent.Visible = false;
            this.SubmitReEvent.Click += new System.EventHandler(this.SubmitReEvent_Click);
            // 
            // eventControl
            // 
            this.eventControl.Controls.Add(this.CancelREvent);
            this.eventControl.Controls.Add(this.SubmitReEvent);
            this.eventControl.Controls.Add(this.DeleteReEvent);
            this.eventControl.Controls.Add(this.UpdateReEvent);
            this.eventControl.Controls.Add(this.AddReEvent);
            this.eventControl.Location = new System.Drawing.Point(888, 14);
            this.eventControl.Name = "eventControl";
            this.eventControl.Size = new System.Drawing.Size(154, 186);
            this.eventControl.TabIndex = 6;
            this.eventControl.TabStop = false;
            this.eventControl.Text = "Recurring Controls";
            // 
            // DeleteReEvent
            // 
            this.DeleteReEvent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteReEvent.Location = new System.Drawing.Point(6, 127);
            this.DeleteReEvent.Name = "DeleteReEvent";
            this.DeleteReEvent.Size = new System.Drawing.Size(142, 30);
            this.DeleteReEvent.TabIndex = 2;
            this.DeleteReEvent.Text = "Delete Event";
            this.DeleteReEvent.UseVisualStyleBackColor = false;
            this.DeleteReEvent.Click += new System.EventHandler(this.DeleteReEvent_Click);
            // 
            // UpdateReEvent
            // 
            this.UpdateReEvent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.UpdateReEvent.Location = new System.Drawing.Point(6, 77);
            this.UpdateReEvent.Name = "UpdateReEvent";
            this.UpdateReEvent.Size = new System.Drawing.Size(142, 30);
            this.UpdateReEvent.TabIndex = 1;
            this.UpdateReEvent.Text = "Update Event";
            this.UpdateReEvent.UseVisualStyleBackColor = false;
            this.UpdateReEvent.Click += new System.EventHandler(this.UpdateReEvent_Click);
            // 
            // AddReEvent
            // 
            this.AddReEvent.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AddReEvent.Location = new System.Drawing.Point(6, 28);
            this.AddReEvent.Name = "AddReEvent";
            this.AddReEvent.Size = new System.Drawing.Size(142, 30);
            this.AddReEvent.TabIndex = 0;
            this.AddReEvent.Text = "Add  Event";
            this.AddReEvent.UseVisualStyleBackColor = false;
            this.AddReEvent.Click += new System.EventHandler(this.AddReEvent_Click);
            // 
            // REventListView
            // 
            this.REventListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.REventListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.REventListView.FullRowSelect = true;
            this.REventListView.GridLines = true;
            this.REventListView.HideSelection = false;
            this.REventListView.Location = new System.Drawing.Point(3, 238);
            this.REventListView.Name = "REventListView";
            this.REventListView.Size = new System.Drawing.Size(1042, 247);
            this.REventListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.REventListView.TabIndex = 4;
            this.REventListView.UseCompatibleStateImageBehavior = false;
            this.REventListView.View = System.Windows.Forms.View.Details;
            this.REventListView.SelectedIndexChanged += new System.EventHandler(this.REventListView_SelectedIndexChanged);
            // 
            // rTransDetailBox
            // 
            this.rTransDetailBox.Controls.Add(this.RefreshRView);
            this.rTransDetailBox.Controls.Add(this.rEventFrequency);
            this.rTransDetailBox.Controls.Add(this.materialLabel1);
            this.rTransDetailBox.Controls.Add(this.label11);
            this.rTransDetailBox.Controls.Add(this.label10);
            this.rTransDetailBox.Controls.Add(this.label9);
            this.rTransDetailBox.Controls.Add(this.label8);
            this.rTransDetailBox.Controls.Add(this.label7);
            this.rTransDetailBox.Controls.Add(this.label5);
            this.rTransDetailBox.Controls.Add(this.groupBox7);
            this.rTransDetailBox.Controls.Add(this.rEventFrequencyList);
            this.rTransDetailBox.Controls.Add(this.rEventContactList);
            this.rTransDetailBox.Controls.Add(this.rEventEndPeriod);
            this.rTransDetailBox.Controls.Add(this.rEventStartPeriod);
            this.rTransDetailBox.Controls.Add(this.rEventNote);
            this.rTransDetailBox.Controls.Add(this.rEventContact);
            this.rTransDetailBox.Controls.Add(this.rEventName);
            this.rTransDetailBox.Controls.Add(this.EID);
            this.rTransDetailBox.Location = new System.Drawing.Point(8, 6);
            this.rTransDetailBox.Name = "rTransDetailBox";
            this.rTransDetailBox.Size = new System.Drawing.Size(874, 195);
            this.rTransDetailBox.TabIndex = 0;
            this.rTransDetailBox.TabStop = false;
            this.rTransDetailBox.Text = "Update Recurrent Event";
            // 
            // RefreshRView
            // 
            this.RefreshRView.Location = new System.Drawing.Point(679, 170);
            this.RefreshRView.Name = "RefreshRView";
            this.RefreshRView.Size = new System.Drawing.Size(75, 23);
            this.RefreshRView.TabIndex = 21;
            this.RefreshRView.Text = "Refresh";
            this.RefreshRView.UseVisualStyleBackColor = true;
            this.RefreshRView.Click += new System.EventHandler(this.RefreshRView_Click);
            // 
            // rEventFrequency
            // 
            this.rEventFrequency.Location = new System.Drawing.Point(668, 104);
            this.rEventFrequency.Name = "rEventFrequency";
            this.rEventFrequency.ReadOnly = true;
            this.rEventFrequency.Size = new System.Drawing.Size(200, 20);
            this.rEventFrequency.TabIndex = 19;
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
            this.groupBox7.Controls.Add(this.rAppointment);
            this.groupBox7.Controls.Add(this.rTask);
            this.groupBox7.Location = new System.Drawing.Point(9, 77);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(148, 103);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Event Type";
            // 
            // rAppointment
            // 
            this.rAppointment.AutoSize = true;
            this.rAppointment.Location = new System.Drawing.Point(64, 50);
            this.rAppointment.Name = "rAppointment";
            this.rAppointment.Size = new System.Drawing.Size(84, 17);
            this.rAppointment.TabIndex = 1;
            this.rAppointment.TabStop = true;
            this.rAppointment.Text = "Appointment";
            this.rAppointment.UseVisualStyleBackColor = true;
            // 
            // rTask
            // 
            this.rTask.AutoSize = true;
            this.rTask.Location = new System.Drawing.Point(6, 50);
            this.rTask.Name = "rTask";
            this.rTask.Size = new System.Drawing.Size(49, 17);
            this.rTask.TabIndex = 0;
            this.rTask.TabStop = true;
            this.rTask.Text = "Task";
            this.rTask.UseVisualStyleBackColor = true;
            // 
            // rEventFrequencyList
            // 
            this.rEventFrequencyList.FormattingEnabled = true;
            this.rEventFrequencyList.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.rEventFrequencyList.Location = new System.Drawing.Point(668, 142);
            this.rEventFrequencyList.Name = "rEventFrequencyList";
            this.rEventFrequencyList.Size = new System.Drawing.Size(200, 21);
            this.rEventFrequencyList.TabIndex = 8;
            this.rEventFrequencyList.Text = "--Select Frequency--";
            this.rEventFrequencyList.SelectedIndexChanged += new System.EventHandler(this.rEventFrequencyList_SelectedIndexChanged);
            // 
            // rEventContactList
            // 
            this.rEventContactList.FormattingEnabled = true;
            this.rEventContactList.Location = new System.Drawing.Point(400, 144);
            this.rEventContactList.Name = "rEventContactList";
            this.rEventContactList.Size = new System.Drawing.Size(176, 21);
            this.rEventContactList.TabIndex = 7;
            this.rEventContactList.Text = "--Select a Contact--";
            this.rEventContactList.SelectedIndexChanged += new System.EventHandler(this.rEventContactList_SelectedIndexChanged);
            // 
            // rEventEndPeriod
            // 
            this.rEventEndPeriod.CustomFormat = "dd-MM-yyyy hh:mm";
            this.rEventEndPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rEventEndPeriod.Location = new System.Drawing.Point(668, 62);
            this.rEventEndPeriod.Name = "rEventEndPeriod";
            this.rEventEndPeriod.Size = new System.Drawing.Size(200, 20);
            this.rEventEndPeriod.TabIndex = 6;
            // 
            // rEventStartPeriod
            // 
            this.rEventStartPeriod.CustomFormat = "dd-MM-yyyy hh:mm";
            this.rEventStartPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rEventStartPeriod.Location = new System.Drawing.Point(668, 26);
            this.rEventStartPeriod.Name = "rEventStartPeriod";
            this.rEventStartPeriod.Size = new System.Drawing.Size(200, 20);
            this.rEventStartPeriod.TabIndex = 5;
            // 
            // rEventNote
            // 
            this.rEventNote.Location = new System.Drawing.Point(163, 98);
            this.rEventNote.Name = "rEventNote";
            this.rEventNote.Size = new System.Drawing.Size(164, 82);
            this.rEventNote.TabIndex = 4;
            this.rEventNote.Text = "";
            // 
            // rEventContact
            // 
            this.rEventContact.Location = new System.Drawing.Point(400, 104);
            this.rEventContact.Name = "rEventContact";
            this.rEventContact.Size = new System.Drawing.Size(176, 20);
            this.rEventContact.TabIndex = 3;
            // 
            // rEventName
            // 
            this.rEventName.Location = new System.Drawing.Point(166, 21);
            this.rEventName.Name = "rEventName";
            this.rEventName.Size = new System.Drawing.Size(410, 20);
            this.rEventName.TabIndex = 2;
            // 
            // EID
            // 
            this.EID.Location = new System.Drawing.Point(36, 21);
            this.EID.Name = "EID";
            this.EID.Size = new System.Drawing.Size(80, 20);
            this.EID.TabIndex = 0;
            // 
            // CancelREvent
            // 
            this.CancelREvent.Location = new System.Drawing.Point(6, 99);
            this.CancelREvent.Name = "CancelREvent";
            this.CancelREvent.Size = new System.Drawing.Size(142, 31);
            this.CancelREvent.TabIndex = 22;
            this.CancelREvent.Text = "Cancel";
            this.CancelREvent.UseVisualStyleBackColor = true;
            this.CancelREvent.Visible = false;
            this.CancelREvent.Click += new System.EventHandler(this.CancelREvent_Click);
            // 
            // EventView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 531);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1075, 570);
            this.MinimumSize = new System.Drawing.Size(1075, 570);
            this.Name = "EventView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Event View";
            this.transDetailBox.ResumeLayout(false);
            this.transDetailBox.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.eventControl.ResumeLayout(false);
            this.rTransDetailBox.ResumeLayout(false);
            this.rTransDetailBox.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox transDetailBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddEvent;
        private System.Windows.Forms.Button UpdateEvent;
        private System.Windows.Forms.Button DeleteEvent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton AppointmentRbtn;
        private System.Windows.Forms.RadioButton TaskRbtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox EventName;
        private System.Windows.Forms.ComboBox AllEventContact;
        private System.Windows.Forms.Label tID;
        private System.Windows.Forms.TextBox EventIDtbox;
        internal System.Windows.Forms.ListView EventGridView;
        private System.Windows.Forms.Button cancelEvent;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox EventNote;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox EventContact;
        private System.Windows.Forms.DateTimePicker EventDate;
        private GroupBox rTransDetailBox;
        private TextBox rEventFrequency;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label5;
        private GroupBox groupBox7;
        private RadioButton rAppointment;
        private RadioButton rTask;
        private ComboBox rEventFrequencyList;
        private ComboBox rEventContactList;
        private DateTimePicker rEventEndPeriod;
        private DateTimePicker rEventStartPeriod;
        private RichTextBox rEventNote;
        private TextBox rEventContact;
        private TextBox rEventName;
        private TextBox EID;
        private ListView REventListView;
        private Button RefreshEventView;
        private Button button1;
        private Button SubmitReEvent;
        private GroupBox eventControl;
        private Button DeleteReEvent;
        private Button UpdateReEvent;
        private Button AddReEvent;
        private Button SubmitEvent;
        private Button RefreshRView;
        private Button CancelREvent;
    }
}