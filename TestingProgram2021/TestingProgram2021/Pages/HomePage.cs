using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProgram2021.Utilities;

namespace TestingProgram2021.Pages
{
     public class HomePage
    {
        public void GoToTMPage(IWebDriver driver)
        {
            //identify Administrator dropdown listbox and click on it
         IWebElement administrationListBox = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
         administrationListBox.Click();

            Wait.WaitToBeClickable(driver, "XPath", "/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a", 2);


            //Identify Time & Materials and select
        IWebElement timeandmaterialOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        timeandmaterialOption.Click();
        }

        public void GoToEmployeePage(IWebDriver driver)
        {
            //click on Employee option

        }
    }
}
