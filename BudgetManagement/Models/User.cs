using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement.Models
{
    class User
    {
        public int uID { get; set; }
        public string uPassword { get; set; }
        public string uName { get; set; }
        public string uEmail { get; set; }



        public User(int id, string name, string email, string password)
        {
            uID = id;
            uPassword = password;
            uName = name;
            uEmail = email;
        }
    }
}
