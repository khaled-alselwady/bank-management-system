using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenuForm.UserMenuForms
{
    public partial class frmShowPermissionsDetails : Form
    {

        private int _Permissions = 0;

        public frmShowPermissionsDetails(int Permissions)
        {
            InitializeComponent();

            _Permissions = Permissions;

            RepresentationOfPermissionsInCheckListBox();
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

        private void CheckAllItemsInCheckedListBox()
        {

            for (short i = 0; i < chklistboxPermissions.Items.Count; i++)
            {
                chklistboxPermissions.SetItemChecked(i, true);
            }

        }

        private void RepresentationOfPermissionsInCheckListBox()
        {

            if (_Permissions == -1)
            {
                CheckAllItemsInCheckedListBox();
                return;
            }


            if (((int)clsUser.enPermissions.ShowClientsList & _Permissions) == (int)clsUser.enPermissions.ShowClientsList)
            {
                CheckAnItemInCheckListBoxByItsName("Show Clients List");
            }


            if (((int)clsUser.enPermissions.AddNewClient & _Permissions) == (int)clsUser.enPermissions.AddNewClient)
            {
                CheckAnItemInCheckListBoxByItsName("Add New Client");
            }


            if (((int)clsUser.enPermissions.DeleteClient & _Permissions) == (int)clsUser.enPermissions.DeleteClient)
            {
                CheckAnItemInCheckListBoxByItsName("Delete Client");
            }


            if (((int)clsUser.enPermissions.UpdateClient & _Permissions) == (int)clsUser.enPermissions.UpdateClient)
            {
                CheckAnItemInCheckListBoxByItsName("Update Client");
            }


            if (((int)clsUser.enPermissions.FindClient & _Permissions) == (int)clsUser.enPermissions.FindClient)
            {
                CheckAnItemInCheckListBoxByItsName("Find Client");
            }


            if (((int)clsUser.enPermissions.Transactions & _Permissions) == (int)clsUser.enPermissions.Transactions)
            {
                CheckAnItemInCheckListBoxByItsName("Transactions");
            }


            if (((int)clsUser.enPermissions.ManageUsers & _Permissions) == (int)clsUser.enPermissions.ManageUsers)
            {
                CheckAnItemInCheckListBoxByItsName("Manage Users");
            }


            if (((int)clsUser.enPermissions.LoginRegisters & _Permissions) == (int)clsUser.enPermissions.LoginRegisters)
            {
                CheckAnItemInCheckListBoxByItsName("Login Registers");
            }

        }


        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
