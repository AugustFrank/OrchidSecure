using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace OrchidSecure.Models.Custommer
{
    public class Custommer
    {
        private int id;
        private int cpr;
        private string name;
        private Account.Account account;
        private CreditScore.CreditScore creditScore;
        private Address.Address address;

        public Custommer(int Id, int Cpr, string Name, Account.Account account, CreditScore.CreditScore creditScore, Address.Address address)
        {
            this.id = Id;
            this.cpr = Cpr;
            this.name = Name;
            this.account = account;
            this.creditScore = creditScore;
            this.address = address;
        }

        public Custommer() { }

        public int getId()
        {
            return this.id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public int getCpr()
        {
            return this.cpr;
        }
        public void setCpr(int Cpr)
        {
            this.cpr = Cpr;
        }

        public string getName()
        {
            return this.name;
        }
        public void setName(string Name)
        {
            this.name = Name;
        }

        public Account.Account getAccount()
        {
            return this.account;
        }
        public void setAccount(Account.Account account)
        {
            this.account = account;
        }

        public CreditScore.CreditScore getCredit()
        {
            return this.creditScore;
        }
        public void setCreditScore(CreditScore.CreditScore score)
        {
            this.creditScore = score;
        }

        public Address.Address getAddress()
        {
            return this.address;
        }
        public void setAddress(Address.Address address)
        {
            this.address = address;
        }
    }
}