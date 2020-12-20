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
    public class TransactionController
    {
        TransactionView _view;
        Transaction _selectedTransaction;
        RecurringTransaction _selectedRTransaction;
        private static List<Transaction> myTransactionlist;
        private static List<RecurringTransaction> myRecurringTransactionlist;
        //List<RecurringTransaction> myRecurringTransactionlist = new List<RecurringTransaction>();

        int userID = UserRepository.GetUserID();

        public TransactionController()
        {
            _view = TransactionView.GetTransactionForm();
            _view.SetTransactionController(this);
            SetTransactionFormDetails();
            _view.WindowState = FormWindowState.Normal;
            _view.Activate();
            _view.Show();
        }

        public void SetTransactionFormDetails()
        {
            TransactionRepository getSaveTransaction = new TransactionRepository();

            TransactionRepository getSaveRTransaction = new TransactionRepository();
            myTransactionlist = getSaveTransaction.GetSavedTransaction(userID);
            myRecurringTransactionlist = getSaveRTransaction.GetSavedRecurringTransaction(userID);
            LoadTransactionView("RecurringTrans");
            LoadTransactionView("NormalTrans");
        }

        public void AddNewTransaction(string transflag)
        {
            //string id = _users.FindLastIndex.GetType();
            DateTime now = DateTime.Now;
            if (transflag == "RecurringTrans")
            {
                _selectedRTransaction = new RecurringTransaction(0, userID, "", "", now, 0, "", "", "", now);
                this.UpdateViewDetailValues(_selectedRTransaction); // default  setting

            }
            else
            {

                _selectedTransaction = new Transaction(0, userID, "", "", now, 0, "", "");
                this.UpdateViewDetailValues(_selectedTransaction); // default  setting

            }
        }
        public async void DeleteTransaction(Transaction trans)
        {
            TransactionRepository transactionRepoObj = new TransactionRepository();
            string returnMsg = await Task.Run(() => transactionRepoObj.DeleteTransaction(trans));
            if (returnMsg == "success")
            {
                if (trans is RecurringTransaction rTransaction)
                {
                    myRecurringTransactionlist.Clear();
                    myRecurringTransactionlist = transactionRepoObj.GetSavedRecurringTransaction(userID);
                    this._view.RemoveTransactionFromGrid(trans);


                    int newSelectedTransIndex = myRecurringTransactionlist.IndexOf(rTransaction) + 1;
                    if (newSelectedTransIndex > -1 && newSelectedTransIndex < myRecurringTransactionlist.Count)
                    {

                        this._view.SetSelectedTransactionInGrid(myRecurringTransactionlist[newSelectedTransIndex]);
                    }


                }else
                {
                    int newSelectedIndex = myTransactionlist.IndexOf(trans) + 1;
                    myTransactionlist.Clear();
                    myTransactionlist = transactionRepoObj.GetSavedTransaction(userID);
                    this._view.RemoveTransactionFromGrid(trans);
                    if (newSelectedIndex > -1 && newSelectedIndex < myTransactionlist.Count)
                    {
                        this._view.SetSelectedTransactionInGrid(myTransactionlist[newSelectedIndex]);
                    }


                }
            }
            else
            {
                MessageBox.Show(returnMsg + " transaction not deleted", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Update existing transaction or its subtype

        internal async void UpdateTransaction(Transaction updatedTrans)
        {
            string returnMsg = "false";
            TransactionRepository transactionRepoObj = new TransactionRepository();

            returnMsg = await Task.Run(() => transactionRepoObj.UpdateTransaction(updatedTrans));

            if (updatedTrans is Transaction)
            {
                myTransactionlist.Clear();
                myTransactionlist = transactionRepoObj.GetSavedTransaction(userID);
            }
            if (updatedTrans is RecurringTransaction)
            {
                myRecurringTransactionlist.Clear();
                myRecurringTransactionlist = transactionRepoObj.GetSavedRecurringTransaction(userID);
            }

            if (returnMsg == "success")
            {
                this._view.UpdateGridWithChangedTransaction(updatedTrans);
                MessageBox.Show("Updated SUCCESSFULLY");
                NewContactDetectAdder(updatedTrans);
            }
            else
            {
                MessageBox.Show(returnMsg, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            _view.SetSelectedTransactionInGrid(updatedTrans);

        }

        public async void AddTransaction(Transaction trans)
        {
            TransactionRepository transactionRepoObj = new TransactionRepository();
            string returnMsg = await Task.Run(() => transactionRepoObj.AddTransaction(trans));
            if (returnMsg == "success")
            {
                TransactionRepository transactionObj = new TransactionRepository();

                if (trans is Transaction)
                {

                    this._view.ClearGrid("NormalTrans");
                    myTransactionlist.Clear();
                    myTransactionlist = await Task.Run(() => transactionObj.GetSavedTransaction(userID));
                    int i = 1;

                    foreach (Transaction transaction in myTransactionlist.ToList())
                    {
                        this._view.AddTransactionToGrid(transaction); //UPDATE GRIDE
                        i++;
                    }
                }
                if (trans is RecurringTransaction)
                {
                    this._view.ClearGrid("RecurringTrans");
                    myRecurringTransactionlist.Clear();
                    myRecurringTransactionlist = await Task.Run(() => transactionObj.GetSavedRecurringTransaction(userID));
                    int i = 1;
                    foreach (RecurringTransaction rTransaction in myRecurringTransactionlist.ToList())
                    {
                        this._view.AddTransactionToGrid(rTransaction); //UPDATE GRIDE
                        i++;
                    }
                }

                NewContactDetectAdder(trans);
                MessageBox.Show(trans.transName + " ADDED SUCCESSFULLY");
            }
            else
            {
                MessageBox.Show(returnMsg, "Add Operation Confirmation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void NewContactDetectAdder(Transaction trans)
        {
            bool found = false;
            foreach (Contact contact in ContactRepository.GetContactList())
            {
                if (contact.cName == trans.transContact)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {

                var result = MessageBox.Show("Do you want to add [" + trans.transContact + "] as new contact?", "New Contact Alert",
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {


                    ContactRepository contactRepoObj = new ContactRepository();
                    String ContactType = "Payee";
                    if (trans.transType == "Income")
                    {
                        ContactType = "Payer";
                    }
                    Contact contact = new Contact(0, userID, trans.transContact, "", ContactType);

                    string returnMsg2 = await Task.Run(() => contactRepoObj.AddContact(contact));
                    if (returnMsg2 == "success")
                    {
                        MessageBox.Show(trans.transContact + " Contact Added successfully");
                        ContactRepository contacts = new ContactRepository();
                        List<Contact> myContacts = contacts.GetSavedContact(userID);
                        _view.tContactCombobox.DataSource = null;
                        _view.tContactCombobox.DataSource = myContacts;
                        _view.tContactCombobox.DisplayMember = "cName";
                        _view.rTransContactList.DataSource = null;
                        _view.rTransContactList.DataSource =myContacts;
                        _view.rTransContactList.DisplayMember = "cName";
                        
                    }
                    else
                    {
                        MessageBox.Show(trans.transContact + " Contact Failed to be added");

                    }
                }
                else
                {

                }



            }
        }

        public void SelectedTransactionChanged(string selectedTransactionId)
        {
            foreach (Transaction transaction in myTransactionlist)
            {
                if (transaction.transID.ToString() == selectedTransactionId)
                {
                    // _selectedTransaction = transaction;
                    UpdateViewDetailValues(transaction);
                    _view.SetSelectedTransactionInGrid(transaction);
                    break;
                }
            }
        }
        public void SelectedRTransactionChanged(string selectedRTransactionId)
        {
            foreach (RecurringTransaction rTransaction in myRecurringTransactionlist)
            {
                if (rTransaction.transID.ToString() == selectedRTransactionId)
                {
                    // _selectedRTransaction = rTransaction;
                    UpdateViewDetailValues(rTransaction);
                    _view.SetSelectedTransactionInGrid(rTransaction);
                    break;
                }
            }

        }

        private void UpdateViewDetailValues(Transaction transaction)
        {
            if (transaction is RecurringTransaction rTransaction)
            {
                _view.ViewRTransID = rTransaction.transID;
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
                _view.ViewTransID = transaction.transID;
                _view.ViewTransName = transaction.transName;
                _view.ViewTransAmount = transaction.transAmount;
                _view.ViewTransType = transaction.transType;
                _view.ViewTransNote = transaction.transNote;
                _view.ViewTransDate = transaction.TransDate;
                _view.ViewTransContact = transaction.transContact;
            }

        }

        public void LoadTransactionView(string flag)
        {
            if (flag == "NormalTrans")
            {
                _view.ClearGrid(flag);
                if (myTransactionlist.Count > 0)
                {
                    foreach (Transaction transaction in myTransactionlist)
                    {
                        _view.AddTransactionToGrid(transaction);
                    }
                    _view.SetSelectedTransactionInGrid(myTransactionlist[0]);
                }
            }
            if (flag == "RecurringTrans")
            {
                _view.ClearGrid(flag);
                if (myRecurringTransactionlist.Count > 0)
                {
                    foreach (RecurringTransaction rTransaction in myRecurringTransactionlist.ToList())
                    {
                        _view.AddTransactionToGrid(rTransaction);
                    }
                    _view.SetSelectedTransactionInGrid((RecurringTransaction)myRecurringTransactionlist[0]);
                }
            }
        }

        internal static int GetUserID()
        {
            return UserRepository.GetUserID();
        }


        //private void updateTransactionWithViewValues(Transaction transaction)
        // {
        //    if (transaction is RecurringTransaction rTransaction)
        //    {
        //        rTransaction.transID = Convert.ToInt32(_view.ViewRTransID);
        //        rTransaction.transName = _view.ViewRTransName;
        //        rTransaction.transAmount = _view.ViewRTransAmount;
        //        rTransaction.transType = _view.ViewRTransType;
        //        rTransaction.transNote = _view.ViewRTransNote;
        //        rTransaction.TransDate = Convert.ToDateTime(_view.ViewRTransStartDate);
        //        rTransaction.transEndDate = Convert.ToDateTime(_view.ViewRTransEndDate);
        //        rTransaction.transContact = _view.ViewRTransContact;
        //        rTransaction.transFreQuency = _view.viewRTransFrequency;
        //    }
        //    else
        //    {
        //        transaction.transID = Convert.ToInt32(_view.ViewTransID);
        //        transaction.transName = _view.ViewTransName;
        //        transaction.transAmount = _view.ViewTransAmount;
        //        transaction.transType = _view.ViewTransType;
        //        transaction.transNote = _view.ViewTransNote;
        //        transaction.TransDate = Convert.ToDateTime(_view.ViewTransDate);
        //        transaction.transContact = _view.ViewTransContact;
        //    }

        //}
        //public async void RemoveTransaction()
        //{
        //    string id = this._view.GetIdOfSelectedTransactionInGrid();
        //    Transaction transactionToRemove = null;
        //    if (id != "")
        //    {
        //        foreach (Transaction transaction in this.myTransactionlist)
        //        {
        //            if (transaction.transID.ToString() == id)
        //            {
        //                transactionToRemove = transaction;
        //                break;
        //            }
        //        }

        //        if (transactionToRemove != null)
        //        {

        //            TransactionRepository transactionRepoObj = new TransactionRepository();
        //            string returnMsg = await Task.Run(() => transactionRepoObj.DeleteTransaction(transactionToRemove));
        //            if (returnMsg == "success")
        //            {
        //                myTransactionlist = transactionRepoObj.GetSavedTransaction(userID);
        //                int newSelectedIndex = this.myTransactionlist.IndexOf(transactionToRemove);
        //                //this.myTransactionlist.Remove(transactionToRemove);
        //                this._view.RemoveTransactionFromGrid(transactionToRemove);

        //                if (newSelectedIndex > -1 && newSelectedIndex < myTransactionlist.Count)
        //                {
        //                    this._view.SetSelectedTransactionInGrid((Transaction)myTransactionlist[newSelectedIndex]);
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show(returnMsg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //            }

        //        }
        //    }
        //}
        //remove recurring transaction
        //internal async void RemoveRTransaction()
        //{
        //    string id = this._view.GetIdOfSelectedRTransactionInGrid();


        //    RecurringTransaction rTransactionToRemove = null;

        //    if (id != "")
        //    {
        //        foreach (RecurringTransaction rTransaction in this.myRecurringTransactionlist)
        //        {
        //            if (rTransaction.transID.ToString() == id)
        //            {
        //                rTransactionToRemove = rTransaction;
        //                break;
        //            }
        //        }

        //        if (rTransactionToRemove != null)
        //        {
        //            TransactionRepository transactionRepoObj = new TransactionRepository();
        //            string returnMsg = await Task.Run(() => transactionRepoObj.DeleteTransaction(rTransactionToRemove));
        //            if (returnMsg == "success")
        //            {
        //                myRecurringTransactionlist = transactionRepoObj.GetSavedRecurringTransaction(userID);
        //                int newRSelectedIndex = this.myRecurringTransactionlist.IndexOf(rTransactionToRemove);
        //                //this.myTransactionlist.Remove(transactionToRemove);
        //                this._view.RemoveTransactionFromGrid(rTransactionToRemove);

        //                if (newRSelectedIndex > -1 && newRSelectedIndex < myRecurringTransactionlist.Count)
        //                {
        //                    this._view.SetSelectedTransactionInGrid(myRecurringTransactionlist[newRSelectedIndex]);
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show(returnMsg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //            }

        //        }
        //    }
        //}

        //internal async void SaveRTransaction()
        //{
        //    updateTransactionWithViewValues(_selectedRTransaction);
        //    int id = UserRepository.GetUserID();

        //    MessageBox.Show(myRecurringTransactionlist.Count().ToString());

        //    if (!myRecurringTransactionlist.Contains(_selectedRTransaction))
        //    {
        //        // Add new transaction
        //        TransactionRepository transactionRepoObj = new TransactionRepository();
        //        string returnMsg = await Task.Run(() => transactionRepoObj.AddTransaction(_selectedRTransaction));

        //        if (returnMsg == "success")
        //        {
        //            this._view.ClearRGrid();
        //            TransactionRepository transactionObj = new TransactionRepository();

        //            myRecurringTransactionlist.Clear();
        //            myRecurringTransactionlist = transactionObj.GetSavedRecurringTransaction(id);
        //            foreach (RecurringTransaction transaction in myRecurringTransactionlist)
        //            {
        //                this._view.AddTransactionToGrid(transaction); //UPDATE GRIDE

        //            }
        //            MessageBox.Show("ADDED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //        }
        //        else
        //        {
        //            MessageBox.Show(returnMsg.ToString() + "  Transaction was not able to be added to database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    _view.SetSelectedTransactionInGrid(_selectedRTransaction);
        //    this._view.CanModifyRID = false;
        //}
        //internal async void UpdateRTransaction()
        //{
        //    updateTransactionWithViewValues(_selectedRTransaction);
        //    int id = UserRepository.GetUserID();
        //    TransactionRepository transactionRepoObj = new TransactionRepository();
        //    string returnMsg = await Task.Run(() => transactionRepoObj.UpdateTransaction(_selectedRTransaction));

        //    if (returnMsg == "success")
        //    {
        //        myRecurringTransactionlist.Clear();
        //        myRecurringTransactionlist = transactionRepoObj.GetSavedRecurringTransaction(id);
        //        // this._view.UpdateGridWithChangedTransaction(_selectedRTransaction);
        //        MessageBox.Show("Updated SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        //        _view.ClearRGrid();
        //        if (myRecurringTransactionlist.Count > 0)
        //        {
        //            foreach (RecurringTransaction rTransaction in myRecurringTransactionlist.ToList())
        //            {
        //                _view.AddTransactionToGrid(rTransaction);

        //            }
        //            _view.SetSelectedTransactionInGrid((RecurringTransaction)myRecurringTransactionlist[0]);
        //        }
        //        this._view.CanModifyRID = false;

        //    }
        //    else
        //    {
        //        MessageBox.Show(returnMsg, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //    }

        //}

    }
}
