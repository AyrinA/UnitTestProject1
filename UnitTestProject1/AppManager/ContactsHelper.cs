using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace addressbook_web_tests
{
    public class ContactsHelper: HelperBase
    {
        public ContactsHelper(ApplicationManager manager)
           : base(manager)
        {
        }

        public ContactsHelper CreateContact (ContactsData contacts)
        {
            manager.Navigator.OpenHomePage();

            AddNewContact();
            InitContactCreation();
            FillContactForm(contacts);
            SubmitContactCreation();
            return this;
        }

        public ContactsHelper SubmitContactCreation()
        {
            driver.FindElement(By.XPath("//div[@id='content']/form/input[21]")).Click();
            return this;
        }

        public ContactsHelper FillContactForm(ContactsData contacts)
        {
            driver.FindElement(By.Name("firstname")).Click();
            driver.FindElement(By.Name("firstname")).Clear();
            driver.FindElement(By.Name("firstname")).SendKeys(contacts.Firstname);
            driver.FindElement(By.Name("lastname")).Click();
            driver.FindElement(By.Name("lastname")).Clear();
            driver.FindElement(By.Name("lastname")).SendKeys(contacts.Lastname);
            driver.FindElement(By.Name("nickname")).Click();
            driver.FindElement(By.Name("address")).Click();
            driver.FindElement(By.Name("company")).Click();
            driver.FindElement(By.Name("company")).Clear();
            driver.FindElement(By.Name("company")).SendKeys(contacts.Company);
            driver.FindElement(By.Name("theform")).Click();
            driver.FindElement(By.Name("home")).Click();
            driver.FindElement(By.Name("mobile")).Click();
            driver.FindElement(By.Name("mobile")).Clear();
            driver.FindElement(By.Name("mobile")).SendKeys(contacts.Mobile);
            driver.FindElement(By.Name("email")).Click();
            driver.FindElement(By.Name("email")).Clear();
            driver.FindElement(By.Name("email")).SendKeys(contacts.Email);
            driver.FindElement(By.Name("address2")).Click();
            driver.FindElement(By.Name("address2")).Clear();
            driver.FindElement(By.Name("address2")).SendKeys(contacts.Address2);
            return this;
        }

        public ContactsHelper InitContactCreation()
        {
            driver.Navigate().GoToUrl("http://localhost/addressbook/edit.php");
            return this;
        }

        public ContactsHelper AddNewContact()
        {
            driver.FindElement(By.LinkText("add new")).Click();
            return this;
        }

        public bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }


    }
}
