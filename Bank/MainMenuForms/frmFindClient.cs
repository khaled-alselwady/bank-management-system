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

namespace MainMenuForm.MainMenuForms
{
    public partial class frmFindClient : Form
    {
        public frmFindClient()
        {
            InitializeComponent();
        }

        private bool IsAccountNumberCorrect()
        {
            if (string.IsNullOrWhiteSpace(txtAccountNumber.Text))
            {
                MessageBox.Show("Please enter Account Number.",
                    "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtAccountNumber.Focus();

                dgvShowClientInfo.DataSource = new DataTable();

                return false;
            }


            if (!clsClient.IsClientExists(txtAccountNumber.Text))
            {
                MessageBox.Show("Account Number is not found, Choose another one.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtAccountNumber.Focus();

                dgvShowClientInfo.DataSource = new DataTable();

                return false;
            }
            else
            {
                return true;
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (!IsAccountNumberCorrect())
            {
                return;
            }

            else
            {

                clsClient client = clsClient.Find(txtAccountNumber.Text);

                DataTable dt = new DataTable();

                //Add Columns to DataTable
                dt.Columns.Add("ClientID", typeof(int));
                dt.Columns.Add("AccountNumber", typeof(string));
                dt.Columns.Add("FullName", typeof(string));
                dt.Columns.Add("Phone", typeof(string));
                dt.Columns.Add("Email", typeof(string));
                dt.Columns.Add("PinCode", typeof(string));
                dt.Columns.Add("Balance", typeof(decimal));

                //Add Rows to the DataTable
                dt.Rows.Add(client.ClientID, client.AccountNumber,
                    client.FirstName + " " + client.LastName, client.Phone,
                    client.Email, client.PinCode, client.Balance);

                dgvShowClientInfo.DataSource = dt;
            }

        }

        private void dgvShowClientInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAccountNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
