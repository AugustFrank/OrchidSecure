using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrchidSecure.Models.Adviser
{
    public class AdviserModel
    {

        private int id;
        private string name;
        private string initials;
        private string mail;
        private int filialId;
        private List<Custommer> custommers = new List<Custommer>();
        private int accessRightId;

        public AdviserModel(int Id, string Name, string Initials, string Mail, string FilialId, Custommer Custommer, int AccessRightId)
        {
            this.id = Id;
            this.name = Name;
            this.initials = Initials;
            this.mail = Mail;
            this.filialId = FilialId;
            this.custommers.Add(Custommer);
            this.accessRightId = AccessRightId;
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

        public int getFilialId()
        {
            return this.filialId;
        }
        public void setFilialId(Filial filial)
        {
            this.filialId = filial.getId();
        }

        public List<Custommer> getAllCustommers()
        {
            return this.custommers;
        }
        public Custommer getCustommer(Custommer Custommer)
        {
            return this.custommers.Find(Custommer.id);
        }
        public void addCustommer(Custommer custommer)
        {
            this.custommers.Add(custommer);
        }

        public int getAccessRight()
        {
            return this.accessRightId;
        }
        public void setAccesRight(AccessRight accessRight)
        {
            this.accessRightId = accessRight.getId();
        }


    }
}