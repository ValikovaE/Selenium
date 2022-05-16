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
    public class EmailPage:BasePage
    {
        
        private By emailField =By.XPath(" //input[@type='email']");
        private By nextButton = By.XPath(" //input[@type='submit']");
        private By errorMessage = By.Id("usernameError");

        public PasswordPage SetEmailAndContinue (string email)
        {
            WaitAndSendKeys(emailField, email);
            WaitAndClick(nextButton);
            return new PasswordPage();
        }
        
       
        public void SetInvalidEmailAndCheckMessage(string expectedResult,string email)
        {
            WaitAndSendKeys(emailField, email);
            WaitAndClick(nextButton);
            string actualResult = wait.Until(ExpectedConditions.ElementIsVisible(errorMessage)).Text;
            Assert.AreEqual(expectedResult, actualResult);
            
        }
    }
}
