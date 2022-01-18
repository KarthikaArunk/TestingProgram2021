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
    [Parallelizable]
    class TM_Tests : CommonDriver
    {
          
        [Test, Order (1),Description("Check if user is able to create a Material record with valid data")]
        public void CreateTM_Test()
        {
            // Homepage object initialization and definition
            //HomePage homePageObj = new HomePage();
            //homePageObj.GoToTMPage(driver);

            //TMpage object initialization and definition

            TMPage tmPageObj = new TMPage();
            tmPageObj.CreateTM(driver);
        }

        [Test, Order (2),Description("Check if user is able to edit a Material record with valid data")]
        public void EditTM_Test()
        {
            // Homepage object initialization and definition
            
           // homePageObj.GoToTMPage(driver);

            //TMPage Edit obj definition

            TMPage tmPageObjedit = new TMPage();
            tmPageObjedit.EditTM(driver,"dummy","dummy");
        }

        [Test, Order (3),Description("Check if user is able to delete an existing Material record")]
        public void DeleteTM_Test()
        {
            // Homepage object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            //TMPage Delete obj definition
            TMPage tmPageObjdelete = new TMPage();
            tmPageObjdelete.DeleteTM(driver);

        }
     
    }
}
