// See https://aka.ms/new-console-template for more information
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;


namespace TestingProgram2021 
{
    class Program
    {
        static void Main(string[] args)
        {
            //open chrome browser
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //launch TurnUp portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //identify username textbox and enter valid username
            IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
            usernameTextBox.SendKeys("hari");

            //identify the password textbox and enter valid password

            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
            passwordTextBox.SendKeys("123123");

            //click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            //check if user is logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));
            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Log in failed");
            }
            //identify Administrator dropdown listbox and click on it
            IWebElement administrationListBox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationListBox.Click();

            //Identify Time & Materials and select
            IWebElement timeandmaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeandmaterialOption.Click();

            //click on Create New button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            createNewButton.Click();

            //Identify TypeCode dropdown list box and select Material
            IWebElement typecodeListBox = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typecodeListBox.Click();
            Thread.Sleep(5000);

            //Identify option 'Material'  and click on it
            IWebElement materialSelect = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            materialSelect.Click();
            Thread.Sleep(5000);

            //Identify code textbox and enter valid code
            IWebElement codeTextBox = driver.FindElement(By.Id("Code"));
            codeTextBox.SendKeys("code21");

            //Identify description testbox and enter valid description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
            descriptionTextbox.SendKeys("Material21");

            //Identify price testbox and enter valid price
            IWebElement pricet = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            pricet.Click();


            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("250");

            //Identify save button and click on it

            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Thread.Sleep(2000);

            //Identify lastpagebutton and click on it
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(2000);

            // Identify code & make sure that the record is added to the table

            IWebElement codeDetail = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (codeDetail.Text == "code21")
            {
                Console.WriteLine("Record added successfully, Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
        }
        
    }
}
