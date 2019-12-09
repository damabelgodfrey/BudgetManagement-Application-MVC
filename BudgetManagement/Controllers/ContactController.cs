using BudgetManagement.Models;
using BudgetManagement.Repository;
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
        IContactView _view;
        Contact _selectedUser;
        List<Contact> myContactlist;
        int userID = UserRepository.GetUserID();
        string contactName = TransactionController.GetNewContactName();

        public ContactController(IContactView view, List<Contact> mycontact)
        {
            this._view = view;
            this.myContactlist = mycontact;
            view.SetContactController(this);
        }

        public void AddNewContact()
        {
            //string id = _users.FindLastIndex.GetType();
            

            _selectedUser = new Contact(userID, userID, contactName, "","");

            this.updateViewDetailValues(_selectedUser);
            this._view.CanModifyID = false;

        }
        public void RemoveContact()
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
                    string returnMsg = contactRepoObj.DeleteContact(contactToRemove);
                    if (returnMsg == "success")
                    {
                        myContactlist = contactRepoObj.GetSavedContact(userID);
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

        public void SaveContact()
        {
            updateContactWithViewValues(_selectedUser);
            if (!this.myContactlist.Contains(_selectedUser))
            {
                // Add new contact

                this.myContactlist.Add(_selectedUser);
                ContactRepository contactRepoObj = new ContactRepository();


                string returnMsg = contactRepoObj.AddContact(_selectedUser);
                MessageBox.Show(returnMsg.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (returnMsg == "success")
                {
                    this._view.ClearGrid();
                    int id = UserRepository.GetUserID();
                    ContactRepository contactObj = new ContactRepository();
                     myContactlist = contactObj.GetSavedContact(id);
                    foreach (Contact contact in this.myContactlist)
                    {
                    this._view.AddContactToGrid(contact); //UPDATE GRIDE
                        MessageBox.Show(contact.cID+" Updating view", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Warning);


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
