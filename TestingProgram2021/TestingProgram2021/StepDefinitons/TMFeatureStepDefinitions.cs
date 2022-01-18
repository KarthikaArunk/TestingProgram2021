using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using TestingProgram2021.Pages;
using TestingProgram2021.Utilities;


namespace TestingProgram2021
{
    [Binding]
   
    public class TMFeatureStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage();
        HomePage homePageObj = new HomePage();
        TMPage tmPageObj = new TMPage();

        [Given(@"\[Successfully login to the home page]")]
        public void GivenSuccessfullyLoginToTheHomePage()
        {
            driver = new ChromeDriver();
            //Login page object initialization and definition
                        
            loginPageObj.LoginSteps(driver);
        }

        [Given(@"\[I navigate to time and material page]")]
        public void GivenINavigateToTimeAndMaterialPage()
        {
            // Homepage object initialization and definition

            homePageObj.GoToTMPage(driver);
        }

        [When(@"\[I create a new time and material record]")]
        public void WhenICreateANewTimeAndMaterialRecord()
        {
            //TMpage object initialization and definition

            tmPageObj.CreateTM(driver);
        }

        [Then(@"\[Add new time and material record successfully]")]
        public void ThenAddNewTimeAndMaterialRecordSuccessfully()
        {
            string actualCode = tmPageObj.GetCode(driver);
            string actualTypeCode = tmPageObj.GetTypeCode(driver);
            string actualDescription = tmPageObj.GetDescription(driver);
            string actualPrice = tmPageObj.GetPrice(driver);

            Assert.That(actualCode =="code21","Actual code and expected code do not match");
            Assert.That(actualTypeCode == "M", "Actual type code and expected code do not match");
            Assert.That(actualDescription == "Material21", "Actual description and expected descripton do not match");
            Assert.That(actualPrice == "250", "Actual price and expected price do not match");
        }

        [Given(@"\[Logged into Turn Up portal successfully]")]
        public void GivenLoggedIntoTurnUpPortalSuccessfully()
        {
            driver = new ChromeDriver();
            //Login page object initialization and definition

            loginPageObj.LoginSteps(driver);
        }

        [Given(@"\[ navigate to time and material page]")]
        public void GivenNavigateToTimeAndMaterialPage()
        {
            // Homepage object initialization and definition

            homePageObj.GoToTMPage(driver);
        }

        [When(@"\[I update '([^']*)' and '([^']*)' field on an existing record]")]
        public void WhenIUpdateAndFieldOnAnExistingRecord(string code, string time)
        {
            tmPageObj.EditTM(driver, code, time);
        }

       
        [Then(@"\[The record should have an updated '([^']*)' and '([^']*)' ]")]
        public void ThenTheRecordShouldHaveAnUpdatedAnd(string p0, string p1)
        {
            string editedNewCode = tmPageObj.GetEditedCode(driver);
            string editedNewDescription = tmPageObj.GetEditedDescription(driver);

            Assert.That(editedNewCode == p0, "Actual edited code and expected edited code do not match");
            Assert.That(editedNewDescription == p1, "Actual edited description and expected edited descripton do not match");
        }



        [Given(@"\[Select the previously edited record]")]
        public void GivenSelectThePreviouslyEditedRecord()
        {
            throw new PendingStepException();
        }

        [When(@"\[I delete the previously edited record]")]
        public void WhenIDeleteThePreviouslyEditedRecord()
        {
            throw new PendingStepException();
        }

        [Then(@"\[Delete the record from the table successfully]")]
        public void ThenDeleteTheRecordFromTheTableSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
