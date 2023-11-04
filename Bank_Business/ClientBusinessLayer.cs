using System;
using System.Data;
using System.Security.Cryptography.X509Certificates;
using BankDataAccessLayer;
using PersonBusinessLayer;

namespace BankBusinessLayer
{
    public class clsClient
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;
        clsPerson _Person;

        struct stTransferLog
        {
            public int TransferLogID { get; set; }
            public DateTime Date { get; set; }
            public string SourceAccount { get; set; }
            public string DestinationAccount { get; set; }
            public decimal Amount { get; set; }
            public decimal SourceBalance { get; set; }
            public decimal DestinationBalance { get; set; }
            public string User { get; set; }
        }
        

        public int ClientID { get; set; }
        public string AccountNumber { get; set; }
        public string PinCode { get; set; }
        public decimal Balance { get; set; }
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public clsClient()
        {
            this.ClientID = -1;
            this.AccountNumber = string.Empty;
            this.PinCode = string.Empty;
            this.Balance = 0;

            _Person = new clsPerson();
            if (_Person != null)
            {
                this.FirstName = string.Empty;
                this.LastName = string.Empty;
                this.Phone = string.Empty;
                this.Email = string.Empty;
            }

            _Mode = enMode.AddNew;
        }

        private clsClient(int ClientID, string accountNumber, string pinCode,
            decimal balance, int PersonID)
        {
            this.ClientID = ClientID;
            this.AccountNumber = accountNumber;
            this.PinCode = pinCode;
            this.Balance = balance;

            this._Person = clsPerson.Find(PersonID);
            if (_Person != null)
            {
                this.FirstName = _Person.FirstName;
                this.LastName = _Person.LastName;
                this.Phone = _Person.Phone;
                this.Email = _Person.Email;
                this.PersonID = _Person.PersonID;
            }

            _Mode = enMode.Update;
        }

        private bool _AddNewClient()
        {

            if (!clsPerson.IsPersonExists(PersonID))
            {

                if (string.IsNullOrWhiteSpace(this.FirstName) ||
                    string.IsNullOrWhiteSpace(this.LastName) ||
                    string.IsNullOrWhiteSpace(this.Phone))
                {
                    return false;
                }


                this._Person.PersonID = this.PersonID;
                this._Person.FirstName = this.FirstName;
                this._Person.LastName = this.LastName;
                this._Person.Phone = this.Phone;
                this._Person.Email = this.Email;
                this._Person.Save();
                this.PersonID = this._Person.PersonID;
            }


            this.ClientID = clsClientDataAccessLayer.AddNewClient(this.AccountNumber,
                this.PinCode, this.Balance, this.PersonID);

            return (this.ClientID != -1);
        }

        private bool _UpdateClient()
        {
            if (!clsPerson.IsPersonExists(PersonID))
            {
                return false;
            }

            this._Person.PersonID = this.PersonID;
            this._Person.FirstName = this.FirstName;
            this._Person.LastName = this.LastName;
            this._Person.Phone = this.Phone;
            this._Person.Email = this.Email;
            this._Person.Save();
            this.PersonID = this._Person.PersonID;

            return clsClientDataAccessLayer.UpdateClient(this.ClientID, this.AccountNumber,
                this.PinCode, this.Balance, this.PersonID);

        }

        public static clsClient Find(int ClientID)
        {
            string AccountNumber = "", PinCode = "";
            decimal Balance = 0;
            int PersonID = -1;

            if (clsClientDataAccessLayer.GetClientInfoByID(ClientID,
                ref AccountNumber, ref PinCode, ref Balance, ref PersonID))
            {
                return new clsClient(ClientID, AccountNumber, PinCode, Balance, PersonID);
            }
            else
            {
                return null;
            }
        }

        public static clsClient Find(string AccountNumber)
        {
            string PinCode = "";
            decimal Balance = 0;
            int ClientID = -1, PersonID = -1;

            if (clsClientDataAccessLayer.GetClientInfoByAccountNumber(AccountNumber,
                ref ClientID, ref PinCode, ref Balance, ref PersonID))
            {
                return new clsClient(ClientID, AccountNumber, PinCode, Balance, PersonID);
            }
            else
            {
                return null;
            }
        }

        public bool Save()
        {

            switch (_Mode)
            {
                case enMode.AddNew:

                    if (_AddNewClient())
                        return true;
                    else
                        return false;

                case enMode.Update:
                    return _UpdateClient();
            }

            return false;
        }

        public static bool DeleteClient(int ClientID)
        {
            return clsClientDataAccessLayer.DeleteClient(ClientID);
        }

        public static bool DeleteClient(string AccountNumber)
        {
            return clsClientDataAccessLayer.DeleteClient(AccountNumber);
        }

        public static bool IsClientExists(int ClientID)
        {
            return clsClientDataAccessLayer.IsClientExists(ClientID);
        }

        public static bool IsClientExists(string AccountNumber)
        {
            return clsClientDataAccessLayer.IsClientExists(AccountNumber);
        }

        public static DataTable GetAllClients()
        {
            return clsClientDataAccessLayer.GetAllClients();
        }

        public void Deposit(decimal Amount)
        {
            this.Balance += Amount;
            Save();
        }

        public bool Withdraw(decimal Amount)
        {

            if (Amount > this.Balance)
            {
                return false;
            }
            else
            {
                this.Balance -= Amount;
                return Save();
            }

        }

        public bool Transfer(ref clsClient DestinationClient, decimal Amount, string UserName)
        {

            if (Amount > this.Balance)
            {
                return false;
            }

            Withdraw(Amount);
            DestinationClient.Deposit(Amount);

            _TransferLog(DestinationClient, Amount, UserName);

            return true;
        }

        public static decimal GetTotalBalances()
        {
            return clsClientDataAccessLayer.GetTotalBalances();
        }

        public static DataTable GetInfoTotalBalances()
        {
            return clsClientDataAccessLayer.GetInfoTotalBalances();
        }

        private void _TransferLog(clsClient DestinationClient, decimal Amount, string User)
        {
            stTransferLog TransferLog = new stTransferLog();
            
            TransferLog.Date = DateTime.Now;
            TransferLog.SourceAccount = AccountNumber;
            TransferLog.DestinationAccount = DestinationClient.AccountNumber;
            TransferLog.Amount = Amount;
            TransferLog.SourceBalance = Balance;
            TransferLog.DestinationBalance = DestinationClient.Balance;
            TransferLog.User = User;

            TransferLog.TransferLogID = clsClientDataAccessLayer.AddTransferLog(TransferLog.Date,
                                        TransferLog.SourceAccount, TransferLog.DestinationAccount,
                                        TransferLog.Amount, TransferLog.SourceBalance,
                                        TransferLog.DestinationBalance, TransferLog.User);
        }

        public static DataTable GetAllTransfersLog()
        {
            return clsClientDataAccessLayer.GetAllTransfersLog();
        }

    }


}
