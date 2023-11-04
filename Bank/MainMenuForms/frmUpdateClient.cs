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
    public partial class frmUpdateClient : Form
    {

        clsClient _Client;
        string _AccountNumber;

        enum enMode { UpdateFromShowClientTable = 0, UpdateFromMainMenu = 1 }
        enMode _Mode = enMode.UpdateFromMainMenu;

        public frmUpdateClient(string AccountNumber)
        {
            InitializeComponent();

            _AccountNumber = AccountNumber;

            if (_AccountNumber != "-1")
            {
                _Mode = enMode.UpdateFromShowClientTable;
                _Client = clsClient.Find(_AccountNumber);
            }
            else
            {
                _Mode = enMode.UpdateFromMainMenu;
            }
        }



        private bool IsAccountNumberCorrect()
        {
            if (string.IsNullOrWhiteSpace(txtAccountNumber.Text))
            {
                MessageBox.Show("Please enter Account Number.",
                    "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtAccountNumber.Focus();

                return false;
            }


            if (!clsClient.IsClientExists(txtAccountNumber.Text))
            {
                MessageBox.Show("Account Number is not found, Choose another one.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtAccountNumber.Focus();

                return false;
            }
            else
            {
                return true;
            }
        }

        private void EnableTextBoxesAndUpdateCancelButtons()
        {
            //Enable TextBoxes
            masktxtFirstName.Enabled = true;
            masktxtLastName.Enabled = true;
            txtEmail.Enabled = true;
            masktxtPhone.Enabled = true;
            txtPinCode.Enabled = true;
            maskAccountBalance.Enabled = true;

            //Enable Update And Cancel Buttons
            btnUpdate.Enabled = true;
            btnCancel.Enabled = true;

        }

        private void DisableTextBoxesAndUpdateCancelButtons()
        {
            //Enable TextBoxes
            masktxtFirstName.Enabled = false;
            masktxtLastName.Enabled = false;
            txtEmail.Enabled = false;
            masktxtPhone.Enabled = false;
            txtPinCode.Enabled = false;
            maskAccountBalance.Enabled = false;

            //Enable Update And Cancel Buttons
            btnUpdate.Enabled = false;
            btnCancel.Enabled = false;

        }

        private void FillTextBoxesWithClientInfo()
        {
            masktxtFirstName.Text = _Client.FirstName;
            masktxtLastName.Text = _Client.LastName;
            txtEmail.Text = _Client.Email;
            masktxtPhone.Text = _Client.Phone;
            txtPinCode.Text = _Client.PinCode;
            maskAccountBalance.Text = _Client.Balance.ToString();
        }

        private void FillClientInfoWithTextBoxes()
        {
            _Client.FirstName = masktxtFirstName.Text;
            _Client.LastName = masktxtLastName.Text;
            _Client.Email = txtEmail.Text;
            _Client.Phone = masktxtPhone.Text;
            _Client.PinCode = txtPinCode.Text;
            _Client.Balance = Convert.ToDecimal(maskAccountBalance.Text);
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

            txtAccountNumber.Enabled = true;
            btnSearch.Enabled = true;

            DisableTextBoxesAndUpdateCancelButtons();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (!IsAccountNumberCorrect())
            {
                return;
            }

            txtAccountNumber.Enabled = false;
            btnSearch.Enabled = false;

            EnableTextBoxesAndUpdateCancelButtons();

            _Client = clsClient.Find(txtAccountNumber.Text);

            FillTextBoxesWithClientInfo();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(masktxtFirstName.Text) ||
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

            else
            {

                if (MessageBox.Show("Are you sure you want to update this client?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {

                    FillClientInfoWithTextBoxes();

                    if (_Client.Save())
                    {

                        MessageBox.Show($"Client Updated Successfully. ClientID = {_Client.ClientID}",
                                "Confirm", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void frmUpdateClient_Load(object sender, EventArgs e)
        {

            if (_Mode == enMode.UpdateFromShowClientTable)
            {
                txtAccountNumber.Text = _AccountNumber;
                EnableTextBoxesAndUpdateCancelButtons();
                FillTextBoxesWithClientInfo();

                txtAccountNumber.Enabled = false;
                btnSearch.Enabled = false;
            }

        }
    }
}
