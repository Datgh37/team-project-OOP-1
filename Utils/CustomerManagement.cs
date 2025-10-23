using BankManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Utils
{
    public class CustomerManagement
    {
        private readonly List<Customer> _customers = new();
        public List<Customer> Customers { get => _customers; }
        public void AddCustomer(Customer customer)
        {
            if (_customers.Any(c => c.UID == customer.UID || c.CID == customer.CID))
                throw new Exception("Customer already exists!");
            _customers.Add(customer);
        }
        public void RemoveCustomer(Customer customer)
        {
            if (!_customers.Contains(customer))
                throw new Exception("Customer Not Found!");
            _customers.Remove(customer);
        }
        public void RemoveCustomer(Guid uid)
        {
            var customer = this[uid];
            if (customer == null)
                throw new Exception("Customer Not Found");
            _customers.Remove(customer);
        }
        //public void RemoveCustomer(string cid) => _customers.RemoveAll(c => c.CID == cid);
        public Customer? FindById(Guid id) => _customers.FirstOrDefault(c => c.UID == id);
        public Customer? FindByCID(string cid) => _customers.FirstOrDefault(c => c.CID == cid);
        public Customer? this[Guid uid] => _customers.FirstOrDefault(c => c.UID == uid);
        public Customer? this[string name] => _customers.FirstOrDefault(c => (c.FirstName + c.LastName).Contains(name));
 
        //public IEnumerable<Customer> GetAll() => _customers.AsReadOnly();

        // Get List from CSV File
        public List<Customer> GetCustomerListFromCSV(string fileName = "")
        {
            fileName = (fileName == "") ? GlobalSettings.CustomerInfoPath : fileName; // Get default path
            var customers = new List<Customer>();
            // Stream Reader, read file content
            using (StreamReader reader = new StreamReader(fileName))
            {
                if (!reader.EndOfStream) reader.ReadLine(); // Skip Header line
                while (!reader.EndOfStream)
                {
                    string? line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        Customer cust = new Customer();
                        customers.Add(cust);
                    }
                }
            }
            return customers;
        }
        public void ImportCustomerListFromCSV(string fileName = "")
        {
            fileName = (fileName == "") ? GlobalSettings.CustomerInfoPath : fileName; // Get default path
            _customers.Clear();
            // Stream Reader, read file content
            using (StreamReader reader = new StreamReader(fileName))
            {
                if (!reader.EndOfStream) reader.ReadLine(); // Skip Header line
                while (!reader.EndOfStream)
                {
                    string? line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        Customer cust = new Customer();
                        _customers.Add(cust);
                    }
                }
            }
        }
    }
}
