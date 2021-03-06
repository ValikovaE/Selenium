using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using AdvanceTestWithPageObjectModel.Settings;

namespace AdvanceTestWithPageObjectModel.PageObjectModel
{
    public class PasswordPage:BasePage
    {
        
        private By passwordField = By.XPath(" //input[@type='password']");
        private By nextButton =By.XPath(" //input[@type='submit']");
        public CheckboxPage SetPasswordAndSubmit(string password)
        {
            WaitAndSendKeys(passwordField, password);
            WaitAndClick(nextButton);
            return new CheckboxPage();
        }
        
    }

}
