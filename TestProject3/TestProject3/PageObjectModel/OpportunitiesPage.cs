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
    public class OpportunitiesPage : NavigationBar
    {
        
        
       
        private By addNewOpportunities =By.Id("addOpportunityButton");



        public void CheckOpportunitiesButtonText(string expectedResult)
        {

            string actualResult = WrappedWait.Until(ExpectedConditions.ElementIsVisible(addNewOpportunities)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}