using BudgetManagement.Models;
using BudgetManagement.Repository;
using BudgetManagement.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManagement.Controllers
{
    public class ExpensePredictionController
    {

        int userId = UserRepository.GetUserID();
        double prediction = 0;
        List<Transaction> myTransactionlist;
        List<RecurringTransaction> myRecurringTransactionlist;
        DateTime predictionDate;




        public ExpensePredictionController(DateTime date)
        {
           
            predictionDate = date.Date;
            SetUpTransactionDetail();


        }

        public async void SetUpTransactionDetail()
        {
            TransactionRepository getSaveTransaction = new TransactionRepository();
            TransactionRepository getSaveRecurringTransaction = new TransactionRepository();
            myTransactionlist = await Task.Run(() => getSaveTransaction.GetSavedTransaction(userId));
            myRecurringTransactionlist = await Task.Run(() => getSaveRecurringTransaction.GetSavedRecurringTransaction(userId));
            GeneratePrediction();


        }

        internal double GeneratePrediction()
        {
            double averageOfTransaction = GetAverage(myTransactionlist);
            double totalOfRecurringTransaction = GetRecurringTransactionAmount(myRecurringTransactionlist);
            

            if (averageOfTransaction > totalOfRecurringTransaction)
            {
                prediction = averageOfTransaction;
            }
            else
            {
                prediction = totalOfRecurringTransaction;
            }
            MessageBox.Show("Predicted Expense: £" + prediction, "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return prediction;
        }

        private double GetAverage(List<Transaction> transactionList)
        {
            double averageAmount = 0;
            double totalAverageAmount = 0;
            double totalForWeekDay = 0;
            double totalForMonthDay = 0;
            double totalFor30Days = 0;

            int noOfWeekDay = 0;
            int noOfMonthDay = 0;
            int noOf30Days = 0;

            DateTime lastMonth = predictionDate.AddMonths(-1);

            foreach (Transaction transaction in transactionList)
            {
                if (transaction.TransDate.DayOfWeek == predictionDate.DayOfWeek)
                {
                    totalForWeekDay += transaction.transAmount;
                    noOfWeekDay++;
                }

                if (transaction.TransDate.Day == predictionDate.Day)
                {
                    totalForMonthDay += transaction.transAmount;
                    noOfMonthDay++;
                }

                if (transaction.TransDate >= lastMonth)
                {
                    totalFor30Days += transaction.transAmount;
                    noOf30Days++;
                }
            }

            int num = 0;
            if (noOfWeekDay > 0)
            {
                num++;
                totalAverageAmount += totalForWeekDay / noOfWeekDay;
            }

            if (noOfMonthDay > 0)
            {
                num++;
                totalAverageAmount += totalForMonthDay / noOfMonthDay;
            }

            if (noOf30Days > 0)
            {
                num++;
                totalAverageAmount += totalFor30Days / noOf30Days;
            }

            if (num > 0)
            {
                averageAmount = totalAverageAmount / num;
            }

            return averageAmount;
        }

        //
        private double GetRecurringTransactionAmount(List<RecurringTransaction> recurringTransactionList)
        {
            double totalAmount = 0;
            DateTime predictDate = predictionDate;
            foreach (RecurringTransaction recurringTransaction in recurringTransactionList)
            {
                string transactionDate = recurringTransaction.TransDate.ToString("dd/MM");
                string predictionDate = predictDate.ToString("dd/MM");

                if (recurringTransaction.transFreQuency.Equals("Yearly"))
                {
                    if (transactionDate.Equals(predictDate))
                    {
                        totalAmount += recurringTransaction.transAmount;
                    }

                }

                if (recurringTransaction.transFreQuency.Equals("Monthly"))
                {
                    if (recurringTransaction.TransDate.Day == predictDate.Day)
                    {
                        totalAmount += recurringTransaction.transAmount;
                    }
                }

                if (recurringTransaction.transFreQuency.Equals("Weekly"))
                {
                    if (recurringTransaction.TransDate.DayOfWeek == predictDate.DayOfWeek)
                    {
                        totalAmount += recurringTransaction.transAmount;
                    }
                }

                if (recurringTransaction.transFreQuency.Equals("Daily"))
                {
                    totalAmount += recurringTransaction.transAmount;
                }
            }

            return totalAmount;
        }

    }
}
