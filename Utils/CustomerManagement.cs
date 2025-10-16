using BankManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Utils
{
    internal class CustomerManagement
    {
        private readonly List<Customer> _customers = new();

        public void AddCustomer(Customer customer)
        {
            if (_customers.Any(c => c.UID == customer.UID || c.CID == customer.CID))
                throw new Exception("Customer already exists!");
            _customers.Add(customer);
        }
        public Customer? FindById(Guid id) => _customers.FirstOrDefault(c => c.UID == id);
        public Customer? FindByCID(string cid) => _customers.FirstOrDefault(c => c.CID == cid);
        public void Remove(Guid id) => _customers.RemoveAll(c => c.UID == id);
        //public IEnumerable<Customer> GetAll() => _customers.AsReadOnly();

        // Get List from CSV File
        public List<Customer> GetCustomerList(string fileName = "")
        {
            fileName = (fileName == "") ? GlobalSettings.CustomerInfoPath : fileName; // Get default path
            var customers = new List<Customer>();
            // Stream Reader, read file content
            using (StreamReader reader = new StreamReader(fileName))
            {
                if (!reader.EndOfStream) reader.ReadLine(); // Skip Header line
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        Customer cust = new Customer();
                        customers.Add(cust);
                    }
                }
            }
            return customers;
        }
    }
}
