using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrchidSecure.Models.AccessRights
{
    public class AccessRight
    {
        private int id;
        private string role;

        public AccessRight(int Id, string Role)
        {
            this.id = Id;
            this.role = Role;
        }

        public int getId()
        {
            return this.id;
        }
        public void setId(int Id)
        {
            this.id = Id;
        }

        public string getRole()
        {
            return this.role;
        }
        public void setRole(string Role)
        {
            this.role = Role;
        }
    }
}