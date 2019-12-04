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
   public class TransactionController {
        ITransactionView _view;
    Transaction _selectedTransaction;
    List<Transaction> myTransactionlist;
    int userID = UserRepository.GetUserID();

    public TransactionController(ITransactionView view, List<Transaction> mytransaction)
    {
        this._view = view;
        this.myTransactionlist = mytransaction;
        _view.SetTransactionController(this);
    }

    public void AddNewTransaction()
    {
            //string id = _users.FindLastIndex.GetType();

            try
            {
                _selectedTransaction = new Transaction(userID, userID, "", "", "", 0, "", "");
            }
            catch (Exception)
            {
                DateTime now = DateTime.Now;
                string date = now.ToString();
                _selectedTransaction = new RecurringTransaction(userID, userID, "", "", date, 0, "", "","", date);
            }
        

        this.updateViewDetailValues(_selectedTransaction);
        this._view.CanModifyID = false;

    }

    
    public void RemoveTransaction()
    {
        string id = this._view.GetIdOfSelectedTransactionInGrid();


        Transaction transactionToRemove = null;

        if (id != "")
        {
            foreach (Transaction transaction in this.myTransactionlist)
            {
                if (transaction.transID.ToString() == id)
                {
                    transactionToRemove = transaction;
                    break;
                }
            }

            if (transactionToRemove != null)
            {

                TransactionRepository transactionRepoObj = new TransactionRepository();
                string returnMsg = transactionRepoObj.DeleteTransaction(transactionToRemove);
                if (returnMsg == "success")
                {
                    myTransactionlist = transactionRepoObj.GetTransaction(userID);
                    int newSelectedIndex = this.myTransactionlist.IndexOf(transactionToRemove);
                    //this.myTransactionlist.Remove(transactionToRemove);
                    this._view.RemoveTransactionFromGrid(transactionToRemove);

                    if (newSelectedIndex > -1 && newSelectedIndex < myTransactionlist.Count)
                    {
                        this._view.SetSelectedTransactionInGrid((Transaction)myTransactionlist[newSelectedIndex]);
                    }
                }
                else
                {
                    MessageBox.Show(returnMsg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }
    }

    public void SaveTransaction()
    {
        updateTransactionWithViewValues(_selectedTransaction);
        if (!this.myTransactionlist.Contains(_selectedTransaction))
        {
            // Add new transaction

           // this.myTransactionlist.Add(_selectedTransaction);
            TransactionRepository transactionRepoObj = new TransactionRepository();


            string returnMsg = transactionRepoObj.AddTransaction(_selectedTransaction);
           // MessageBox.Show(returnMsg.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (returnMsg == "success")
            {
                this._view.ClearGrid();
                int id = UserRepository.GetUserID();
                TransactionRepository transactionObj = new TransactionRepository();
                myTransactionlist = transactionObj.GetTransaction(id);
                foreach (Transaction transaction in this.myTransactionlist)
                {
                    this._view.AddTransactionToGrid(transaction); //UPDATE GRIDE

                }
                MessageBox.Show("ADDED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                MessageBox.Show(returnMsg.ToString() + "  Transaction was not able to be added to database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        else
        {
                // Update existing transaction
                TransactionRepository transactionRepoObj = new TransactionRepository();
                string returnMsg = transactionRepoObj.UpdateTransaction(_selectedTransaction);
                if(returnMsg == "success")
                {
                    this._view.UpdateGridWithChangedTransaction(_selectedTransaction);
                    MessageBox.Show(returnMsg, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show(returnMsg, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
        _view.SetSelectedTransactionInGrid(_selectedTransaction);
        this._view.CanModifyID = false;
    }

    public void SelectedTransactionChanged(string selectedTransactionId)
    {
        foreach (Transaction transaction in this.myTransactionlist)
        {
            if (transaction.transID.ToString() == selectedTransactionId)
            {
                _selectedTransaction = transaction;
                updateViewDetailValues(transaction);
                _view.SetSelectedTransactionInGrid(transaction);
                this._view.CanModifyID = false;
                break;
            }
        }
    }
    private void updateViewDetailValues(Transaction transaction)
    {
        _view.ViewTransID = transaction.transID.ToString();
        _view.ViewTransName = transaction.transName;
        _view.ViewTransAmount = transaction.transAmount;
        _view.ViewTransType = transaction.transType;
        _view.ViewTransNote = transaction.transNote;
        _view.ViewTransDate = transaction.TransDate;
        _view.ViewTransContact = transaction.transContact;
        }

        private void updateTransactionWithViewValues(Transaction transaction)
         {
            transaction.transID = Convert.ToInt32(_view.ViewTransID);
            transaction.transName = _view.ViewTransName;
            transaction.transAmount = _view.ViewTransAmount;
            transaction.transType = _view.ViewTransType;
            transaction.transNote = _view.ViewTransNote;
            transaction.TransDate = _view.ViewTransDate;
            transaction.transContact = _view.ViewTransContact;
        }

    public void LoadTransactionView()
    {
        _view.ClearGrid();
        if (myTransactionlist.Count > 0)
        {

            foreach (Transaction transaction in myTransactionlist)
                _view.AddTransactionToGrid(transaction);

            _view.SetSelectedTransactionInGrid((Transaction)myTransactionlist[0]);
        }


    }
}
}
