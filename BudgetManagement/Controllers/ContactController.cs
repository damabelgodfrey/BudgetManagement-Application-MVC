using BudgetManagement.Models;
using BudgetManagement.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetManagement.Controllers
{
    public class ContactController
    {
        IDashboardView _view;
        Contact _selectedUser;
        List<Contact> myContactlist;

        public ContactController(IDashboardView view, List<Contact> mycontact)
        {
            this._view = view;
            this.myContactlist = mycontact;
             //IDashboardView.SetContactController(this);
        }

        public void AddNewContact()
        {
            //string id = _users.FindLastIndex.GetType();
            _selectedUser = new Contact(0/*id*/,0,
                                 "" /*name*/,
                                 ""  /*address*/,
                                 ""/*type*/);

            this.updateViewDetailValues(_selectedUser);
            this._view.CanModifyID = true;

        }
        public void RemoveContact()
        {
            string id = this._view.GetIdOfSelectedContactInGrid();
            Contact userToRemove = null;

            if (id != "")
            {
                foreach (Contact contact in this.myContactlist)
                {
                    if (contact.cID.ToString() == id)
                    {
                        userToRemove = contact;
                        break;
                    }
                }

                if (userToRemove != null)
                {
                    int newSelectedIndex = this.myContactlist.IndexOf(userToRemove);
                    this.myContactlist.Remove(userToRemove);
                    this._view.RemoveContactFromGrid(userToRemove);

                    if (newSelectedIndex > -1 && newSelectedIndex < myContactlist.Count)
                    {
                        this._view.SetSelectedContactInGrid((Contact)myContactlist[newSelectedIndex]);
                    }
                }
            }
        }

        public void SaveContact()
        {
            updateContactWithViewValues(_selectedUser);
            if (!this.myContactlist.Contains(_selectedUser))
            {
                // Add new user
                this.myContactlist.Add(_selectedUser);
                this._view.AddContactToGrid(_selectedUser);
            }
            else
            {
                // Update existing
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
            _view.Name = contact.cName;
            _view.Address = contact.cAddress;
            _view.CID = contact.cID.ToString();
            _view.ContactType = contact.cType;
        }

        private void updateContactWithViewValues(Contact contact)
        {
            contact.cName = _view.Name;
            contact.cAddress = _view.Address;
            contact.cID = Convert.ToInt32(_view.CID);
            contact.cType = _view.ContactType;
        }

        public void LoadContactView()
        {
            _view.ClearGrid();
            if (myContactlist.Count > 0)
            {

                foreach (Contact usr in myContactlist)
                    _view.AddContactToGrid(usr);

                _view.SetSelectedContactInGrid((Contact)myContactlist[0]);
            }


        }
    }
}
