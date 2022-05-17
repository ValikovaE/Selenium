﻿using NUnit.Framework;
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

              
             // driver.Navigate().GoToUrl("https://projectplanappweb-stage.azurewebsites.net/login");

             // driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2000);
             // wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3200));
          }
        [TearDown]
        public void TearDown()
        {
            Driver.StopBrowser();
        }
    }
}
