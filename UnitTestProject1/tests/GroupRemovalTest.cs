﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace addressbook_web_tests
{
    [TestFixture]
    public class GroupRemovalTest : AuthTestBase
    { 
        [Test]
        public void GroupRemovalTests()
        {
            app.Groups.Remove(1);
        }
    }
}
