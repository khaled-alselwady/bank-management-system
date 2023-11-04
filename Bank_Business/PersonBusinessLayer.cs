using System;
using System.Data;
using System.Security.Policy;
using BankDataAccessLayer;

namespace PersonBusinessLayer
{
    public class clsPerson
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode = enMode.AddNew;

        public int PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public clsPerson()
        {
            PersonID = -1;
            FirstName = string.Empty;
            LastName = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;

            _Mode = enMode.AddNew;
        }

        private clsPerson(int personID, string firstName, string lastName,
            string phone, string email)
        {
            PersonID = personID;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;

            _Mode = enMode.Update;
        }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonDataAccessLayer.AddNewPerson(this.FirstName,
                this.LastName, this.Phone, this.Email);

            return this.PersonID != -1;
        }

        private bool _UpdatePerson()
        {
            return clsPersonDataAccessLayer.UpdatePerson(this.PersonID, this.FirstName,
                this.LastName, this.Phone, this.Email);
        }

        public static clsPerson Find(int PersonID)
        {
            string FirstName = "", LastName = "", Phone = "", Email = "";

            if (clsPersonDataAccessLayer.GetPersonInfoByID(PersonID, ref FirstName,
                ref LastName, ref Phone, ref Email))
            {
                return new clsPerson(PersonID, FirstName, LastName, Phone, Email);
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

                    if (_AddNewPerson())
                        return true;
                    else
                        return false;

                case enMode.Update:

                    return _UpdatePerson();

            }

            return false;
        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonDataAccessLayer.DeletePerson(PersonID);
        }

        public static bool IsPersonExists(int PersonID)
        {
            return clsPersonDataAccessLayer.IsPersonExists(PersonID);
        }

        public static DataTable GetAllPersons()
        {
            return clsPersonDataAccessLayer.GetAllPersons();
        }

    }
}
