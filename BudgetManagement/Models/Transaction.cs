﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement.Models
{
    public class Transaction
    {
        public Transaction(int id, int UserID,string name, string note, string datetime, double amount, string type, string contact)
        {
            transID = id;
            transUserID = UserID;
            transName = name;
            transNote = note;
            transAmount = amount;
            transType = type;
            TransDate = datetime;
            transContact = contact;
        }
        public Transaction()
        {
            //Transaction transObj;
            //transObj.addTransaction("Product Buy","","05,11,2019",100,"income",&Category("Game",500));

        }

        public int transID { get; set; }
        public int transUserID { get; set; }
        public string transName { get; set; }
        public string transNote { get; set; }
        public double transAmount { get; set; }
        public string transType { get; set; }
        public string TransDate { get; set; }
        public string transContact { get; set; }


    }
}
