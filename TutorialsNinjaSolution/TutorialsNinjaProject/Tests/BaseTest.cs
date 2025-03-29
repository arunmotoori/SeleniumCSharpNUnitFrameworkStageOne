using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TutorialsNinjaProject.Drivers;

namespace TutorialsNinjaProject.Tests
{
    internal class BaseTest
    {

        protected IWebDriver driver;
        private DriverManager driverManager;

        [SetUp]
        public void Setup()
        {
            driverManager = new DriverManager();
            driver = driverManager.InitialiseDriver();
        }

        [TearDown]
        public void TearDown()
        {
            driverManager.CloseBrowser();

            if (driver != null)
            {
                driver.Dispose();
            }
        }


    }
}
