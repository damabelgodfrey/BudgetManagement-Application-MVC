using BudgetManagement.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace BudgetManagement.Views
{
    
    public partial class MyLoginForm : Form
    {
        private static MyLoginForm LoginForm;
        private static readonly object LoginPadlock = new object();
        PopupNotifier popup = new PopupNotifier();
        public MyLoginForm()
        {
            InitializeComponent();
        }

        internal static MyLoginForm GetLoginForm()
        {
            lock (LoginPadlock)
            {
                if (LoginForm == null || LoginForm.IsDisposed)
                {
                    LoginForm = new MyLoginForm();
                }

                return LoginForm;
            }
        }


        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            string email = loginEmailTxt.Text; ;
            string password = LoginPasswordtxt.Text;
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter Email", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (!Authentication.IsValidEmail(email))
            {
                MessageBox.Show("Please enter Email in right format", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
            {
                bool result = Authentication.AuthenticateUser(email, password);
                if (result)
                {
                    this.Hide();
                    LoginPasswordtxt.Text = "";
                    popup.TitleText = "STATUS ALERT";
                    popup.ContentText = "Authentication was successful....";
                    popup.Popup();
                    Dashboard myDashboard = new Dashboard();
                    myDashboard.ShowDialog(); 
                   
                }
                else
                {
                    LoginPasswordtxt.Text = "";
                    MessageBox.Show("Login Details Could not be Verified", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }


        public string PasswordShowToggle
        {
            set
            {
                if (value == "*")
                {
                  
                    this.LoginPasswordtxt.PasswordChar = '*';
                }
                else
                {
                    this.LoginPasswordtxt.PasswordChar = '\0';

                }
            }

        }

  
        private void passwordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoginPasswordtxt.PasswordChar = passwordCheckBox.Checked ? '\0' : '*';

        }

        private void ShowRegPassword_CheckedChanged(object sender, EventArgs e)
        {
            RegisterPasswordL.PasswordChar = showPassword.Checked ? '\0' : '*';
            RegisterPassword2L.PasswordChar = showPassword.Checked ? '\0' : '*';
        }

        private void Register_Click_1(object sender, EventArgs e)
        {

            string name = RegisterNameL.Text; ;
            string email = RegisterEmailL.Text;
            string password = RegisterPasswordL.Text; ;
            string passwordConfirm = RegisterPassword2L.Text;
            DateTime thisDay = DateTime.Today;


            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please Enter Name", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please Enter Email", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else if (!Authentication.IsValidEmail(email))
            {
                MessageBox.Show("Please Enter email in right format", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please Enter password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(passwordConfirm))
            {
                MessageBox.Show("Please Enter Confirm Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (password != passwordConfirm)
            {
                MessageBox.Show("Please Enter Same Password", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                string result = Authentication.RegisterUser(name, email, password, thisDay);
                if (result == "false")
                {
                    RegisterPassword2L.ResetText();
                    MessageBox.Show("Email already exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    popup.TitleText = "SUCCESS ALERT";
                    popup.ContentText = "Registration was successfull";
                    popup.Popup();
                    RegisterPasswordL.ResetText();
                    RegisterPassword2L.ResetText();
                }

            }
        }

        internal void displayForm()
        {
            this.WindowState = FormWindowState.Normal;
            this.Activate();
            this.Show();
        }
    }
}
