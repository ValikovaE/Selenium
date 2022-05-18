using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Threading;

namespace AdvanceTestWithPageObjectModel.Settings
{
    public class Base
    {
        
        [SetUp]
          public void Setup()
          {

            Driver.StartBrowser();
        }
        [TearDown]
        public void TearDown()
        {
            Driver.StopBrowser();
        }
    }
}
