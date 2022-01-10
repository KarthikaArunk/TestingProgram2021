using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProgram2021.Pages
{
   public class LoginPage
    {
        public void LoginSteps(IWebDriver driver)
        {
            //open chrome browser
            
            driver.Manage().Window.Maximize();

            //launch TurnUp portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            //try
            //{
                //identify username textbox and enter valid username
                IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
                usernameTextBox.SendKeys("hari");

                //identify the password textbox and enter valid password

                IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
                passwordTextBox.SendKeys("123123");

                //click on login button
                IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
                loginButton.Click();
            //}

        //catch (Exception ex)
        //    {
        //        Assert.Fail("TurnUp portal login page didnot launch",ex.Message);
        //    }
            
        }
    }
}
