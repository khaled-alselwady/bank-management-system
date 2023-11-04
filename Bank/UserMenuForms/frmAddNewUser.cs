using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenuForm.UserMenuForms
{
    public partial class frmAddNewUser : Form
    {
        public frmAddNewUser()
        {
            InitializeComponent();
        }

        private int GetPermissions()
        {

            int Permissions = 0;

            List<string> CheckedItemsNames = chklistboxPermissions.CheckedItems
                .Cast<object>().Select(item => item.ToString()).ToList();

            if (CheckedItemsNames.IndexOf("All") == 0)
                return -1;

            foreach (string item in CheckedItemsNames)
            {


                switch (item)
                {

                    case "Show Clients List":
                        Permissions += (int)clsUser.enPermissions.ShowClientsList;
                        break;

                    case "Add New Client":
                        Permissions += (int)clsUser.enPermissions.AddNewClient;
                        break;

                    case "Delete Client":
                        Permissions += (int)clsUser.enPermissions.DeleteClient;
                        break;

                    case "Update Client":
                        Permissions += (int)clsUser.enPermissions.UpdateClient;
                        break;

                    case "Find Client":
                        Permissions += (int)clsUser.enPermissions.FindClient;
                        break;

                    case "Transactions":
                        Permissions += (int)clsUser.enPermissions.Transactions;
                        break;

                    case "Manage Users":
                        Permissions += (int)clsUser.enPermissions.ManageUsers;
                        break;

                    case "Login Registers":
                        Permissions += (int)clsUser.enPermissions.LoginRegisters;
                        break;

                }

            }

            return Permissions;
        }

        private void NewUserInfo(ref clsUser user)
        {
            user.UserName = txtUserName.Text;
            user.FirstName = masktxtFirstName.Text;
            user.LastName = masktxtLastName.Text;
            user.Email = txtEmail.Text;
            user.Phone = masktxtPhone.Text;
            user.Password = txtPassword.Text;
            user.Permissions = GetPermissions();
        }

        private void RemoveCheckFromCheckedItemsInCheckedListBox()
        {

            for (short i = 0; i < chklistboxPermissions.Items.Count; i++)
            {
                chklistboxPermissions.SetItemChecked(i, false);
            }

        }

        private void Rest()
        {
            txtUserName.Clear();
            masktxtFirstName.Clear();
            masktxtLastName.Clear();
            txtEmail.Clear();
            masktxtPhone.Clear();
            txtPassword.Clear();
            RemoveCheckFromCheckedItemsInCheckedListBox();
            chklistboxPermissions.ClearSelected();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            bool IsItemChecked = chklistboxPermissions.CheckedItems.Cast<object>().Any();

            if (string.IsNullOrWhiteSpace(txtUserName.Text) ||
               string.IsNullOrWhiteSpace(masktxtFirstName.Text) ||
               string.IsNullOrWhiteSpace(masktxtLastName.Text) ||
               string.IsNullOrWhiteSpace(txtEmail.Text) ||
               string.IsNullOrWhiteSpace(masktxtPhone.Text) ||
               string.IsNullOrWhiteSpace(txtPassword.Text) ||
               !IsItemChecked)
            {
                MessageBox.Show("Please fill out all fields.",
                    "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsUser.IsUserExists(txtUserName.Text))
            {
                MessageBox.Show("User Name is already used, choose another one.",
                    "Used User Name", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUserName.Focus();

                return;
            }

            clsUser user = new clsUser();

            NewUserInfo(ref user);

            if (user.Save())
            {
                MessageBox.Show($"User Added Successfully. UserID = {user.UserID}",
                    "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Rest();
            }
            else
            {
                MessageBox.Show("Sorry, There is a problem, please try again.",
                    "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void chklistboxPermissions_ItemCheck(object sender, ItemCheckEventArgs e)
        {

            chklistboxPermissions.ItemCheck -= chklistboxPermissions_ItemCheck; // Unsubscribe from the event temporarily

            if (e.Index == 0) // "all" item
            {
                bool isChecked = (e.NewValue == CheckState.Checked);
                for (int i = 1; i < chklistboxPermissions.Items.Count; i++)
                {
                    chklistboxPermissions.SetItemChecked(i, isChecked);
                }
            }
            else
            {

                if (chklistboxPermissions.GetItemChecked(0))
                {
                    bool areAllChecked = true;
                    for (int i = 1; i < chklistboxPermissions.Items.Count; i++)
                    {
                        if (chklistboxPermissions.GetItemChecked(i))
                        {
                            areAllChecked = false;
                            break;
                        }
                    }
                    chklistboxPermissions.SetItemChecked(0, areAllChecked);
                }

                
            }

            chklistboxPermissions.ItemCheck += chklistboxPermissions_ItemCheck; // Re-subscribe to the event


        }


    }
}
