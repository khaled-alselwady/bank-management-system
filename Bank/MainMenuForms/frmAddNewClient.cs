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

namespace MainMenuForm.MainMenuForms
{
    public partial class frmAddNewClient : Form
    {
        public frmAddNewClient()
        {
            InitializeComponent();
        }

        private void FillInfoClient(ref clsClient client)
        {
            client.AccountNumber = txtAccountNumber.Text;
            client.FirstName = masktxtFirstName.Text.Trim();
            client.LastName = masktxtLastName.Text.Trim();
            client.Email = txtEmail.Text;
            client.Phone = masktxtPhone.Text.Trim();
            client.PinCode = txtPinCode.Text;
            client.Balance = Convert.ToDecimal(maskAccountBalance.Text.Trim());
        }

        private void Rest()
        {
            txtAccountNumber.Clear();
            masktxtFirstName.Clear();
            masktxtLastName.Clear();
            txtEmail.Clear();
            masktxtPhone.Clear();
            txtPinCode.Clear();
            maskAccountBalance.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtAccountNumber.Text) ||
               string.IsNullOrWhiteSpace(masktxtFirstName.Text) ||
               string.IsNullOrWhiteSpace(masktxtLastName.Text) ||
               string.IsNullOrWhiteSpace(txtEmail.Text) ||
               string.IsNullOrWhiteSpace(masktxtPhone.Text) ||
               string.IsNullOrWhiteSpace(txtPinCode.Text) ||
               string.IsNullOrWhiteSpace(maskAccountBalance.Text))
            {
                MessageBox.Show("Please fill out all fields.",
                    "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsClient.IsClientExists(txtAccountNumber.Text))
            {
                MessageBox.Show("Account Number is already used, Choose another one.",
                    "Wrong Account Number", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtAccountNumber.Focus();

                return;
            }

            clsClient client = new clsClient();

            FillInfoClient(ref client);

            if (client.Save())
            {
                MessageBox.Show($"Client Added Successfully. ClientID = {client.ClientID}",
                    "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Rest();
            }
            else
            {
                MessageBox.Show("Sorry, There is a problem, please try again.",
                    "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
