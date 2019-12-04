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
    public partial class ContactView : Form, IContactView
    {
        ContactController contactController;
       // ContactRepositoryController contactRepoController;
        public ContactView()
        {
            InitializeComponent();
        }

        public string ContactName
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
                if (value == "Payee")
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
    
        public void AddContactToGrid(Contact contact)
        {
            ListViewItem parent;
            parent = this.contactGrdView.Items.Add(contact.cID.ToString());
            parent.SubItems.Add(contact.cName);
            parent.SubItems.Add(contact.cType);
            parent.SubItems.Add(contact.cAddress);
            ApplyStripeToContactGride();
        }

        public void ClearGrid()
        {
            // Define columns and clear item
            this.contactGrdView.Columns.Clear();

            this.contactGrdView.Columns.Add("Id", 150, HorizontalAlignment.Left);
            this.contactGrdView.Columns.Add("Name", 250, HorizontalAlignment.Left);
            this.contactGrdView.Columns.Add("Type", 150, HorizontalAlignment.Left);
            this.contactGrdView.Columns.Add("Address", 450, HorizontalAlignment.Left);
            this.contactGrdView.Items.Clear();
        }

        public void UpdateGridWithChangedContact(Contact contact)
        {
            ListViewItem rowToUpdate = null;

            foreach (ListViewItem row in this.contactGrdView.Items)
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
            if (this.contactGrdView.SelectedItems.Count > 0)
                return this.contactGrdView.SelectedItems[0].Text;
            else
                return "";
        }

        public void RemoveContactFromGrid(Contact contact)
        {

            ListViewItem rowToRemove = null;

            foreach (ListViewItem row in this.contactGrdView.Items)
            {
                if (row.Text == contact.cID.ToString())
                {
                    rowToRemove = row;
                }
            }

            if (rowToRemove != null)
            {
                this.contactGrdView.Items.Remove(rowToRemove);
                ApplyStripeToContactGride();
                this.contactGrdView.Focus();
            }
        }


        public void SetSelectedContactInGrid(Contact contact)
        {
            foreach (ListViewItem row in this.contactGrdView.Items)
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
            this.DeleteCbtn.Enabled = false;
            //this.cancelCbBtn.Visible = true;
            this.updateCBtn.Text = "Register Contact";
            this.contactGbox.Text = "Add Contact";
            this.contactGrdView.BackColor = System.Drawing.ColorTranslator.FromHtml("#626262");
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
            //ClearGrid();
           // this.contactListView.BackColor = System.Drawing.Color.Empty; //setto inactive
        }

  

        public void SetContactController(ContactController controller)
        {
            contactController = controller;
        }
        public void ApplyStripeToContactGride()
        {
            int i = 0;
            contactGrdView.BackColor = Color.FromArgb(255, 255, 255);
            foreach (ListViewItem row in this.contactGrdView.Items)
            {
                if (i == 1)
                {
                    row.BackColor = Color.FromArgb(230, 230, 255);
                    i = 0;

                }
                else
                {
                    row.BackColor = Color.FromArgb(255, 255, 255);
                    i = 1;
                }
            }
        }

        private void contactListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(this.contactGrdView.SelectedItems.Count > 0)
                this.contactController.SelectedContactChanged(this.contactGrdView.SelectedItems[0].Text);
        }

        private void contactGrdView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.contactGrdView.SelectedItems.Count > 0)
                this.contactController.SelectedContactChanged(this.contactGrdView.SelectedItems[0].Text);
        }

        private void contactGrdView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (this.contactGrdView.SelectedItems.Count > 0)
                this.contactController.SelectedContactChanged(this.contactGrdView.SelectedItems[0].Text);
        }
    }
}
