using BudgetManagement.Models;
using BudgetManagement.Repository;
using BudgetManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManagement.Controllers
{
    class MainFormController
    {

        public static int userId;
        public static string userEmail;
         
        // authntication
        public static bool Authentication (string email, string password)
        {

            string response;
            String Key = UserRepositoryController.getKey();
            List<User> myUserlist = UserRepositoryController.UserList;
            // string decriptPassword = DataCypher.EncryptString(Key, password);
            UserRepositoryController usd = new UserRepositoryController();
             response = usd.VerifyUser(email, password);
            if (response=="true")
            {
                try
                {
                   
                    userId = Convert.ToInt32(myUserlist[0].uID);
                    userEmail = myUserlist[0].uEmail;
                    string decriptPassword = DataCypher.DecryptString(Key, myUserlist[0].uPassword);
                    if (decriptPassword == password)
                    {
                      //  MessageBox.Show(decriptPassword + password+ "Login successful", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return true;
                    }
                    else
                    {
                        
                       // MessageBox.Show("iNVALID PASSWORD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
               
            }
            else
            {
               // MessageBox.Show( "User record with this email does not exist", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
            }

        public static string RegisterUser(string name, string email, string password, string passwordConfirm)
        {
            UserRepositoryController usr = new UserRepositoryController();
            User user = new User(0, name, email, password);
            string returnmsg = usr.AddUser(user);

            return returnmsg;
        }
        public static string SetUpUserDetails()
        {

            List<User> usl = UserRepositoryController.UserList;
            try
            {
                ContactRepositoryController contactRepoObj = new ContactRepositoryController();
                contactRepoObj.GetContact(usl[0].uID);
                return "success";

            }
            catch (Exception)
            {

                return "fail";

            }
        }
    }
    }
