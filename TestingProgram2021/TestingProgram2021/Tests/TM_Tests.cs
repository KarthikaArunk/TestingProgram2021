// See https://aka.ms/new-console-template for more information
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TestingProgram2021.Pages;
using TestingProgram2021.Utilities;

namespace TestingProgram2021 
{
    [TestFixture]   
    class TM_Tests : CommonDriver
    {
     [OneTimeSetUp]
        public void LoginFunction()
        {
            driver = new ChromeDriver();
            //Login page object initialization and definition

            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);
       
        // Homepage object initialization and definition
        HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }


        [Test, Order (1),Description("Check if user is able to create a Material record with valid data")]
        public void CreateTM_Test()
        {
            //TMpage object initialization and definition

            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);
        }

        [Test, Order (2),Description("Check if user is able to edit a Material record with valid data")]
        public void EditTM_Test()
        {
            //TMPage Edit obj definition
           
            TMPage tmPageObjedit = new TMPage();
            tmPageObjedit.EditTM(driver);
        }

        [Test, Order (3),Description("Check if user is able to delete an existing Material record")]
        public void DeleteTM_Test()
        {

            //TMPage Delete obj definition
            TMPage tmPageObjdelete = new TMPage();
            tmPageObjdelete.DeleteTM(driver);

        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }

    }
}
