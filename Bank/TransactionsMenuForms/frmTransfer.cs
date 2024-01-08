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
    public partial class frmTransfer : Form
    {

        clsClient ClientFrom;
        clsClient ClientTo;
        string _UserName;
        public frmTransfer(string Username)
        {
            InitializeComponent();

            _UserName = Username;
        }

        private bool IsAccountNumberFromCorrect()
        {
            if (string.IsNullOrWhiteSpace(txtAccountNumberFrom.Text))
            {
                MessageBox.Show("Please enter Account Number.",
                    "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtAccountNumberFrom.Focus();

                dgvShowClientInfoFrom.DataSource = new DataTable();

                return false;
            }


            if (!clsClient.IsClientExists(txtAccountNumberFrom.Text))
            {
                MessageBox.Show("Account Number is not found, Choose another one.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtAccountNumberFrom.Focus();

                dgvShowClientInfoFrom.DataSource = new DataTable();

                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsAccountNumberToCorrect()
        {
            if (string.IsNullOrWhiteSpace(txtAccountNumberTo.Text))
            {
                MessageBox.Show("Please enter Account Number.",
                    "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtAccountNumberTo.Focus();

                dgvShowClientInfoTo.DataSource = new DataTable();

                return false;
            }


            if (!clsClient.IsClientExists(txtAccountNumberTo.Text))
            {
                MessageBox.Show("Account Number is not found, Choose another one.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtAccountNumberTo.Focus();

                dgvShowClientInfoTo.DataSource = new DataTable();

                return false;
            }
            else
            {
                return true;
            }
        }

        private void Rest()
        {
            txtTransferAmount.Enabled = false;
            btnTransfer.Enabled = false;
            txtAccountNumberFrom.Enabled = true;
            txtAccountNumberTo.Enabled = false;
            btnSearchFrom.Enabled = true;
            btnSearchTo.Enabled = false;

            txtAccountNumberFrom.Clear();
            txtAccountNumberTo.Clear();
            txtTransferAmount.Clear();
            txtAccountNumberFrom.Focus();
            dgvShowClientInfoFrom.DataSource = new DataTable();
            dgvShowClientInfoTo.DataSource = new DataTable();
        }

        private void btnSearchFrom_Click(object sender, EventArgs e)
        {

            if (!IsAccountNumberFromCorrect())
            {
                return;
            }

            else
            {

                txtAccountNumberTo.Enabled = true;
                btnSearchTo.Enabled = true;
                txtAccountNumberFrom.Enabled = false;
                btnSearchFrom.Enabled = false;

                ClientFrom = clsClient.Find(txtAccountNumberFrom.Text);

                DataTable dt = new DataTable();

                //Add Columns to DataTable
                dt.Columns.Add("FullName", typeof(string));
                dt.Columns.Add("AccountNumber", typeof(string));
                dt.Columns.Add("Balance", typeof(decimal));

                //Add Rows to the DataTable
                dt.Rows.Add(ClientFrom.FirstName + " " + ClientFrom.LastName,
                     ClientFrom.AccountNumber, ClientFrom.Balance);

                dgvShowClientInfoFrom.DataSource = dt;

                txtAccountNumberTo.Focus();
            }

        }

        private void btnSearchTo_Click(object sender, EventArgs e)
        {
            if (!IsAccountNumberToCorrect())
            {
                return;
            }

            else
            {

                txtTransferAmount.Enabled = true;
                btnTransfer.Enabled = true;
                txtAccountNumberTo.Enabled = false;
                btnSearchTo.Enabled = false;

                ClientTo = clsClient.Find(txtAccountNumberTo.Text);

                DataTable dt = new DataTable();

                //Add Columns to DataTable
                dt.Columns.Add("FullName", typeof(string));
                dt.Columns.Add("AccountNumber", typeof(string));
                dt.Columns.Add("Balance", typeof(decimal));

                //Add Rows to the DataTable
                dt.Rows.Add(ClientTo.FirstName + " " + ClientTo.LastName,
                     ClientTo.AccountNumber, ClientTo.Balance);

                dgvShowClientInfoTo.DataSource = dt;

                txtTransferAmount.Focus();
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTransferAmount.Text))
            {
                MessageBox.Show("Please enter the transfer amount!",
                    "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtTransferAmount.Focus();
                return;
            }


            else
            {

                if (MessageBox.Show("Are you sure you want to Perform this operation?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    if (Convert.ToDecimal(txtTransferAmount.Text) > ClientFrom.Balance)
                    {
                        MessageBox.Show("Amount exceeds the available Balance, Enter another amount.",
                            "Amount Exceeds", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtTransferAmount.Focus();

                        return;
                    }

                    if (ClientFrom.Transfer(ClientTo, Convert.ToDecimal(txtTransferAmount.Text), _UserName))
                    {

                        MessageBox.Show("Transfer Done Successfully.", "Completed",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);



                        Rest();
                    }

                    else
                    {
                        MessageBox.Show("Sorry, There is a problem, please try again.",
                                       "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        txtTransferAmount.Focus();
                    }


                }


            }




        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Rest();
        }

        private void maskTransferAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char inputChar = e.KeyChar;

            // Allow digits, the decimal point, and the backspace.
            bool isDigit = Char.IsDigit(inputChar);
            bool isDecimalPoint = (inputChar == '.');
            bool isBackspace = (inputChar == '\b');

            // If the input character is not a digit, decimal point, or backspace, suppress it.
            if (!isDigit && !isDecimalPoint && !isBackspace)
            {
                e.Handled = true;
            }

            // Make sure there is only one decimal point in the input.
            if (isDecimalPoint && ((sender as TextBox).Text.Contains(".") || (sender as TextBox).Text.Length == 0))
            {
                e.Handled = true;
            }
        }
    }
}
