using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using AdvanceTestWithPageObjectModel.PageObjectModel;
using AdvanceTestWithPageObjectModel.Settings;

namespace AdvanceTestWithPageObjectModel.Tests
{
    class EmployeeTest:Base
    {
        [Test]
        public void EmployeeSearch()
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.ClickLogInButton()
                .SetEmailAndContinue("automation.pp@amdaris.com")
                .SetPasswordAndSubmit("10704-observe-MODERN-products-STRAIGHT-69112")
                .ClickSubmitButton()
                .GoToEmployeesFromMenu()
                .OpenEmployeeInfoByName("adrian croitor")
                .CheckShowAllProjectsButtonText("Show all Projects");

            
        }
    }
}
