using BankManagement.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Models
{
    internal class Customer
    {
        private string _phone; // Backing field for Phone property
        public Guid UID { get; private set; } // Customer UniqueID
        public string CID { get; private set; } // Citizen ID
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string Phone // 10 Digits, Nullable
        {
            get => _phone; 
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    _phone = "";
                    return;
                }
                if (value.Length == 10 && value.All(char.IsDigit))
                    _phone = value;
                else
                    throw new FormatException("Phone number must be exactly 10 digits!");
            }
        } 
        public DateTime BirthDate { get; set; }

        public Customer()
        {
            UID = Guid.NewGuid();
            CID = LastName = FirstName = Address = Phone = string.Empty;
        }
        public Customer(string lastName, string firstName)
        {
            UID = Guid.NewGuid();
            CID = string.Empty;
            LastName = lastName;
            FirstName = firstName;
            Address = Phone = string.Empty;
        }
        public Customer(string lastName, string firstName, string cid, string address, string phone, DateTime birthDate) : this(lastName, firstName)
        {
            CID = cid;
            Address = address;
            Phone = phone;
            BirthDate = birthDate;
        }
        public Customer(Customer c) : this(c.LastName, c.FirstName, c.CID, c.Address, c.Phone, c.BirthDate)
        {
            this.UID = c.UID;
        }
        public void UpdateInfo(string lastName, string firstName)
        {
            if (lastName != null) LastName = lastName;
            if (firstName != null) FirstName = firstName;
        }
        public void UpdateInfo(string lastName, string firstName, string cid)
        {
            UpdateInfo(lastName, firstName);
            if (cid != null) CID = cid;
        }
        public void UpdateInfo(string lastName, string firstName, string cid, string address)
        {
            UpdateInfo(lastName, firstName, cid);
            if (address != null) Address = address;
        }
        public void UpdateInfo(string lastName, string firstName, string cid, string address, string phone)
        {
            UpdateInfo(lastName, firstName, cid, address);
            if (phone != null) Phone = phone;
        }
        public void UpdateInfo(string lastName, string firstName, string cid, string address, string phone, string birthDate)
        {
            UpdateInfo(lastName, firstName, cid, address, phone);
            BirthDate = birthDate.ToDateMonthYear(); // Will throw exception if invalid
        }
        public List<string> GetInfo(bool fullInfo = true)
        {
            if(fullInfo)
                return new List<string> 
                { UID.ToString(), CID, LastName, FirstName, Address, Phone, BirthDate.ToString("dd/MM/yyyy") };
            else 
                return new List<string> 
                { LastName, FirstName };
        }
    }
}
