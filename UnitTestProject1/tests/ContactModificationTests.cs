﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactsData newData = new ContactsData("Adam","Smith");
            newData.Company = "epam";
            newData.Mobile = "+0987654321";
            newData.Email = "email";
            newData.Address2 = "USA";

            app.Contacts.Modify(4, newData);
        }
    }
}