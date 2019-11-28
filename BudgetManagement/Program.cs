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
            string a;
            DialogResult result;
            User user = new User(0, "name22", "email2@yahoo.com", "password");
            UserRepositoryController test = new UserRepositoryController();
            a = test.AddUser(user);
           

           // Contact contact = new Contact(8, 1,"Jame1", "contact 00 address hhh", "contact type4");
           // ContactRepositoryController test = new ContactRepositoryController();
            //a = test.AddContact(contact);
           // a = test.DeleteContact(contact);
            // a = test.UpdateContact(contact);
           // List<Contact> ab = test.GetContact(1);

            string caption = "Message from add user";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
           

            result = MessageBox.Show(a.ToString(), caption, buttons);
           

            Application.Run(new Form1());
        }
    }
}
