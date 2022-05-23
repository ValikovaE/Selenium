using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using AdvanceTestWithPageObjectModel.PageObjectModel;
using AdvanceTestWithPageObjectModel.Settings;

namespace AdvanceTestWithPageObjectModel.Tests
{
    class EmployeeTest : Base
    {

        [Test]
        public void EmployeeSearchByFamily()
        {
            LogInPage logInPage = new LogInPage();
            logInPage.ClickLogInButton()
                .SetEmailAndContinue("automation.pp@amdaris.com")
                .SetPasswordAndSubmit("10704-observe-MODERN-products-STRAIGHT-69112")
                .ClickSubmitButton()
                .GoToEmployeesFromMenu()
                .OpenEmployeeInfoByName("valicova")
                .CheckDownloadEmployeeInfo("Profile");


        }
        [Test]
        public void EmployeeSearch()
        {
            LogInPage logInPage = new LogInPage();
            logInPage.ClickLogInButton()
                .SetEmailAndContinue("automation.pp@amdaris.com")
                .SetPasswordAndSubmit("10704-observe-MODERN-products-STRAIGHT-69112")
                .ClickSubmitButton()
                .GoToEmployeesFromMenu()
                .OpenEmployeeInfoByName("adrian croitor")
                .CheckShowAllProjectsButtonText("Show all Projects");


        }
        [Test]
        public void EmployeeNotesCancel()
        {
            LogInPage logInPage = new LogInPage();
            logInPage.ClickLogInButton()
                .SetEmailAndContinue("automation.pp@amdaris.com")
                .SetPasswordAndSubmit("10704-observe-MODERN-products-STRAIGHT-69112")
                .ClickSubmitButton()
                .GoToEmployeesFromMenu()
                .OpenEmployeeInfoByName("alexandru micu")
                .WritingEmployeeNotes("alexandru micu")
                .CheckCancelButtonText("Cancel");
        }
        [Test]
        public void DownloadEmployeeInfo()
        {
            LogInPage logInPage = new LogInPage();
            logInPage.ClickLogInButton()
                .SetEmailAndContinue("automation.pp@amdaris.com")
                .SetPasswordAndSubmit("10704-observe-MODERN-products-STRAIGHT-69112")
                .ClickSubmitButton()
                .GoToEmployeesFromMenu()
                .OpenEmployeeInfoByName("alexandru micu")
                .CheckDownloadEmployeeInfo("Profile");
        }
        [Test]
        public void EmployeeSearchFilterTest()
        {
            LogInPage logInPage = new LogInPage();
            logInPage.ClickLogInButton()
                .SetEmailAndContinue("automation.pp@amdaris.com")
                .SetPasswordAndSubmit("10704-observe-MODERN-products-STRAIGHT-69112")
                .ClickSubmitButton()
                .GoToEmployeesFromMenu()
                .FilterEmployeeSearch()
                .CheckEmployeeSearchByDeliverySitesFilter("All Delivery Sites");
        }
    }
}
