using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TutorialsNinjaProject.Tests
{
    internal class SearchTests
    {
        [Test]
        public void VerifySearchingWithExistingProduct()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Url = "https://tutorialsninja.com/demo/";

            driver.FindElement(By.Name("search")).SendKeys("HP");
            driver.FindElement(By.CssSelector("button[class='btn btn-default btn-lg']")).Click();

            Assert.IsTrue(driver.FindElement(By.LinkText("HP LP3065")).Displayed);

            driver.Quit();

        }

        [Test]
        public void VerifySearchingWithANonExistingProduct()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Url = "https://tutorialsninja.com/demo/";

            driver.FindElement(By.Name("search")).SendKeys("Honda");
            driver.FindElement(By.CssSelector("button[class='btn btn-default btn-lg']")).Click();

            string expectedMessage = "There is no product that matches the search criteria.";
            Assert.AreEqual(expectedMessage,driver.FindElement(By.XPath("//div[@id='content']/p[2]")).Text);

            driver.Quit();

        }

        [Test]
        public void VerifySearchingWithoutEnteringAnyProduct()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
            driver.Url = "https://tutorialsninja.com/demo/";

            driver.FindElement(By.CssSelector("button[class='btn btn-default btn-lg']")).Click();

            string expectedMessage = "There is no product that matches the search criteria.";
            Assert.AreEqual(expectedMessage, driver.FindElement(By.XPath("//div[@id='content']/p[2]")).Text);

            driver.Quit();

        }

    }
}
