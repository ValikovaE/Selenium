using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using AdvanceTestWithPageObjectModel.PageObjectModel;
using AdvanceTestWithPageObjectModel.Settings;

namespace AdvanceTestWithPageObjectModel.Tests
{
    class Opportunities:Base
    {

        [Test]

        public void EmployeeSearch()
        {
            LogInPage logInPage = new LogInPage();
            logInPage.ClickLogInButton()
                .SetEmailAndContinue("automation.pp@amdaris.com")
                .SetPasswordAndSubmit("10704-observe-MODERN-products-STRAIGHT-69112")
                .ClickSubmitButton()
                .GoToOpportunitiesFromMenu()
                .CheckOpportunitiesButtonText("Add Opportunity");












        }
        }
}
