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
    public class ContactController
    {
        ContactView _view;
        Contact _selectedUser;
        List<Contact> myContactlist;
        int userID;
        string contactName = TransactionController.GetNewContactName();

        public ContactController()
        {
            _view = ContactView.GetContactForm();
            
            _view.SetContactController(this);
            SetContactFormDetails();
            _view.WindowState = FormWindowState.Normal;
            _view.Activate();
            _view.Show();
        }

        private void SetContactFormDetails()
        {
            userID = UserRepository.GetUserID();
            ContactRepository getSaveTransaction = new ContactRepository();
            myContactlist= getSaveTransaction.GetSavedContact(userID);
          
            LoadContactView();
        }

        public void AddNewContact()
        {
            _selectedUser = new Contact(userID, userID, contactName, "","");
            this.updateViewDetailValues(_selectedUser);
            this._view.CanModifyID = false;
        }
        public async void  RemoveContact()
        {
            string id = this._view.GetIdOfSelectedContactInGrid();


            Contact contactToRemove = null;

            if (id != "")
            {
                foreach (Contact contact in this.myContactlist)
                {
                    if (contact.cID.ToString() == id)
                    {
                        contactToRemove = contact;
                        break;
                    }
                }

                if (contactToRemove != null)
                {

                    ContactRepository contactRepoObj = new ContactRepository();
                    string returnMsg = await Task.Run(() => contactRepoObj.DeleteContact(contactToRemove));
                    if (returnMsg == "success")
                    {
                        myContactlist =  contactRepoObj.GetSavedContact(userID);
                        int newSelectedIndex = this.myContactlist.IndexOf(contactToRemove);
                        //this.myContactlist.Remove(contactToRemove);
                        this._view.RemoveContactFromGrid(contactToRemove);

                        if (newSelectedIndex > -1 && newSelectedIndex < myContactlist.Count)
                        {
                            this._view.SetSelectedContactInGrid((Contact)myContactlist[newSelectedIndex]);
                        }
                    }
                    else
                    {
                        MessageBox.Show(returnMsg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
            }
        }

        public async void SaveContact()
        {
            updateContactWithViewValues(_selectedUser);
            if (!this.myContactlist.Contains(_selectedUser))
            {
                // Add new contact

                this.myContactlist.Add(_selectedUser);
                ContactRepository contactRepoObj = new ContactRepository();


                string returnMsg = await Task.Run(() => contactRepoObj.AddContact(_selectedUser));
                if (returnMsg == "success")
                {
                    this._view.ClearGrid();
                    int id = UserRepository.GetUserID();
                    ContactRepository contactObj = new ContactRepository();
                     myContactlist = contactObj.GetSavedContact(id);
                    foreach (Contact contact in this.myContactlist)
                    {
                    this._view.AddContactToGrid(contact); //UPDATE GRIDE
                    }

                    MessageBox.Show("ADDED SUCCESSFULLY", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show(returnMsg.ToString()+"  Contact was not able to update to database", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            else
            {
                // Update existing contact
                this._view.UpdateGridWithChangedContact(_selectedUser);
            }
            _view.SetSelectedContactInGrid(_selectedUser);
            this._view.CanModifyID = false;
        }

        public void SelectedContactChanged(string selectedContactId)
        {
            foreach (Contact contact in this.myContactlist)
            {
                if (contact.cID.ToString() == selectedContactId)
                {
                    _selectedUser = contact;
                    updateViewDetailValues(contact);
                    _view.SetSelectedContactInGrid(contact);
                    this._view.CanModifyID = false;
                    break;
                }
            }
        }
        private void updateViewDetailValues(Contact contact)
        {
            _view.ContactName = contact.cName;
            _view.Address = contact.cAddress;
            _view.CID = contact.cID.ToString();
            _view.ContactType = contact.cType;
        }


        private void updateContactWithViewValues(Contact contact)
        {
            contact.cName = _view.ContactName;
            contact.cAddress = _view.Address;
            contact.cID = Convert.ToInt32(_view.CID);
            contact.cType = _view.ContactType;
        }

        public void LoadContactView()
        {
            _view.ClearGrid();
            if (myContactlist.Count > 0)
            {

                foreach (Contact contact in myContactlist)
                    _view.AddContactToGrid(contact);

                _view.SetSelectedContactInGrid((Contact)myContactlist[0]);
            }


        }
    }
}
