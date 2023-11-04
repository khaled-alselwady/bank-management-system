using BankBusinessLayer;
using Guna.UI2.WinForms;
using MainMenuForm.UserMenuForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainMenuForm.MainMenuForms
{
    public partial class frmLoginRegisters : Form
    {
        public frmLoginRegisters()
        {
            InitializeComponent();
           
        }

        private void _RefreshClientsList()
        {
            dgvShowLoginRegistersList.DataSource = clsUser.GetAllRegisterLogins();
            dgvShowLoginRegistersList.Columns["DateTime"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvShowLoginRegistersList.Columns["DateTime"].Width = 160;
        }

        private void frmLoginRegisters_Load(object sender, EventArgs e)
        {
            _RefreshClientsList();
            dgvShowLoginRegistersList.Columns["Permissions"].ContextMenuStrip = contextMenuStrip1;
        }

        private void showPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ShowPermissionsDetails = new frmShowPermissionsDetails((int)dgvShowLoginRegistersList.CurrentRow.Cells["Permissions"].Value);

            ShowPermissionsDetails.ShowDialog();
        }
    }
}
