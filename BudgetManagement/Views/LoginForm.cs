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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            PictureBox pb1 = new PictureBox();
            pb1.ImageLocation = "http://www.dotnetperls.com/favicon.ico";
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string email = LoginEmailtxt.Text; ;
            string password = LoginPasswordtxt.Text;
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Please enter Email", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter Email", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool result = MainFormController.Authentication(email, password);
            if (result)
            {
                //if authentication is true call mainform controller to oppen view with the user
                //remove login page
            }
            else
            {
                MessageBox.Show("Login Details Incorrect", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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

                string result = MainFormController.RegisterUser(name,email, password, passwordConfirm);
                if(result == "false")
                {
                    RegisterPasswordL.ResetText();
                    MessageBox.Show("Email already exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    registerSuccessImage.Visible = true;
                    RegisterPasswordL.ResetText();
                    RegisterPassword2L.ResetText();

                }

            }
        }

    }
}
