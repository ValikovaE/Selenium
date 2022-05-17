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
    public class ContactsPage : NavigationBar
    {
       
        
        private By addContactButton = By.Id("addContactButton");
        
        
        public void CheckContactButtonText(string expectedResult)
        {

            string actualResult = WrappedWait.Until(ExpectedConditions.ElementIsVisible(addContactButton)).Text;
        Assert.AreEqual(expectedResult, actualResult);
        }
}
}
