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
    public class ClientsPage:NavigationBar
    {
        
        
        
        private By addClientButton = By.Id("addClientButton");

        
        

        public void CheckClientButtonText(string expectedResult)
        {

            string actualResult = wait.Until(ExpectedConditions.ElementIsVisible(addClientButton)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

