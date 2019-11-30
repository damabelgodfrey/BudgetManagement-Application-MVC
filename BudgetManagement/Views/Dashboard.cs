using BudgetManagement.Controllers;
using BudgetManagement.Models;
using BudgetManagement.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetManagement.Views
{
    public partial class Dashboard : Form, IDashboardView
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public string Name
        {
            get { return this.nameCtxt.Text; }
            set { this.nameCtxt.Text = value; }
        }

        public string ContactType
        {
            get
            {
                if (this.payeeRBtn.Checked)
                    return this.payeeRBtn.Text;
                else
                    return this.payerRBtn.Text;
            }
            set
            {
                if (value == "payee")
                    this.payeeRBtn.Checked = true;
                else
                    this.payerRBtn.Checked = true;
            }

        }

        public string Address
        {
            get { return this.addressCtxt.Text; }
            set { this.addressCtxt.Text = value; }
        }
        public string CID
        {
            get { return this.idCTxt.Text; }
            set { this.idCTxt.Text = value; }
        }
        public bool CanModifyID
        {
            set { this.idCTxt.Enabled = value; }
        }
        ContactController contactController;
        ContactRepositoryController contactRepoController;
        public void AddContactToGrid(Contact contact)
        {
            ListViewItem parent;
            parent = this.contactListView.Items.Add(contact.cID.ToString());
            parent.SubItems.Add(contact.cName);
            parent.SubItems.Add(contact.cType);
            parent.SubItems.Add(contact.cAddress);
        }

        public void ClearGrid()
        {
            // Define columns in grid
            this.contactListView.Columns.Clear();

            this.contactListView.Columns.Add("Id", 150, HorizontalAlignment.Left);
            this.contactListView.Columns.Add("Name", 150, HorizontalAlignment.Left);
            this.contactListView.Columns.Add("Type", 150, HorizontalAlignment.Left);
            this.contactListView.Columns.Add("Address", 250, HorizontalAlignment.Left);

            // Add rows to grid
            this.contactListView.Items.Clear();
        }

        public void UpdateGridWithChangedContact(Contact contact)
        {
            ListViewItem rowToUpdate = null;

            foreach (ListViewItem row in this.contactListView.Items)
            {
                if (row.Text == contact.cID.ToString())
                {
                    rowToUpdate = row;
                }
            }

            if (rowToUpdate != null)
            {
                rowToUpdate.Text = contact.cID.ToString();
                rowToUpdate.SubItems[1].Text = contact.cName;
                rowToUpdate.SubItems[2].Text = contact.cType;
                rowToUpdate.SubItems[3].Text = contact.cAddress;
            }
        }
        public string GetIdOfSelectedContactInGrid()
        {
            if (this.contactListView.SelectedItems.Count > 0)
                return this.contactListView.SelectedItems[0].Text;
            else
                return "";
        }

        public void RemoveContactFromGrid(Contact contact)
        {

            ListViewItem rowToRemove = null;

            foreach (ListViewItem row in this.contactListView.Items)
            {
                if (row.Text == contact.cID.ToString())
                {
                    rowToRemove = row;
                }
            }

            if (rowToRemove != null)
            {
                this.contactListView.Items.Remove(rowToRemove);
                this.contactListView.Focus();
            }
        }


        public void SetSelectedContactInGrid(Contact contact)
        {
            foreach (ListViewItem row in this.contactListView.Items)
            {
                if (row.Text == contact.cID.ToString())
                {
                    row.Selected = true;
                }
            }
        }


        private void addCBtn_Click(object sender, EventArgs e)
        {
            this.addCBtn.Enabled = false;
            this.contactListView.Enabled = false;
            this.contactListView.Visible = true;
            this.contactListView.Text = "Register Contact";
            this.contactListView.Text = "Add Contact";
            this.contactListView.BackColor = System.Drawing.ColorTranslator.FromHtml("#626262");
            this.contactController.AddNewContact();
        }
        
        // delete contact
        private void DeleteCbtn_Click(object sender, EventArgs e)
        {
            this.contactController.RemoveContact();

        }

        private void updateCBtn_Click(object sender, EventArgs e)
        {
            this.contactController.SaveContact();
            this.updateCBtn.Text = "Update Contact";
            this.addCBtn.Enabled = true;
            this.DeleteCbtn.Enabled = true;
            this.DeleteCbtn.Visible = false;
            this.contactListView.BackColor = System.Drawing.Color.Empty;
        }

        private void contactListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.contactListView.SelectedItems.Count > 0)
                this.contactController.SelectedContactChanged(this.contactListView.SelectedItems[0].Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard view = new Dashboard
            {
                //TransactionView Tview = new TransactionView();
                //Tview.ShowDialog();
                Visible = false
            };
            List<Contact> mycontact =ContactRepositoryController.ContactList;

            ContactController controller = new ContactController(view, mycontact);
            controller.LoadContactView();
            view.ShowDialog();
        }

        public void SetContactController(ContactController controller)
        {
            contactController = controller;
        }
    }
}
