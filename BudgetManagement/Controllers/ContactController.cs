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
        private static List<Contact> myContactlist;
        private int userID;
        public ContactController()
        {
            _view = ContactView.GetContactForm();

            _view.SetContactController(this);
            SetContactFormDetails();
            _view.WindowState = FormWindowState.Normal;
            _view.Activate();
            _view.Show();
        }
        public void DisposeContactView()
        {

            _view.Dispose();
        }

        private void SetContactFormDetails()
        {
            userID = UserRepository.GetUserID();
            ContactRepository getSaveTransaction = new ContactRepository();
            myContactlist = getSaveTransaction.GetSavedContact(userID);

            LoadContactView();
        }

        public void AddNewContact()
        {
            _selectedUser = new Contact(userID, userID, "", "", "");
            this.UpdateViewDetailValues(_selectedUser);
        }
        public async void DeleteContact(Contact contact)
        {
            ContactRepository contactRepoObj = new ContactRepository();
            string returnMsg = await Task.Run(() => contactRepoObj.DeleteContact(contact));
            if (returnMsg == "success")
            {
                myContactlist.Clear();
                myContactlist = contactRepoObj.GetSavedContact(userID);
                int newSelectedIndex = myContactlist.IndexOf(contact)+1;
                this._view.RemoveContactFromGrid(contact);

                if (newSelectedIndex > -1 && newSelectedIndex < myContactlist.Count)
                {
                    this._view.SetSelectedContactInGrid(myContactlist[newSelectedIndex]);
                }
            }
            else
            {
                MessageBox.Show(returnMsg, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public async void UpdateContact(Contact contact)
        {
            string returnMsg = "false";
            ContactRepository contactRepoObj = new ContactRepository();

            returnMsg = await Task.Run(() => contactRepoObj.UpdateContact(contact));

            myContactlist.Clear();
            myContactlist = contactRepoObj.GetSavedContact(userID);

            if (returnMsg == "success")
            {
                this._view.UpdateGridWithChangedContact(contact);
                MessageBox.Show("Updated SUCCESSFULLY");
            }
            else
            {
                MessageBox.Show(returnMsg, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SelectedContactChanged(string selectedContactId)
        {
            foreach (Contact contact in myContactlist)
            {
                if (contact.cID.ToString() == selectedContactId)
                {
                    UpdateViewDetailValues(contact);
                    _view.SetSelectedContactInGrid(contact);
                    break;
                }
            }
        }
        private void UpdateViewDetailValues(Contact contact)
        {
            _view.ContactName = contact.cName;
            _view.Address = contact.cAddress;
            _view.CID = contact.cID;
            _view.ContactType = contact.cType;
        }

        public void LoadContactView()
        {
            _view.ClearGrid();
            if (myContactlist.Count > 0)
            {

                foreach (Contact contact in myContactlist)
                {
                    _view.AddContactToGrid(contact);
                }
                _view.SetSelectedContactInGrid(myContactlist[0]);
            }


        }

        internal async void AddContact(Contact contact)
        {
            ContactRepository contactRepoObj = new ContactRepository();
            string returnMsg = await Task.Run(() => contactRepoObj.AddContact(contact));
            if (returnMsg == "success")
            {
                ContactRepository contactRepoObj1 = new ContactRepository();

                this._view.ClearGrid();
                myContactlist.Clear();
                myContactlist = await Task.Run(() => contactRepoObj1.GetSavedContact(userID));

                foreach (Contact mycontact in myContactlist.ToList())
                {
                    this._view.AddContactToGrid(mycontact);
                }
            }
        }
    }
}
