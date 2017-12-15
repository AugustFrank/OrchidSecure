using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrchidSecure.Models.CreditScore
{
    public class CreditScore
    {
        private int id;
        private string segment;

        public CreditScore() { }
        public CreditScore(int pId, string pSegment)
        {
            this.id = pId;
            this.segment = pSegment;
        }

        public void setId(int pId)
        {
            this.id = pId;
        }
        public int getId()
        {
            return this.id;
        }

        public void setSegment(string pSegment)
        {
            this.segment = pSegment;
        }
        public string getSegment()
        {
            return this.segment;
        }

    }
}