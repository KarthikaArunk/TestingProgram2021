using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingProgram2021.Utilities;


namespace TestingProgram2021.Pages
{
   public class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
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
            //Wait.WaitToExist(driver, "XPath", "//*[@id='tmsGrid']/div[4]/a[4]/span",5);
            Thread.Sleep(3000);

            //Identify lastpagebutton and click on it
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();
            Thread.Sleep(2000);

            // Identify code & make sure that the record is added to the table

            
            
            
            
            ////Option1
            //Assert.That(codeDetail.Text == "code21", "Actual code and expected code do not match");
            //Assert.That(typeCodeDetail.Text == "M", "Actual TypeCode and expected TypeCode do not match");
            //Assert.That(descriptionDetail.Text == "Material21", "Actual description and expected description do not match");
            //Assert.That(priceDetail.Text == "$250.00", "Actual price and expected price do not match");

            //Option2

            //if (codeDetail.Text == "code21")
            //{
            //    Console.WriteLine("Record added successfully");
            //    //Assert.Pass("Record added successfully, Test Passed");
            //}
            //else
            //{
            //    Console.WriteLine("Test Failed");
            //    //Assert.Fail("Test Failed");
            //}

        }
        public string GetCode(IWebDriver driver)
        {
            IWebElement codeDetail = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return codeDetail.Text;
        }

        public string GetTypeCode(IWebDriver driver)
        {
            IWebElement typeCodeDetail = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            return typeCodeDetail.Text;
        }

        public string GetDescription(IWebDriver driver)
        {
            IWebElement descriptionDetail = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return descriptionDetail.Text;
        }

        public string GetPrice(IWebDriver driver)
        {
            IWebElement priceDetail = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
            return priceDetail.Text;
        }



        public void EditTM(IWebDriver driver,string code, string description)
        {
            //Identify lastpagebutton and click on it
            Thread.Sleep(3000);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();

            IWebElement findLatestRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));

            if (findLatestRecord.Text == "code21")
            {
                // Identify Edit button  and click on that
                IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
                editButton.Click();
                //Thread.Sleep(6000);
            }
            else
            {
                Assert.Fail("Record not found");
            }


            //Identify option 'Material'  and click on it
            //IWebElement materialSelect1 = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            //materialSelect1.Click();
            //Thread.Sleep(5000);

            //Identify code textbox and Edit code
            IWebElement codeTextBox1 = driver.FindElement(By.Id("Code"));
            codeTextBox1.Clear();
            codeTextBox1.SendKeys(code);

            //Identify 'Description' and edit 
            IWebElement descriptionTextBox1 = driver.FindElement(By.Id("Description"));
            descriptionTextBox1.Clear();
            descriptionTextBox1.SendKeys(description);
            Thread.Sleep(5000);

            //Identify price testbox and enter valid price
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            IWebElement priceTextbox1 = driver.FindElement(By.Id("Price"));

            priceTag.Click();
            priceTextbox1.Clear();
            priceTag.Click();
            priceTextbox1.SendKeys("100");
            Thread.Sleep(5000);

            //Identify save button and click on it

            IWebElement saveButton1 = driver.FindElement(By.Id("SaveButton"));
            saveButton1.Click();
            Thread.Sleep(5000);

            //Identify lastpagebutton and click on it
            IWebElement lastPageButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageButton1.Click();
            Thread.Sleep(3000);

            // Identify code & make sure that the record is Edited 
            // Assertion

            //IWebElement newCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            //IWebElement newTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
            //IWebElement newDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            //IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));


            //Assertion

            //Assert.That(newCode.Text == "code31", "Code field hasn't been edited.");
            //Assert.That(newTypeCode.Text == "Material31", "TypeCode field hasn't been edited.");
            //Assert.That(newDescription.Text == "Material31", "newDescription field hasn't been edited.");
            //Assert.That(newPrice.Text == "$100.00", "Price field hasn't been edited.");

            //if (newCode.Text == "code31")
            //{
            //    Assert.Pass("Edited the record, Test passed");
            //    //Console.WriteLine("Record Edited successfully, Test Passed");
            //}
            //else
            //{
            //    Assert.Fail("Not able to edit the record, Test failed");
            //    //Console.WriteLine("Test Failed");
            //}
        }

        public string GetEditedCode(IWebDriver driver)
        {
            IWebElement editedNewCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            return editedNewCode.Text;
        }

        //public string GetEditedTypeCode(IWebDriver driver)
        //{
        //    IWebElement newTypeCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
        //    return newTypeCode.Text;
        //}

        public string GetEditedDescription(IWebDriver driver)
        {
            IWebElement editedNewDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            return editedNewDescription.Text; 
        }
        
        //public string GetEditedPrice(IWebDriver driver)
        //{
        //    IWebElement newPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
        //    return newPrice.Text;
        //}

         public void DeleteTM(IWebDriver driver)
        {

            Thread.Sleep(3000);
            //Identify lastpagebutton and click on it
            IWebElement lastPageButton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageButton1.Click();
            Thread.Sleep(2000);

            IWebElement editedRecord = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            if (editedRecord.Text == "code31")
            {
                //Click on the delete button
                IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));

                deleteButton.Click();
                Thread.Sleep(5000);
                driver.SwitchTo().Alert().Accept();
            }
            else
            {
                Assert.Fail("Record to be deleted hasn't been found", "Record not deleted");
            }
            //Identify Delete button and click on that
            //Thread.Sleep(1000);
            //Wait.WaitToBeClickable(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]", 3);
            //IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));

            //deleteButton.Click();
            //Thread.Sleep(5000);
            //driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
            //driver.FindElement(By.Name("OK")).Click();
            //Thread.Sleep(3000);

            //IAlert alert = driver.SwitchTo().Alert();
            //alert.Accept();

            //Thread.Sleep(4000);

            //Identify lastpagebutton and click on it
            IWebElement lastPageButton2 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageButton2.Click();
            Thread.Sleep(3000);

            

            IWebElement editedCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
            IWebElement editedDescription = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            IWebElement editedPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));


            //Assertion

            Assert.That(editedCode.Text != "code31", "Code field hasn't been deleted");
            Assert.That(editedDescription.Text != "Material31", "Description field hasn't been deleted");
            Assert.That(editedPrice.Text != "$100.00", "Price field hasn't been deleted");
           // //if (codeDetail1.Text == "code31")
           // {
           //     IWebElement tableRowLast = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]"));

           //     tableRowLast.Clear();

           //     //Console.WriteLine("Record deleted successfully. Test Passed");
           //     Assert.Pass("Record deleted successfully , Test passed");
           // }
           //else
           // {
           //     //Console.WriteLine("Record is not able to delete, Test Failed");
           //     Assert.Fail("Not able to find the record, Test Failed");
           // }

            
        }
    }
}
