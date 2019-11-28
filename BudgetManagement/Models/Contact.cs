using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement.Models
{
    class Contact
    {

        public int cID { get; set; }
        public int cUserId { get; set; }
        public string cName { get; set; }
        public string cAddress { get; set; }
        public string cType { get; set; }
        



        public Contact(int id, int userId,string name, string address, string type)
        {
            cID = id;
            cUserId = userId;
            cName = name;
            cAddress = address;
            cType = type;
        }

        public Contact()
        {
        }
    }
}
