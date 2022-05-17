using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using AdvanceTestWithPageObjectModel.PageObjectModel;
using AdvanceTestWithPageObjectModel.Settings;

namespace AdvanceTestWithPageObjectModel.Tests
{
    class LogInTests:Base
{
    [Test]
    public void WrongDataLogin()
    {
        LogInPage logInPage = new LogInPage();
        logInPage.ClickLogInButton()
            .SetInvalidEmailAndCheckMessage("Hi@AA.AA", "We couldn't find an account with that username.");






    }
    [Test]
    public void SuccesLoginCorrectDataAndViewContacts()
    {
        LogInPage logInPage = new LogInPage();
        logInPage.ClickLogInButton()
        .SetEmailAndContinue("automation.pp@amdaris.com")
        .SetPasswordAndSubmit("10704-observe-MODERN-products-STRAIGHT-69112")
                .ClickSubmitButton()
                .GoToContactsFromMenu()
                .CheckContactButtonText("Add Contact");





        /* MainPage mainPage = new MainPage();
         mainPage.CheckingLogo();
         mainPage.CheckingContacts();

         ContactsPage contactsPage = new ContactsPage();
         contactsPage.CheckingContactsMenu();
         contactsPage.AssertError("Add Contact");*/
    } }
}
