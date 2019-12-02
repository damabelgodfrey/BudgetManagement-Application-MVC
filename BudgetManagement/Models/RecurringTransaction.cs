﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement.Models
{
    public class RecurringTransaction: Transaction
    {
        public RecurringTransaction(int id, int UserID, string name, string note, string datetime, double amount, string type, string contact,string frequency,string endDate) : base()
        {
            transID = id;
            transUserID = UserID;
            transName = name;
            transNote = note;
            transAmount = amount;
            transType = type;
            TransDate = datetime;
            transContact = contact;
            transFreQuency = frequency;
            transEndDate = endDate;

        }
        public string transFreQuency { get; set; }
        public string transEndDate { get; set; }
    }
}
