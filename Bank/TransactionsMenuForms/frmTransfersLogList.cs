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
    public partial class frmTransfersLogList : Form
    {
        public frmTransfersLogList()
        {
            InitializeComponent();
        }

        private void _RefreshClientsList()
        {
            dgvTransfersLogList.DataSource = clsClient.GetAllTransfersLog();

            dgvTransfersLogList.Columns["SourceAccount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTransfersLogList.Columns["SourceAccount"].Width = 76;

            dgvTransfersLogList.Columns["DestinationAccount"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTransfersLogList.Columns["DestinationAccount"].Width = 104;

            dgvTransfersLogList.Columns["ID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            dgvTransfersLogList.Columns["ID"].Width = 30;
        }

        private void frmTransfersLogList_Load(object sender, EventArgs e)
        {
            _RefreshClientsList();
        }
    }
}
