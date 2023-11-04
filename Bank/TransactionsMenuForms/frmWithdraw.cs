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
    public partial class frmWithdraw : Form
    {
        public frmWithdraw()
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

        private void Rest()
        {
            maskWithdrawAmount.Enabled = false;
            btnWithdraw.Enabled = false;
            txtAccountNumber.Enabled = true;
            btnSearch.Enabled = true;

            txtAccountNumber.Clear();
            maskWithdrawAmount.Clear();
            txtAccountNumber.Focus();
            dgvShowClientInfo.DataSource = new DataTable();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!IsAccountNumberCorrect())
            {
                return;
            }

            else
            {

                maskWithdrawAmount.Enabled = true;
                btnWithdraw.Enabled = true;
                txtAccountNumber.Enabled = false;
                btnSearch.Enabled = false;

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

                maskWithdrawAmount.Focus();
            }

        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskWithdrawAmount.Text))
            {
                MessageBox.Show("Please enter the Withdraw amount!",
                    "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

                maskWithdrawAmount.Focus();
                return;
            }

            else
            {

                if (MessageBox.Show("Are you sure you want to Perform this transaction?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    clsClient client = clsClient.Find(txtAccountNumber.Text);

                    if (client != null && Decimal.TryParse(maskWithdrawAmount.Text, out decimal Amount))
                    {

                        if (client.Withdraw(Amount))
                        {

                            MessageBox.Show("Amount Withdraw Successfully."
                                + Environment.NewLine + $"New Balance is: {client.Balance}",
                                "Completed", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                            Rest();
                        }
                        else
                        {
                            MessageBox.Show("Cannot Withdraw, Insufficient Balance!",
                                      "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
    }
}
