using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using AdvanceTestWithPageObjectModel.Settings;

namespace AdvanceTestWithPageObjectModel.PageObjectModel
{
    public class EmployeeListPage : NavigationBar
    {
        
        
        private By employeesField =By.XPath(" //input[@type='text']");

        private By infoButton =By.CssSelector(" div.bottom-info");

        private By allProjectButton =By.Id("employeeProfileShowAllProjectsButton");

        
        public EmployeeListPage OpenEmployeeInfoByName(string name)
        {
            WaitAndSendKeys(employeesField, name);
            WaitAndClick(infoButton);
            return this;
        }
       
        public void CheckShowAllProjectsButtonText(string expectedResult)
        {

            string actualResult = wait.Until(ExpectedConditions.ElementIsVisible(allProjectButton)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}