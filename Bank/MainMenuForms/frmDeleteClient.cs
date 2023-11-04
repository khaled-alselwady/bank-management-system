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
    public partial class frmDeleteClient : Form
    {
        public frmDeleteClient()
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


        private void btnShowInfo_Click(object sender, EventArgs e)
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!IsAccountNumberCorrect())
            {
                return;
            }

            else
            {


                if (MessageBox.Show("Are you sure you want to delete this client?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    if (clsClient.DeleteClient(txtAccountNumber.Text))
                    {
                        MessageBox.Show("Client Deleted Successfully.",
                            "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtAccountNumber.Clear();
                        dgvShowClientInfo.DataSource = new DataTable();
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
}
