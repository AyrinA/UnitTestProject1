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
    public class GroupCreationTest : TestBase
    {
        [Test]
        public void GroupCreation()
        {
            GroupData group = new GroupData("one");
            group.Header = "two";
            group.Footer = "three";

            app.Groups.Create(group);
        }

        [Test]
        public void GroupCreation_EmptyData()
        {
           
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            app.Groups.Create(group);
        }
    }
}

