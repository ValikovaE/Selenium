using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

using AdvanceTestWithPageObjectModel.Settings;

namespace AdvanceTestWithPageObjectModel.PageObjectModel
{
    public class NavigationBar:BasePage
    {
        private By clientsTab = By.Id("clients-tab");
        private By employees = By.Id("employees-tab");
        private By checkLogo = By.CssSelector("div.background");
        private By contacts = By.Id("contacts-tab");
        private By opportunities = By.Id("opportunities-tab");

        private By projects = By.Id("projects-tab");



        public ClientsPage GoToClientsFromMenu()
        {

            WaitAndClick(clientsTab);
            return new ClientsPage();
        }
        
      

        public EmployeeListPage GoToEmployeesFromMenu()
        {

            WaitAndClick(employees);
            return new EmployeeListPage();
        }
        

        

        
        public ContactsPage GoToContactsFromMenu()
        {
            WaitAndClick(contacts);
            return new ContactsPage();
        }
        public ProjectsPage GoToProjectsFromMenu()
        {
            WaitAndClick(projects);
            return new ProjectsPage();
        }
        
   

        public OpportunitiesPage GoToOpportunitiesFromMenu()
        {

            WaitAndClick(opportunities);
            return new OpportunitiesPage();
        }
    }
}
