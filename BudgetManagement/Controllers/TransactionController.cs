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
        TransactionView _view;
        Transaction _selectedTransaction;
    RecurringTransaction _selectedRTransaction;
    List<Transaction> myTransactionlist;
    List<RecurringTransaction> myRecurringTransactionlist;
    //List<RecurringTransaction> myRecurringTransactionlist = new List<RecurringTransaction>();

        int userID = UserRepository.GetUserID();
        private static string NewContactName = "";
        internal static string GetNewContactName()
        {
            return NewContactName;
        }

        public TransactionController()
        {
           _view = TransactionView.GetTransactionForm();
            _view.SetTransactionController(this);
            SetTransactionFormDetails();
            _view.Show();
        }

        public void SetTransactionFormDetails()
        {
            TransactionRepository getSaveTransaction = new TransactionRepository();
            getSaveTransaction.GetSavedTransaction(userID);
            TransactionRepository getSaveRTransaction = new TransactionRepository();
            getSaveRTransaction.GetSavedRecurringTransaction(userID);
            myTransactionlist = TransactionRepository.RequestTransactionList();
            myRecurringTransactionlist = TransactionRepository.RequestRecurringTransactionList();
            LoadTransactionView();
            LoadRTransactionView();
        }

        public void AddNewTransaction()
        {
            //string id = _users.FindLastIndex.GetType();
                _selectedTransaction = new Transaction(userID, userID, "", "", "", 0, "", "");
                this.UpdateViewDetailValues(_selectedTransaction);
                this._view.CanModifyID = false; 
        }

        //add new recurring transaction
        public void AddNewRTransaction()
        {
            DateTime now = DateTime.Now;
            string date = now.ToString();
            _selectedRTransaction = new RecurringTransaction(userID, userID, "", "", date, 0, "", "", "", date);
            this.UpdateViewDetailValues(_selectedRTransaction);
            this._view.CanModifyRID = false;
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
                    myTransactionlist = transactionRepoObj.GetSavedTransaction(userID);
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
        //remove recurring transaction
        internal void RemoveRTransaction()
        {
            string id = this._view.GetIdOfSelectedRTransactionInGrid();


            RecurringTransaction rTransactionToRemove = null;

            if (id != "")
            {
                foreach (RecurringTransaction rTransaction in this.myRecurringTransactionlist)
                {
                    if (rTransaction.transID.ToString() == id)
                    {
                        rTransactionToRemove = rTransaction;
                        break;
                    }
                }

                if (rTransactionToRemove != null)
                {
                    TransactionRepository transactionRepoObj = new TransactionRepository();
                    string returnMsg = transactionRepoObj.DeleteTransaction(rTransactionToRemove);
                    if (returnMsg == "success")
                    {
                        myRecurringTransactionlist = transactionRepoObj.GetSavedRecurringTransaction(userID);
                        int newRSelectedIndex = this.myRecurringTransactionlist.IndexOf(rTransactionToRemove);
                        //this.myTransactionlist.Remove(transactionToRemove);
                        this._view.RemoveTransactionFromGrid(rTransactionToRemove);

                        if (newRSelectedIndex > -1 && newRSelectedIndex < myRecurringTransactionlist.Count)
                        {
                            this._view.SetSelectedTransactionInGrid(myRecurringTransactionlist[newRSelectedIndex]);
                        }
                    }
                    else
                    {
                        MessageBox.Show(returnMsg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }

        internal void SaveRTransaction()
        {
            updateTransactionWithViewValues(_selectedRTransaction);
            int id = UserRepository.GetUserID();

            if (!this.myRecurringTransactionlist.Contains(_selectedRTransaction))
            {
                // Add new transaction
                TransactionRepository transactionRepoObj = new TransactionRepository();
                string returnMsg = transactionRepoObj.AddTransaction(_selectedRTransaction);

                if (returnMsg == "success")
                {
                    this._view.ClearRGrid();
                    TransactionRepository transactionObj = new TransactionRepository();

                    myRecurringTransactionlist.Clear();
                    myRecurringTransactionlist = transactionObj.GetSavedRecurringTransaction(id);
                    foreach (RecurringTransaction transaction in this.myRecurringTransactionlist)
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
                string returnMsg = transactionRepoObj.UpdateTransaction(_selectedRTransaction);
                myRecurringTransactionlist = transactionRepoObj.GetSavedRecurringTransaction(id);
                if (returnMsg == "success")
                {
                    this._view.UpdateGridWithChangedTransaction(_selectedRTransaction);
                    MessageBox.Show(returnMsg, "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show(returnMsg, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            _view.SetSelectedTransactionInGrid(_selectedRTransaction);
            this._view.CanModifyRID = false;
        }

        internal void SaveTransaction()
        {
        updateTransactionWithViewValues(_selectedTransaction);
        if (!this.myTransactionlist.Contains(_selectedTransaction))
        {
            TransactionRepository transactionRepoObj = new TransactionRepository();
            string returnMsg = transactionRepoObj.AddTransaction(_selectedTransaction);
            if (returnMsg == "success")
            {
                this._view.ClearGrid();
                int id = UserRepository.GetUserID();
                TransactionRepository transactionObj = new TransactionRepository();
                myTransactionlist = transactionObj.GetSavedTransaction(id);
                foreach (Transaction transaction in this.myTransactionlist)
                {
                    this._view.AddTransactionToGrid(transaction); //UPDATE GRIDE

                }
                MessageBox.Show("ADDED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                   string Dcontact= _selectedTransaction.transContact;
                   List<Contact> dContactList = ContactRepository.GetContactList();

            
                    int contactExist = 0;
                    foreach (var contact in dContactList)
                    {
                        if(Dcontact == contact.cName)
                        {
                            contactExist = 1;
                        }
                    }
                    if (contactExist == 0)
                    {
                        NewContactName = _selectedTransaction.transContact;
                        ContactView ContactForm = ContactView.GetContactForm();
                        ContactController controller = new ContactController(ContactForm, dContactList);
                        controller.LoadContactView();

                        ContactForm.Show();
                    }
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
                UpdateViewDetailValues(transaction);
                _view.SetSelectedTransactionInGrid(transaction);
                this._view.CanModifyID = false;
                break;
            }
        }
    }
    public void SelectedRTransactionChanged(string selectedRTransactionId)
    {
            foreach (RecurringTransaction rTransaction in this.myRecurringTransactionlist)
             {
            if (rTransaction.transID.ToString() == selectedRTransactionId)
            {
                _selectedRTransaction = rTransaction;
                UpdateViewDetailValues(rTransaction);
                _view.SetSelectedTransactionInGrid(rTransaction);
                this._view.CanModifyRID = false;
                break;
            }
        }

        }

        private void UpdateViewDetailValues(Transaction transaction)
         {
            if (transaction is RecurringTransaction rTransaction)
            {
                _view.ViewRTransID = rTransaction.transID.ToString();
                _view.ViewRTransName = rTransaction.transName;
                _view.ViewRTransAmount = rTransaction.transAmount;
                _view.ViewRTransType = rTransaction.transType;
                _view.ViewRTransNote = rTransaction.transNote;
                _view.ViewRTransStartDate = rTransaction.TransDate;
                _view.ViewRTransEndDate = rTransaction.transEndDate;
                _view.ViewRTransContact = rTransaction.transContact;
                _view.viewRTransFrequency = rTransaction.transFreQuency;
            }
            else
            {
                _view.ViewTransID = transaction.transID.ToString();
                _view.ViewTransName = transaction.transName;
                _view.ViewTransAmount = transaction.transAmount;
                _view.ViewTransType = transaction.transType;
                _view.ViewTransNote = transaction.transNote;
                _view.ViewTransDate = transaction.TransDate;
                _view.ViewTransContact = transaction.transContact;
            }

        }

        private void updateTransactionWithViewValues(Transaction transaction)
         {
            if (transaction is RecurringTransaction rTransaction)
            {
                rTransaction.transID = Convert.ToInt32(_view.ViewRTransID);
                rTransaction.transName = _view.ViewRTransName;
                rTransaction.transAmount = _view.ViewRTransAmount;
                rTransaction.transType = _view.ViewRTransType;
                rTransaction.transNote = _view.ViewRTransNote;
                rTransaction.TransDate = _view.ViewRTransStartDate;
                rTransaction.transEndDate = _view.ViewRTransEndDate;
                rTransaction.transContact = _view.ViewRTransContact;
                rTransaction.transFreQuency = _view.viewRTransFrequency;
            }
            else
            {
                transaction.transID = Convert.ToInt32(_view.ViewTransID);
                transaction.transName = _view.ViewTransName;
                transaction.transAmount = _view.ViewTransAmount;
                transaction.transType = _view.ViewTransType;
                transaction.transNote = _view.ViewTransNote;
                transaction.TransDate = _view.ViewTransDate;
                transaction.transContact = _view.ViewTransContact;
            }

        }

    public void LoadTransactionView()
    {
        _view.ClearGrid();
        if (myTransactionlist.Count > 0)
        {
            foreach (Transaction transaction in myTransactionlist)
                {
                    _view.AddTransactionToGrid(transaction);
                }
               
            _view.SetSelectedTransactionInGrid((Transaction)myTransactionlist[0]);
        }


    }

        //recuring transaction functions.
        public void LoadRTransactionView()
        {
            _view.ClearRGrid();
            if (myRecurringTransactionlist.Count > 0)
            {
                foreach (RecurringTransaction rTransaction in myRecurringTransactionlist)
                {
                    _view.AddTransactionToGrid(rTransaction);

                }
                _view.SetSelectedTransactionInGrid((RecurringTransaction)myRecurringTransactionlist[0]);
            }


        }
    }
}
