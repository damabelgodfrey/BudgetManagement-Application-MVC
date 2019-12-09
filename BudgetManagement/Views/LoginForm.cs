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


namespace BudgetManagement.Views
{
    public partial class MyLoginForm : Form
    {
        public MyLoginForm()
        {
            InitializeComponent();
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
                MessageBox.Show("Please enter Email", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
            {
                bool result = Authentication.AuthenticateUser(email, password);
                if (result)
                {
                    //this.Hide();
                   // Dispose();
                    Dashboard myDashboard = new Dashboard();
                    myDashboard.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login Details Incorrect", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void Register_Click(object sender, EventArgs e)
        {
            string name = RegisterNameL.Text; ;
            string email = RegisterEmailL.Text;
            string password = RegisterPasswordL.Text; ;
            string passwordConfirm = RegisterPassword2L.Text;

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
            else if (!Authentication.IsValidEmail(email)) {
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

                string result = Authentication.RegisterUser(name,email, password, passwordConfirm);
                if(result == "false")
                {
                    RegisterPassword2L.ResetText();
                    MessageBox.Show("Email already exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    RegisterPasswordL.ResetText();
                    RegisterPassword2L.ResetText();
                }

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           // LoginPasswordtxt.PasswordChar = LoginPasswordtxt.Checked ? '\0' : '*';
           // this.LoginPasswordtxt.PasswordChar = '\0';

               // }
        }
        private void passwordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoginPasswordtxt.PasswordChar = passwordCheckBox.Checked ? '\0' : '*';

        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            RegisterPasswordL.PasswordChar = passwordCheckBox.Checked ? '\0' : '*';
            RegisterPassword2L.PasswordChar = passwordCheckBox.Checked ? '\0' : '*';
        }

        private void Register_Click_1(object sender, EventArgs e)
        {

            string name = RegisterNameL.Text; ;
            string email = RegisterEmailL.Text;
            string password = RegisterPasswordL.Text; ;
            string passwordConfirm = RegisterPassword2L.Text;

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

                string result = Authentication.RegisterUser(name, email, password, passwordConfirm);
                if (result == "false")
                {
                    RegisterPassword2L.ResetText();
                    MessageBox.Show("Email already exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RegisterPasswordL.ResetText();
                    RegisterPassword2L.ResetText();
                }

            }
        }
    }
}
