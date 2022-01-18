//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using OpenQA.Selenium;
using NUnit.Framework;
using TestingProgram2021.Pages;
using TestingProgram2021.Utilities;
using OpenQA.Selenium.Chrome;



namespace TestingProgram2021.Tests
{
    [TestFixture]
    [Parallelizable]
    class Employee_Tests : CommonDriver
    {



        [Test, Order(1), Description("Check if new employee record is added  with valid data")]

        public void CreateEmployee_Test()
        {

            // Homepage object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            //Employeepage object initialization and definition

            EmployeePage employeeObj = new EmployeePage();
            employeeObj.CreateEmployee(driver);
        }


        [Test, Order(2), Description("Check if user is able to update an existing employee record with an edited data")]
        public void EditEmployee_Test()
        {

            // Homepage object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            //EmployeePage Edit obj definition

            EmployeePage employeeObj = new EmployeePage();
            employeeObj.EditEmployee(driver);
        }

        [Test, Order(3), Description("Check if user is able to delete an existing employee record")]
        public void DeleteEmployee_Test()
        {
            // Homepage object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToEmployeePage(driver);

            //EmployeePage Delete obj definition

            EmployeePage employeeObj = new EmployeePage();
            employeeObj.DeleteEmployee(driver);

        }

    }
}
