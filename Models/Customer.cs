using BankManagement.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Models
{
    public enum Gender
    {
        None = 0,
        Male = 1,
        Female = 2, 
        Other = 3
    }
    public class Customer
    {
        private string _phone = ""; // Backing field for Phone property
        private string _email = ""; // Backing field for Email property
        public Guid UID { get; private set; } // Customer UniqueID
        public string CID { get; private set; } // Citizen ID
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Address { get; set; }
        public string Email // Optional, Nullable, Follow Email format
        { 
            get => _email; 
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    _email = "";
                    return;
                }
                //string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Basic email pattern
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"; // More strict email pattern
                if (System.Text.RegularExpressions.Regex.IsMatch(value, pattern))
                    _email = value;
                else
                    throw new FormatException("Email format is invalid!");
                // Alternative method using MailAddress class
                /*try
                {
                    var addr = new System.Net.Mail.MailAddress(value);
                    _email = addr.Address;
                }
                catch
                {
                    throw new FormatException("Email format is invalid!");
                }*/
            }
        } 
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
        public Gender Gender { get; set; }
        public Customer()
        {
            UID = Guid.NewGuid();
            CID = LastName = FirstName = Address = Email = Phone = string.Empty;
            Gender = Gender.None;
        }
        public Customer(string lastName, string firstName, Gender gender = Gender.None)
        {
            UID = Guid.NewGuid();
            CID = string.Empty;
            LastName = lastName;
            FirstName = firstName;
            Address = Email = Phone = string.Empty;
            Gender = gender;
        }
        public Customer(string lastName, string firstName, string cid, string address, string email, string phone, DateTime birthDate, Gender gender = Gender.None)
            : this(lastName, firstName, gender)
        {
            CID = cid;
            Address = address;
            Email = email;
            Phone = phone;
            BirthDate = birthDate;
        }
        public Customer(Customer c)
            : this(c.LastName, c.FirstName, c.CID, c.Address, c.Email, c.Phone, c.BirthDate, c.Gender)
        {
            this.UID = c.UID;
        }
        public Customer(string dataLine)
        {
            var line = dataLine.Split(",");
            UID = Guid.Parse(line[0]);
            CID = line[1];
            LastName = line[2];
            FirstName = line[3];
            Address = line[4];
            Email = line[5];
            Phone = line[6];
            BirthDate = line[7].ToDateMonthYear();
            // This line is not required, may have or not, if not have Gender.None is default
            Gender = line.Length > 8 ? Enum.TryParse(line[8], out Gender g) ? g : Gender.None : Gender.None;
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
        public void UpdateInfo(string lastName, string firstName, string cid, string address, string email)
        {
            UpdateInfo(lastName, firstName, cid, address);
            if (email != null) Email = email;
        }
        public void UpdateInfo(string lastName, string firstName, string cid, string address, string email, string phone)
        {
            UpdateInfo(lastName, firstName, cid, address, email);
            if (phone != null) Phone = phone;
        }
        public void UpdateInfo(string lastName, string firstName, string cid, string address, string email, string phone, string birthDate)
        {
            UpdateInfo(lastName, firstName, cid, address, email, phone);
            BirthDate = birthDate.ToDateMonthYear(); // Will throw exception if invalid
        }
        public void UpdateInfo(string lastName, string firstName, string cid, string address, string email, string phone, string birthDate, Gender gender)
        {
            UpdateInfo(lastName, firstName, cid, address, email, phone, birthDate);
            Gender = gender;
        }
        public List<string> GetInfo(bool fullInfo = true)
        {
            if(fullInfo)
                return new List<string> 
                { UID.ToString(), CID, LastName, FirstName, Address, Email, Phone, BirthDate.ToString("dd/MM/yyyy"), Gender.ToString() };
            else 
                return new List<string> 
                { LastName, FirstName };
        }
    }
}
