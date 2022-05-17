using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;
using AdvanceTestWithPageObjectModel.Settings;

namespace AdvanceTestWithPageObjectModel.PageObjectModel
{
   public class LogInPage:BasePage
    {
       

        
        private By logInButton =By.CssSelector("div.button>span");

        public LogInPage(IWebDriver driver) : base(driver)
        {
        }
        public LogInPage() : base()
        {
           
                

            
        }
        public EmailPage ClickLogInButton()
        {
            WaitAndClick(logInButton);
            return new EmailPage();
        }
    }
}
