using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using TutorialsNinjaProject.Config;

namespace TutorialsNinjaProject.Drivers
{
    internal class DriverManager
    {
        private IWebDriver driver;

        public IWebDriver InitialiseDriver()
        {
            var config = ConfigReader.LoadConfigFile();
            string browser = config.Browser;

            if (browser == "chrome")
            {
                driver = new ChromeDriver();
            }
            else if (browser == "firefox")
            {
                driver = new FirefoxDriver();
            }
            else if (browser == "edge")
            {
                driver = new EdgeDriver();
            }
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Url = config.URL;

            return driver;

        }

        public void CloseBrowser()
        {
            if (driver != null)
            {
                driver.Quit();
                
            }
            
        }
    }


 }

