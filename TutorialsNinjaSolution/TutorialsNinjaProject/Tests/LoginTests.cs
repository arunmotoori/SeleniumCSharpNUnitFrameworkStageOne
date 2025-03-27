using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TutorialsNinjaProject.Tests
{
    internal class LoginTests
    {

        [Test]
        public void VerifyLoginWithValidCredentials()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Url = "https://tutorialsninja.com/demo/";

            driver.FindElement(By.XPath("//span[text()='My Account']")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("input-email")).SendKeys("amotooricap6@gmail.com");
            driver.FindElement(By.Id("input-password")).SendKeys("12345");
            driver.FindElement(By.CssSelector("input[value='Login']")).Click();

            Assert.IsTrue(driver.FindElement(By.LinkText("Logout")).Displayed);
            
            driver.Quit();

        }

        [Test]
        public void VerifyLoginWithInvalidCredentials()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Url = "https://tutorialsninja.com/demo/";

            driver.FindElement(By.XPath("//span[text()='My Account']")).Click();
            driver.FindElement(By.LinkText("Login")).Click();

            driver.FindElement(By.Id("input-email")).SendKeys(GenerateEmail());
            driver.FindElement(By.Id("input-password")).SendKeys("67890");
            driver.FindElement(By.CssSelector("input[value='Login']")).Click();

            String expectedWarningMessage = "Warning: No match for E-Mail Address and/or Password.";
            Assert.AreEqual(expectedWarningMessage,driver.FindElement(By.CssSelector("div[class='alert alert-danger alert-dismissible']")).Text);

            driver.Quit();
        
        }

        [Test]
        public void VerifyLoginWithInvalidEmailAndVaidPassword()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Url = "https://tutorialsninja.com/demo/";

            driver.FindElement(By.XPath("//span[text()='My Account']")).Click();
            driver.FindElement(By.LinkText("Login")).Click();

            driver.FindElement(By.Id("input-email")).SendKeys(GenerateEmail());
            driver.FindElement(By.Id("input-password")).SendKeys("12345");
            driver.FindElement(By.CssSelector("input[value='Login']")).Click();

            String expectedWarningMessage = "Warning: No match for E-Mail Address and/or Password.";
            Assert.AreEqual(expectedWarningMessage, driver.FindElement(By.CssSelector("div[class='alert alert-danger alert-dismissible']")).Text);

            driver.Quit();

        }

        [Test]
        public void VerifyLoginWithValidEmailAndInvaidPassword()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Url = "https://tutorialsninja.com/demo/";

            driver.FindElement(By.XPath("//span[text()='My Account']")).Click();
            driver.FindElement(By.LinkText("Login")).Click();

            driver.FindElement(By.Id("input-email")).SendKeys("amotooricap7@gmail.com");
            driver.FindElement(By.Id("input-password")).SendKeys("67890");
            driver.FindElement(By.CssSelector("input[value='Login']")).Click();

            String expectedWarningMessage = "Warning: No match for E-Mail Address and/or Password.";
            Assert.AreEqual(expectedWarningMessage, driver.FindElement(By.CssSelector("div[class='alert alert-danger alert-dismissible']")).Text);

            driver.Quit();

        }

        [Test]
        public void VerifyLoginWithoutEnteringAnyCredentials()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Url = "https://tutorialsninja.com/demo/";

            driver.FindElement(By.XPath("//span[text()='My Account']")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.CssSelector("input[value='Login']")).Click();

            String expectedWarningMessage = "Warning: No match for E-Mail Address and/or Password.";
            Assert.AreEqual(expectedWarningMessage, driver.FindElement(By.CssSelector("div[class='alert alert-danger alert-dismissible']")).Text);

            driver.Quit();

        }



        public string GenerateEmail()
        {
            string timestamp = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff"); // Generate a timestamp-based unique identifier
            string domain = "example.com"; // Change this to your desired domain
            return $"user{timestamp}@{domain}";
        }



    }
}
