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

        private By notesField = By.CssSelector("div.ql-editor");
        private By boldButton = By.CssSelector("button.ql-bold");
        private By cancelButton = By.Id("cancel-button");

        private By downloadEmployeeInfoButton = By.Id("employeeProfiledownload");
        private By followButton = By.CssSelector("i.fa follow");
        private By followMessage = By.Id("_hjRemoteVarsFrame");
        private By filterButton = By.CssSelector("i.fa-filter");

        private By allDeliverySitesButton = By.Id("mat-select-0");
        private By familyHref = By.LinkText("https://projectplanappweb-stage.azurewebsites.net/employees/273");



        public EmployeeListPage OpenEmployeeInfoByName(string name)
        {
            WaitAndSendKeys(employeesField, name);
            WaitAndClick(infoButton);
            return this;
        }
       
        public void CheckShowAllProjectsButtonText(string expectedResult)
        {

            string actualResult = WrappedWait.Until(ExpectedConditions.ElementIsVisible(allProjectButton)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }
        public EmployeeListPage WritingEmployeeNotes(string name)
        {
            WaitAndSendKeys(notesField, name);
            WaitAndClick(boldButton);
            return this;

        }
        public void CheckCancelButtonText(string expectedResult)
        {

            string actualResult = WrappedWait.Until(ExpectedConditions.ElementIsVisible(cancelButton)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }
        public void CheckDownloadEmployeeInfo(string expectedResult)
        {

            string actualResult = WrappedWait.Until(ExpectedConditions.ElementIsVisible(downloadEmployeeInfoButton)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }
        public EmployeeListPage FilterEmployeeSearch()
        {
            
            WaitAndClick(filterButton);
            return this;

        }
        public void CheckEmployeeSearchByDeliverySitesFilter(string expectedResult)
        {

            string actualResult = WrappedWait.Until(ExpectedConditions.ElementIsVisible(allDeliverySitesButton)).Text;
            Assert.AreEqual(expectedResult, actualResult);
        }
        public EmployeeListPage EmployeeSearchbyFamilyCheck()
        {

            WaitAndClick(familyHref);
            return this;

        }
    }
}