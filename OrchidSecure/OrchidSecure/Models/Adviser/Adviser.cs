using OrchidSecure.Models.Custommer;
using OrchidSecure.Models.AccessRights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrchidSecure.Models.Adviser
{
    public class Adviser
    {

        private int id;
        private string name;
        private string initials;
        private string mail;
        private Filial.Filial filial;
        private List<Custommer.Custommer> custommers = new List<Custommer.Custommer>();
        private AccessRight accessRight;

        public Adviser(int Id, string Name, string Initials, string Mail, Filial.Filial Filial, Custommer.Custommer custommer, AccessRight AccessRight)
        {
            this.id = Id;
            this.name = Name;
            this.initials = Initials;
            this.mail = Mail;
            this.filial = Filial;
            this.custommers.Add(custommer);
            this.accessRight = AccessRight;
        }

        public int getId()
        {
            return this.id;
        }
        public void setId(int Id)
        {
            this.id = Id;
        }

        public string getName() 
        {
            return this.name;
        }
        public void setName(string Name)
        {
            this.name = Name;
        }

        public string getInitials()
        {
            return this.initials;
        }
        public void setInitials(string Initials)
        {
            this.initials = Initials;
        }

        public string getMail()
        {
            return this.mail;
        }
        public void setMail(string Mail)
        {
            this.mail = Mail;
        }

        public Filial.Filial getFilial()
        {
            return this.filial;
        }
        public void setFilial(Filial.Filial filial)
        {
            this.filial = filial;
        }

        public List<Custommer.Custommer> getAllCustommers()
        {
            return this.custommers;
        }
        public Custommer.Custommer getCustommer(Custommer.Custommer custommer)
        {
            Custommer.Custommer Custommer = new Custommer.Custommer();
            foreach(Custommer.Custommer c in custommers)
            {
                if(c.getId() == custommer.getId())
                {
                    Custommer = c;
                } else
                {
                    Custommer = null;
                }
            }
            return Custommer;
        }

        public void addCustommer(Custommer.Custommer custommer)
        {
            this.custommers.Add(custommer);
        }

        public AccessRight getAccessRight()
        {
            return accessRight;
        }
        public void setAccesRight(AccessRights.AccessRight accessRight)
        {
            this.accessRight = accessRight;
        }


    }
}