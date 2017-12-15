using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrchidSecure.Models.Address
{
    public class Address
    {
        private int id;
        private string address;
        private int zipcode;

        public Address() { }
        public Address(int pId, string pAddress, int pZipcode)
        {
            this.id = pId;
            this.address = pAddress;
            this.zipcode = pZipcode;
        }

        public void setId(int pId)
        {
            this.id = pId;
        }
        public int getId()
        {
            return this.id;
        }

        public void setAddress(string pAddress)
        {
            this.address = pAddress;
        }
        public string getAddress()
        {
            return this.address;
        }

        public void setZipcode(int pZipcode)
        {
            this.zipcode = pZipcode;
        }
        public int getZipcode()
        {
            return this.zipcode;
        }
    }
}