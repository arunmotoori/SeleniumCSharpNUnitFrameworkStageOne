using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TutorialsNinjaProject.Config;
using TutorialsNinjaProject.Drivers;

namespace TutorialsNinjaProject.Tests
{
    internal class BaseTest
    {

        protected IWebDriver driver;
        private DriverManager driverManager;

        protected dynamic config;
       

        [OneTimeSetUp]
        public void GlobalSetup()
        {
            config = ConfigReader.LoadConfigFile(); // Load configuration ONCE before all tests
        }


        [SetUp]
        public void Setup()
        {
            driverManager = new DriverManager();
            driver = driverManager.InitialiseDriver();
            config = ConfigReader.LoadConfigFile();
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
