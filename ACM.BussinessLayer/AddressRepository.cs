using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BussinessLayer
{
    public class AddressRepository
    {
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.StreetLine1 = "1501 truman ave.";
                address.StreetLine2 = "";
                address.City = "Key west";
                address.StateProv = "FL";
                address.PostalCode = "33030";
                address.Country = "US";
                address.AddressType = 1;
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            //cia turetu buti kodas kuris gautu visus adress id 
            //priklausanciu tam tikram klientui


            List<Address> addressList = new List<Address>();

            Address address = new Address(2)
            {
            StreetLine1 = "1502 truman ave.",
            StreetLine2 = "",
            City = "Key East",
            StateProv = "FL",
            PostalCode = "33031",
            Country = "USA",
            AddressType = 2
        };
            addressList.Add(address);

            address = new Address(3)
            {
                StreetLine1 = "1522 truman ave.",
                StreetLine2 = "",
                City = "Key East",
                StateProv = "NJ",
                PostalCode = "33031",
                Country = "USA",
                AddressType = 1
            };
            addressList.Add(address);


            return addressList;
        }

        public bool Save()
        {
            return true;
        }
    }
}
