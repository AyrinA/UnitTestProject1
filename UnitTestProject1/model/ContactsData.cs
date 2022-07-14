using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbook_web_tests
{
    public class ContactsData
    {
        private string firstname;
        private string lastname;
        private string company = "";
        private string mobile = "";
        private string email = "";
        private string address2 = "";

        public ContactsData(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public ContactsData(string firstname, string lastname, string company, string mobile, string email, string address2)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.company = company;
            this.mobile = mobile;
            this.email = email;
            this.address2 = address2;
        }

        public string Firstname
        { get { return firstname; } set { firstname = value; } }

        public string Lastname
        { get { return lastname; } set { lastname = value; } }

        public string Company
        { get { return company; } set { company = value; } }

        public string Mobile
        { get { return mobile; } set { mobile = value; } }

        public string Email
        { get { return email; } set { email = value; } }

        public string Address2
        { get { return address2; } set { address2 = value; } }
    }
}
