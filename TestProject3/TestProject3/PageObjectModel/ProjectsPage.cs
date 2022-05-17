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
    public class ProjectsPage:HomePage
{
    
    
    private By addProjectButton =By.Id("addProjectButton");
   
   public void CheckProjectButtonText(string expectedResult)
    {

            string actualResult = WrappedWait.Until(ExpectedConditions.ElementIsVisible(addProjectButton)).Text;
            Assert.AreEqual(expectedResult, actualResult);

        }
}
}

