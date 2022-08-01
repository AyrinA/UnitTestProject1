using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactsTest : AuthTestBase
    {
        [Test]
        public void ContactCreation()
        {
            ContactsData contact = new ContactsData("firstname","lastname");
            contact.Firstname = "firstname";
            contact.Lastname = "lastname";
            contact.Company = "company";
            contact.Mobile = "mobile";
            contact.Email = "email";
            contact.Address2 = "address2";

            app.Contacts.CreateContact(contact);
        }

        [Test]
        public void OtherContactCreation()
        {
            ContactsData contacts = new ContactsData("Adam","Smith");
            contacts.Firstname = "Adam";
            contacts.Lastname = "Smith";
            contacts.Company = "FIX";
            contacts.Mobile = "+1234567890";
            contacts.Email = "AdamSmith@gmail.com";
            contacts.Address2 = "USA";

            app.Contacts.CreateContact(contacts);
        }
    }
}
