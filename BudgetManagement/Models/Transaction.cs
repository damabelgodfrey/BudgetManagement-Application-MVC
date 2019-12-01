using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement.Models
{
    public class Transaction
    {
        public Transaction(int id, string name, string occurance, string date, double amount, string type, string contact)
        {
            transID = id;
            transName = name;
            transAmount = amount;
            transType = type;
            TransDate = date;
            transOccurance = occurance;
            transContact = contact;
        }
        Transaction()
        {
            //Transaction transObj;
            //transObj.addTransaction("Product Buy","","05,11,2019",100,"income",&Category("Game",500));

        }

        public int transID { get; set; }
        public string transName { get; set; }
        public double transAmount { get; set; }
        public string transType { get; set; }
        public string TransDate { get; set; }
        public string transOccurance { get; set; }
        public string transContact { get; set; }


    }
}
