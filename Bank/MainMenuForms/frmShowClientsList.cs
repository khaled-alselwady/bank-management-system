using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankBusinessLayer;
using FontAwesome.Sharp;
using static MainMenuForm.frmMainMenu;

namespace MainMenuForm.MainMenuForms
{
    public partial class frmShowClientsList : Form
    {
       
        frmMainMenu main = Application.OpenForms.OfType<frmMainMenu>().FirstOrDefault();

        public frmShowClientsList()
        {
            InitializeComponent();

        }

        private void _RefreshClientsList()
        {
            dgvShowClientsList.DataSource = clsClient.GetAllClients();
        }

        private void frmShowClientsList_Load(object sender, EventArgs e)
        {
            _RefreshClientsList();
        }

        
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {           
            main.btnUpdateClient_Click(main.btnUpdateClient,e, (string)dgvShowClientsList.CurrentRow.Cells["AccountNumber"].Value);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!main._CheckAccessDenied(clsUser.enPermissions.DeleteClient))
            {
                main.frmDeniedMassage.ShowDialog();
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this client?",
                   "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                   MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {

                if (clsClient.DeleteClient((string)dgvShowClientsList.CurrentRow.Cells["AccountNumber"].Value))
                {
                    MessageBox.Show("Client Deleted Successfully.",
                        "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    _RefreshClientsList();
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
