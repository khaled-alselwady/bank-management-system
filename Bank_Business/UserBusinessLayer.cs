using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using BankDataAccessLayer;
using PersonBusinessLayer;

namespace BankBusinessLayer
{
    public class clsUser
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        public enum enPermissions
        {
            All = -1,
            ShowClientsList = 1,
            AddNewClient = 2,
            DeleteClient = 4,
            UpdateClient = 8,
            FindClient = 16,
            Transactions = 32,
            ManageUsers = 64,
            LoginRegisters = 128
        }

        public struct stRegisterLogins
        {
            public int RegisterLoginID { get; set; }
            public DateTime RegisterLoginsDateTime { get; set; }
        }

        stRegisterLogins RegisterLogins = new stRegisterLogins();

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permissions { get; set; }
        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        clsPerson _Person;

        public clsUser()
        {
            this.UserID = -1;
            this.UserName = string.Empty;
            this.Password = string.Empty;
            this.Permissions = 0;
            this.PersonID = -1;

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

        private clsUser(int UserID, string UserName, string Password,
            int Permissions, int PersonID)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.Permissions = Permissions;

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

        private bool _AddNewUser()
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

            this.UserID = clsUserDataAccessLayer.AddNewUser(this.UserName, this.Password,
                this.Permissions, this.PersonID);

            return (this.UserID != -1);
        }
        private bool _UpdateUser()
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

            return clsUserDataAccessLayer.UpdateUser(this.UserID, this.UserName,
                this.Password, this.Permissions, this.PersonID);
        }

        private bool _AddNewRegisterLogin()
        {
            RegisterLogins.RegisterLoginsDateTime = DateTime.Now;

            this.RegisterLogins.RegisterLoginID = clsUserDataAccessLayer.AddNewRegisterLogin(this.RegisterLogins.RegisterLoginsDateTime, this.UserID);

            return (this.RegisterLogins.RegisterLoginID != -1);

        }

        public static clsUser Find(int UserID)
        {
            string UserName = "", Password = "";
            int Permissions = 0, PersonID = -1;

            if (clsUserDataAccessLayer.GetUserInfoByID(UserID, ref UserName, ref Password,
                ref Permissions, ref PersonID))
            {
                return new clsUser(UserID, UserName, Password, Permissions, PersonID);
            }
            else
            {
                return null;
            }
        }
        public static clsUser Find(string UserName)
        {
            string Password = "";
            int UserID = -1, Permissions = 0, PersonID = -1;

            if (clsUserDataAccessLayer.GetUserInfoByUserName(UserName, ref UserID,
                ref Password, ref Permissions, ref PersonID))
            {
                return new clsUser(UserID, UserName, Password, Permissions, PersonID);
            }
            else
            {
                return null;
            }
        }
        public static clsUser Find(string UserName, string Password)
        {
            int UserID = -1, Permissions = 0, PersonID = -1;

            if (clsUserDataAccessLayer.GetUserInfoByUserNameAndPassword(UserName, Password,
                ref UserID, ref Permissions, ref PersonID))
            {
                return new clsUser(UserID, UserName, Password, Permissions, PersonID);
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
                    if (_AddNewUser())
                        return true;
                    else
                        return false;


                case enMode.Update:
                    return _UpdateUser();

            }

            return false;
        }

        public static bool DeleteUser(int UserID)
        {
            return clsUserDataAccessLayer.DeleteUser(UserID);
        }

        public static bool DeleteUser(string UserName)
        {
            return clsUserDataAccessLayer.DeleteUser(UserName);
        }

        public static bool IsUserExists(int UserID)
        {
            return clsUserDataAccessLayer.IsUserExists(UserID);
        }

        public static bool IsUserExists(string UserName)
        {
            return clsUserDataAccessLayer.IsUserExists(UserName);
        }

        public static DataTable GetAllUsers()
        {
            return clsUserDataAccessLayer.GetAllUsers();
        }

        public bool SaveRegisterLogins()
        {
            if (_AddNewRegisterLogin())
            {
                return true;
            }

            else
            {
                return false;
            }

        }

        public static DataTable GetAllRegisterLogins()
        {
            return clsUserDataAccessLayer.GetAllRegisterLogins();
        }
    }
}
