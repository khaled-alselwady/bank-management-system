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

namespace MainMenuForm.TransactionsMenuForms
{
    public partial class frmTotalBalance : Form
    {
        public frmTotalBalance()
        {
            InitializeComponent();
        }

        private void _RefreshClientsListAndTotalBalances()
        {
            dgvShowInfoTotalBalances.DataSource = clsClient.GetInfoTotalBalances();
            lblTotalBalances.Text = clsClient.GetTotalBalances().ToString() + " $";
        }

        private void frmTotalBalance_Load(object sender, EventArgs e)
        {
            _RefreshClientsListAndTotalBalances();
        }
    }
}
