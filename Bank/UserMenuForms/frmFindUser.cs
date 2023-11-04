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
    public partial class frmFindUser : Form
    {
        public frmFindUser()
        {
            InitializeComponent();
        }

      

        private bool IsUserNameCorrect()
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Please enter User Name.",
                    "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUserName.Focus();
                dgvShowUserInfo.DataSource = new DataTable();

                return false;
            }


            if (!clsUser.IsUserExists(txtUserName.Text))
            {
                MessageBox.Show("User Name is not found, Choose another one.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtUserName.Focus();
                dgvShowUserInfo.DataSource = new DataTable();

                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (!IsUserNameCorrect())
            {
                return;
            }

            else
            {

                clsUser user = clsUser.Find(txtUserName.Text);

                DataTable dt = new DataTable();

                //Add Columns to DataTable
                dt.Columns.Add("UserID", typeof(int));
                dt.Columns.Add("UserName", typeof(string));
                dt.Columns.Add("FullName", typeof(string));
                dt.Columns.Add("Phone", typeof(string));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("Password", typeof(string));
                dt.Columns.Add("Permissions", typeof(int));

                //Add Rows to the DataTable
                dt.Rows.Add(user.UserID, user.UserName,
                    user.FirstName + " " + user.LastName, user.Phone,
                    user.Email, user.Password, user.Permissions);

                dgvShowUserInfo.DataSource = dt;

                dgvShowUserInfo.Columns["Permissions"].ContextMenuStrip = contextMenuStrip1;
            }

        }

        private void showPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ShowPermissionsDetails = new frmShowPermissionsDetails((int)dgvShowUserInfo.CurrentRow.Cells["Permissions"].Value);

            ShowPermissionsDetails.ShowDialog();

        }
    }
}
