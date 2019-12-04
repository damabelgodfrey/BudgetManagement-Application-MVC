namespace BudgetManagement.Views
{
    partial class MyLoginForm
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LoginPasswordtxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.loginEmailTxt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.SubmitBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.passwordCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.RegisterRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RegisterNameL = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RegisterEmailL = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RegisterPasswordL = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RegisterPassword2L = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Register = new MaterialSkin.Controls.MaterialRaisedButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 346);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.LoginPasswordtxt);
            this.tabPage1.Controls.Add(this.materialLabel2);
            this.tabPage1.Controls.Add(this.materialLabel1);
            this.tabPage1.Controls.Add(this.loginEmailTxt);
            this.tabPage1.Controls.Add(this.SubmitBtn);
            this.tabPage1.Controls.Add(this.passwordCheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(569, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            // 
            // LoginPasswordtxt
            // 
            this.LoginPasswordtxt.Depth = 0;
            this.LoginPasswordtxt.Hint = "";
            this.LoginPasswordtxt.Location = new System.Drawing.Point(153, 149);
            this.LoginPasswordtxt.MaxLength = 32767;
            this.LoginPasswordtxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.LoginPasswordtxt.Name = "LoginPasswordtxt";
            this.LoginPasswordtxt.PasswordChar = '*';
            this.LoginPasswordtxt.SelectedText = "";
            this.LoginPasswordtxt.SelectionLength = 0;
            this.LoginPasswordtxt.SelectionStart = 0;
            this.LoginPasswordtxt.Size = new System.Drawing.Size(301, 23);
            this.LoginPasswordtxt.TabIndex = 10;
            this.LoginPasswordtxt.TabStop = false;
            this.LoginPasswordtxt.Text = "password";
            this.LoginPasswordtxt.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(58, 154);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(75, 18);
            this.materialLabel2.TabIndex = 9;
            this.materialLabel2.Text = "Password";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(70, 106);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(45, 18);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "Email";
            // 
            // loginEmailTxt
            // 
            this.loginEmailTxt.Depth = 0;
            this.loginEmailTxt.Hint = "";
            this.loginEmailTxt.Location = new System.Drawing.Point(153, 101);
            this.loginEmailTxt.MaxLength = 32767;
            this.loginEmailTxt.MouseState = MaterialSkin.MouseState.HOVER;
            this.loginEmailTxt.Name = "loginEmailTxt";
            this.loginEmailTxt.PasswordChar = '\0';
            this.loginEmailTxt.SelectedText = "";
            this.loginEmailTxt.SelectionLength = 0;
            this.loginEmailTxt.SelectionStart = 0;
            this.loginEmailTxt.Size = new System.Drawing.Size(301, 23);
            this.loginEmailTxt.TabIndex = 2;
            this.loginEmailTxt.TabStop = false;
            this.loginEmailTxt.Text = "test@yahoo.com";
            this.loginEmailTxt.UseSystemPasswordChar = false;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Depth = 0;
            this.SubmitBtn.Icon = null;
            this.SubmitBtn.Location = new System.Drawing.Point(194, 199);
            this.SubmitBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Primary = true;
            this.SubmitBtn.Size = new System.Drawing.Size(219, 29);
            this.SubmitBtn.TabIndex = 7;
            this.SubmitBtn.Text = "SUBMIT";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // passwordCheckBox
            // 
            this.passwordCheckBox.AutoSize = true;
            this.passwordCheckBox.Location = new System.Drawing.Point(460, 154);
            this.passwordCheckBox.Name = "passwordCheckBox";
            this.passwordCheckBox.Size = new System.Drawing.Size(102, 17);
            this.passwordCheckBox.TabIndex = 6;
            this.passwordCheckBox.Text = "Show Password";
            this.passwordCheckBox.UseVisualStyleBackColor = true;
            this.passwordCheckBox.CheckedChanged += new System.EventHandler(this.passwordCheckBox_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.materialLabel6);
            this.tabPage2.Controls.Add(this.materialLabel5);
            this.tabPage2.Controls.Add(this.materialLabel4);
            this.tabPage2.Controls.Add(this.materialLabel3);
            this.tabPage2.Controls.Add(this.Register);
            this.tabPage2.Controls.Add(this.RegisterPassword2L);
            this.tabPage2.Controls.Add(this.RegisterPasswordL);
            this.tabPage2.Controls.Add(this.RegisterEmailL);
            this.tabPage2.Controls.Add(this.RegisterNameL);
            this.tabPage2.Controls.Add(this.RegisterRadio);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(569, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Register";
            // 
            // RegisterRadio
            // 
            this.RegisterRadio.AutoSize = true;
            this.RegisterRadio.Checked = true;
            this.RegisterRadio.Location = new System.Drawing.Point(449, 196);
            this.RegisterRadio.Name = "RegisterRadio";
            this.RegisterRadio.Size = new System.Drawing.Size(101, 17);
            this.RegisterRadio.TabIndex = 9;
            this.RegisterRadio.TabStop = true;
            this.RegisterRadio.Text = "Show Password";
            this.RegisterRadio.UseVisualStyleBackColor = true;
            this.RegisterRadio.CheckedChanged += new System.EventHandler(this.RegisterRadio_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(125, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 369);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.AutoSize = true;
            this.materialRaisedButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialRaisedButton1.Icon = null;
            this.materialRaisedButton1.Location = new System.Drawing.Point(0, 0);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(819, 456);
            this.materialRaisedButton1.TabIndex = 2;
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BudgetManagement.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(225, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // RegisterNameL
            // 
            this.RegisterNameL.Depth = 0;
            this.RegisterNameL.Hint = "";
            this.RegisterNameL.Location = new System.Drawing.Point(152, 68);
            this.RegisterNameL.MaxLength = 32767;
            this.RegisterNameL.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterNameL.Name = "RegisterNameL";
            this.RegisterNameL.PasswordChar = '\0';
            this.RegisterNameL.SelectedText = "";
            this.RegisterNameL.SelectionLength = 0;
            this.RegisterNameL.SelectionStart = 0;
            this.RegisterNameL.Size = new System.Drawing.Size(291, 23);
            this.RegisterNameL.TabIndex = 10;
            this.RegisterNameL.TabStop = false;
            this.RegisterNameL.UseSystemPasswordChar = false;
            // 
            // RegisterEmailL
            // 
            this.RegisterEmailL.Depth = 0;
            this.RegisterEmailL.Hint = "";
            this.RegisterEmailL.Location = new System.Drawing.Point(152, 109);
            this.RegisterEmailL.MaxLength = 32767;
            this.RegisterEmailL.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterEmailL.Name = "RegisterEmailL";
            this.RegisterEmailL.PasswordChar = '\0';
            this.RegisterEmailL.SelectedText = "";
            this.RegisterEmailL.SelectionLength = 0;
            this.RegisterEmailL.SelectionStart = 0;
            this.RegisterEmailL.Size = new System.Drawing.Size(291, 23);
            this.RegisterEmailL.TabIndex = 11;
            this.RegisterEmailL.TabStop = false;
            this.RegisterEmailL.UseSystemPasswordChar = false;
            // 
            // RegisterPasswordL
            // 
            this.RegisterPasswordL.Depth = 0;
            this.RegisterPasswordL.Hint = "";
            this.RegisterPasswordL.Location = new System.Drawing.Point(152, 159);
            this.RegisterPasswordL.MaxLength = 32767;
            this.RegisterPasswordL.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterPasswordL.Name = "RegisterPasswordL";
            this.RegisterPasswordL.PasswordChar = '*';
            this.RegisterPasswordL.SelectedText = "";
            this.RegisterPasswordL.SelectionLength = 0;
            this.RegisterPasswordL.SelectionStart = 0;
            this.RegisterPasswordL.Size = new System.Drawing.Size(291, 23);
            this.RegisterPasswordL.TabIndex = 12;
            this.RegisterPasswordL.TabStop = false;
            this.RegisterPasswordL.UseSystemPasswordChar = false;
            // 
            // RegisterPassword2L
            // 
            this.RegisterPassword2L.Depth = 0;
            this.RegisterPassword2L.Hint = "";
            this.RegisterPassword2L.Location = new System.Drawing.Point(152, 207);
            this.RegisterPassword2L.MaxLength = 32767;
            this.RegisterPassword2L.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegisterPassword2L.Name = "RegisterPassword2L";
            this.RegisterPassword2L.PasswordChar = '*';
            this.RegisterPassword2L.SelectedText = "";
            this.RegisterPassword2L.SelectionLength = 0;
            this.RegisterPassword2L.SelectionStart = 0;
            this.RegisterPassword2L.Size = new System.Drawing.Size(291, 23);
            this.RegisterPassword2L.TabIndex = 13;
            this.RegisterPassword2L.TabStop = false;
            this.RegisterPassword2L.UseSystemPasswordChar = false;
            // 
            // Register
            // 
            this.Register.Depth = 0;
            this.Register.Icon = null;
            this.Register.Location = new System.Drawing.Point(196, 251);
            this.Register.MouseState = MaterialSkin.MouseState.HOVER;
            this.Register.Name = "Register";
            this.Register.Primary = true;
            this.Register.Size = new System.Drawing.Size(171, 30);
            this.Register.TabIndex = 14;
            this.Register.Text = "SUBMIT";
            this.Register.UseVisualStyleBackColor = true;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(38, 72);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(52, 19);
            this.materialLabel3.TabIndex = 15;
            this.materialLabel3.Text = "NAME";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(24, 163);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(88, 19);
            this.materialLabel4.TabIndex = 16;
            this.materialLabel4.Text = "PASSWORD";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(32, 211);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(74, 19);
            this.materialLabel5.TabIndex = 17;
            this.materialLabel5.Text = "CONFIRM";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(40, 113);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(53, 19);
            this.materialLabel6.TabIndex = 18;
            this.materialLabel6.Text = "EMAIL";
            // 
            // MyLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 456);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.materialRaisedButton1);
            this.Name = "MyLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RegisterRadio;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.CheckBox passwordCheckBox;
        private MaterialSkin.Controls.MaterialRaisedButton SubmitBtn;
        private MaterialSkin.Controls.MaterialSingleLineTextField loginEmailTxt;
        private MaterialSkin.Controls.MaterialSingleLineTextField LoginPasswordtxt;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialSingleLineTextField RegisterPassword2L;
        private MaterialSkin.Controls.MaterialSingleLineTextField RegisterPasswordL;
        private MaterialSkin.Controls.MaterialSingleLineTextField RegisterEmailL;
        private MaterialSkin.Controls.MaterialSingleLineTextField RegisterNameL;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialRaisedButton Register;
    }
}