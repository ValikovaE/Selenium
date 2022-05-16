using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace AdvanceTestWithPageObjectModel.Settings
{
    public class SeleniumWrapper:Base
    {
        public void WaitAndClick(By locator)
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(driver.FindElement(locator))).Click();
        }

        public void WaitAndSendKeys(By locator, string text)
        {
            wait.Until(ExpectedConditions.ElementIsVisible(locator)).SendKeys(text);
        }

    }
}
