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
    public partial class frmShowUsersList : Form
    {

        frmMainMenu main = Application.OpenForms.OfType<frmMainMenu>().FirstOrDefault();

        public frmShowUsersList()
        {
            InitializeComponent();
        }

        private void _RefreshUsersList()
        {
            dgvShowUsersList.DataSource = clsUser.GetAllUsers();
        }

        private void frmShowUsersList_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();

            dgvShowUsersList.Columns["Permissions"].ContextMenuStrip = guna2ContextMenuStrip1;
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ShowPermissionsDetails = new frmShowPermissionsDetails((int)dgvShowUsersList.CurrentRow.Cells["Permissions"].Value);

            ShowPermissionsDetails.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            main.btnUpdateUser_Click(main.btnUpdateUser, e, (string)dgvShowUsersList.CurrentRow.Cells["UserName"].Value);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                if (clsUser.DeleteUser((string)dgvShowUsersList.CurrentRow.Cells["UserName"].Value))
                {
                    MessageBox.Show("User Deleted Successfully.",
                        "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _RefreshUsersList();
                }

                else
                {
                    MessageBox.Show("Sorry, There is a problem, please try again.",
                              "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
