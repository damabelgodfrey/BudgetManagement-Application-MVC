using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using BudgetManagement.Models;
using BudgetManagement.Repository;
using BudgetManagement.Views;

namespace BudgetManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //string a;
            //DialogResult result;
            //User user = new User(0, "tests", "test@yahoo.comd", "password");
            //UserRepositoryController test = new UserRepositoryController();
            //a = test.AddUser(user);


            ////Contact contact = new Contact(8, 1,"Jame1", "contact 00 address hhh", "contact type4");
            //ContactRepositoryController test1 = new ContactRepositoryController();
            ////a = test.AddContact(contact);
            //// a = test.DeleteContact(contact);
            //// a = test.UpdateContact(contact);
            ////List<Contact> ab = test1.GetContact(1);

            //string caption = "List from add user";
            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
           

            //result = MessageBox.Show(ab.Count().ToString(), caption, buttons);
           

            Application.Run(new LoginForm());
        }
    }
}
