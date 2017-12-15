using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrchidSecure.Models.Account
{
    public class Account
    {
        private int id;
        private int accountNo;
        private int balance;

        public Account() { }
        public Account(int pId, int pAccountNo, int pBalance)
        {
            this.id = pId;
            this.accountNo = pAccountNo;
            this.balance = pBalance;
        }

        public void setId(int pId)
        {
            this.id = pId;
        }
        public int getId()
        {
            return this.id;
        }

        public void setAccountNo(int pAccountNo)
        {
            this.accountNo = pAccountNo;
        }
        public int getAccountNo()
        {
            return this.accountNo;
        }

        public void setBalance(int pBalance)
        {
            this.balance = pBalance;
        }
        public int getBalance()
        {
            return this.balance;
        }


    }
}