using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BussinessLayer
{
    public class CustomerRepository
    {
        private AddressRepository addressRepository { get; set; }

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();

            if (customerId==1)
            {
                //customer.CustomerId = 1; // set yra private
                customer.EmailAddress = "aidas@aidas.lt";
                customer.FirstName = "Aidas";
                customer.LastName = "Baranauskas";
            }
            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }


        public bool Save(Customer customer)
        {
            bool success = true;
            if (customer.IsValid && customer.HasChanges)
            {
                if (customer.IsNew)
                {
                    //Call Insert procedura
                }
                else
                {
                    //update
                }
            }
            return success;
        }
    }
}
