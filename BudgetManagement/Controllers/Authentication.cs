using BudgetManagement.Models;
using BudgetManagement.Repository;
using BudgetManagement.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace BudgetManagement.Controllers
{
    class Authentication
    {

        public static int userId;
        public static string userEmail;
         
        // authntication
        public static bool AuthenticateUser (string email, string password)
        {

            string response;
            String Key = UserRepository.getKey();
            List<User> myUserlist = UserRepository.UserList;
            // string decriptPassword = DataCypher.EncryptString(Key, password);
            UserRepository usd = new UserRepository();
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
            UserRepository usr = new UserRepository();
            User user = new User(0, name, email, password);
            string returnmsg = usr.AddUser(user);

            return returnmsg;
        }

        // setup user details
        // Contact list, transaction list, events list etc from database into program
        public static string SetUpUserDetails()
        {

            List<User> usl = UserRepository.UserList;

            try
            {   
                //get contacts
                ContactRepository contactRepoObj = new ContactRepository();
                contactRepoObj.GetContact(usl[0].uID);
                //get transaction
                TransactionRepository transRepoObj = new TransactionRepository();
                transRepoObj.GetTransaction(usl[0].uID);
                transRepoObj.GetRecurringTransaction(usl[0].uID);
                //get events
                EventRepository eventRepoObj = new EventRepository();
                eventRepoObj.GetEvents(usl[0].uID);
                eventRepoObj.GetRecurringEvents(usl[0].uID);
                return "success";

            }
            catch (Exception)
            {

                return "fail";

            }
        }

        //check if email in right format
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
    }
