using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrchidSecure.Models.Filial
{
    public class Filial
    {
        private int id;
        private string address;
        private int zipCode;

        public Filial() { }

        public int getId()
        {
            return this.id;
        }
        public void setId(int ID)
        {
            this.id = ID;
        }

        public string getAddress()
        {
            return this.address;
        }
        public void setAddress(string Address)
        {
            this.address = Address;
        }

        public int getZipCode()
        {
            return this.zipCode;
        }
        public void setZipCode(int ZipCode)
        {
            this.zipCode = ZipCode;
        }

    }
}