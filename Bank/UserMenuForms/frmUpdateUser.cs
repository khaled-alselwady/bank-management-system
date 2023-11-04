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
    public partial class frmUpdateUser : Form
    {
        clsUser _User;
        string _UserName;

        enum enMode { UpdateFromShowUserTable = 0, UpdateFromMainMenu = 1 }
        enMode _Mode = enMode.UpdateFromMainMenu;

        public frmUpdateUser(string UserName)
        {
            InitializeComponent();
            _UserName = UserName;

            if (_UserName != "-1")
            {
                _Mode = enMode.UpdateFromShowUserTable;
                _User = clsUser.Find(_UserName);
            }
            else
            {
                _Mode = enMode.UpdateFromMainMenu;
            }

        }



        private bool IsUserNameCorrect()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Please enter User Name.",
                    "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUserName.Focus();

                return false;
            }


            if (!clsUser.IsUserExists(txtUserName.Text))
            {
                MessageBox.Show("User Name is not found, Choose another one.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUserName.Focus();

                return false;
            }
            else
            {
                return true;
            }
        }

        private void EnableTextBoxesAndUpdateCancelButtons()
        {
            //Enable TextBoxes
            masktxtFirstName.Enabled = true;
            masktxtLastName.Enabled = true;
            txtEmail.Enabled = true;
            masktxtPhone.Enabled = true;
            txtPassword.Enabled = true;

            //Enable Check List Box
            chklistboxPermissions.Enabled = true;

            //Enable Update And Cancel Buttons
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void CheckAllItemsInCheckedListBox()
        {

            for (short i = 0; i < chklistboxPermissions.Items.Count; i++)
            {
                chklistboxPermissions.SetItemChecked(i, true);
            }

        }

        private void RemoveCheckAllItemsInCheckedListBox()
        {

            for (short i = 0; i < chklistboxPermissions.Items.Count; i++)
            {
                chklistboxPermissions.SetItemChecked(i, false);
            }

        }

        private void CheckAnItemInCheckListBoxByItsName(string ItemName)
        {

            for (int i = 1; i < chklistboxPermissions.Items.Count; i++)
            {
                if (chklistboxPermissions.GetItemText(chklistboxPermissions.Items[i]) == ItemName)
                {
                    // Set the checked state of the item
                    chklistboxPermissions.SetItemChecked(i, true); // Set to 'true' to check, 'false' to uncheck
                    return;
                }
            }

        }

        private void RepresentationOfPermissionsInCheckListBox()
        {

            if (_User.Permissions == -1)
            {
                CheckAllItemsInCheckedListBox();
                return;
            }


            if (((int)clsUser.enPermissions.ShowClientsList & _User.Permissions) == (int)clsUser.enPermissions.ShowClientsList)
            {
                CheckAnItemInCheckListBoxByItsName("Show Clients List");
            }


            if (((int)clsUser.enPermissions.AddNewClient & _User.Permissions) == (int)clsUser.enPermissions.AddNewClient)
            {
                CheckAnItemInCheckListBoxByItsName("Add New Client");
            }


            if (((int)clsUser.enPermissions.DeleteClient & _User.Permissions) == (int)clsUser.enPermissions.DeleteClient)
            {
                CheckAnItemInCheckListBoxByItsName("Delete Client");
            }


            if (((int)clsUser.enPermissions.UpdateClient & _User.Permissions) == (int)clsUser.enPermissions.UpdateClient)
            {
                CheckAnItemInCheckListBoxByItsName("Update Client");
            }


            if (((int)clsUser.enPermissions.FindClient & _User.Permissions) == (int)clsUser.enPermissions.FindClient)
            {
                CheckAnItemInCheckListBoxByItsName("Find Client");
            }


            if (((int)clsUser.enPermissions.Transactions & _User.Permissions) == (int)clsUser.enPermissions.Transactions)
            {
                CheckAnItemInCheckListBoxByItsName("Transactions");
            }


            if (((int)clsUser.enPermissions.ManageUsers & _User.Permissions) == (int)clsUser.enPermissions.ManageUsers)
            {
                CheckAnItemInCheckListBoxByItsName("Manage Users");
            }


            if (((int)clsUser.enPermissions.LoginRegisters & _User.Permissions) == (int)clsUser.enPermissions.LoginRegisters)
            {
                CheckAnItemInCheckListBoxByItsName("Login Registers");
            }


        }

        private void FillTextBoxesWithUserInfo()
        {
            masktxtFirstName.Text = _User.FirstName;
            masktxtLastName.Text = _User.LastName;
            txtEmail.Text = _User.Email;
            masktxtPhone.Text = _User.Phone;
            txtPassword.Text = _User.Password;
            RepresentationOfPermissionsInCheckListBox();
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

        private void FillUserInfoWithTextBoxes()
        {
            _User.FirstName = masktxtFirstName.Text;
            _User.LastName = masktxtLastName.Text;
            _User.Email = txtEmail.Text;
            _User.Phone = masktxtPhone.Text;
            _User.Password = txtPassword.Text;
            _User.Permissions = GetPermissions();
        }

        private void DisableTextBoxesAndUpdateCancelButtons()
        {
            //Disable TextBoxes
            masktxtFirstName.Enabled = false;
            masktxtLastName.Enabled = false;
            txtEmail.Enabled = false;
            masktxtPhone.Enabled = false;
            txtPassword.Enabled = false;


            chklistboxPermissions.Enabled = false;

            //Disable Update And Cancel Buttons
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;
        }

        private void Rest()
        {
            txtUserName.Clear();
            masktxtFirstName.Clear();
            masktxtLastName.Clear();
            txtEmail.Clear();
            masktxtPhone.Clear();
            txtPassword.Clear();
            RemoveCheckAllItemsInCheckedListBox();

            txtUserName.Enabled = true;
            btnSearch.Enabled = true;

            DisableTextBoxesAndUpdateCancelButtons();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (!IsUserNameCorrect())
            {
                return;
            }

            txtUserName.Enabled = false;
            btnSearch.Enabled = false;

            EnableTextBoxesAndUpdateCancelButtons();

            _User = clsUser.Find(txtUserName.Text);

            FillTextBoxesWithUserInfo();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
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

            else
            {

                if (MessageBox.Show("Are you sure you want to update this user?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    FillUserInfoWithTextBoxes();

                    if (_User.Save())
                    {

                        MessageBox.Show($"User Updated Successfully. UserID = {_User.UserID}",
                                "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    else
                    {
                        MessageBox.Show("Sorry, There is a problem, please try again.",
                                  "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Rest();
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

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {
            if (_Mode == enMode.UpdateFromShowUserTable)
            {
                txtUserName.Text = _UserName;
                EnableTextBoxesAndUpdateCancelButtons();
                FillTextBoxesWithUserInfo();               

                txtUserName.Enabled = false;
                btnSearch.Enabled = false;
            }
        }
    }
}
