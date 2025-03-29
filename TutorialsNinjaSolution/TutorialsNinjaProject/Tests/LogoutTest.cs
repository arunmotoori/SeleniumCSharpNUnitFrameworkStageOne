using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using TutorialsNinjaProject.Drivers;

namespace TutorialsNinjaProject.Tests
{
    [TestFixture]
    internal class LogoutTest : BaseTest
    {
        [Test]
        public void VerifyLoggingOutFromMyAccountDropMenu()
        {

            driver.FindElement(By.XPath("//span[text()='My Account']")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("input-email")).SendKeys("amotooricap6@gmail.com");
            driver.FindElement(By.Id("input-password")).SendKeys("12345");
            driver.FindElement(By.CssSelector("input[value='Login']")).Click();
            driver.FindElement(By.XPath("//span[text()='My Account']")).Click();
            driver.FindElement(By.LinkText("Logout")).Click();

            Assert.IsTrue(driver.FindElement(By.XPath("//ul[@class='breadcrumb']//a[text()='Logout']")).Displayed);

            driver.FindElement(By.XPath("//a[@class='btn btn-primary'][text()='Continue']")).Click();

            string expectedTitle = "Your Store";

            Assert.AreEqual(expectedTitle,driver.Title);

        }

        [Test]
        public void VerifyLoggingOutFromRightColumnOptions()
        {
            driver.FindElement(By.XPath("//span[text()='My Account']")).Click();
            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.Id("input-email")).SendKeys("amotooricap6@gmail.com");
            driver.FindElement(By.Id("input-password")).SendKeys("12345");
            driver.FindElement(By.CssSelector("input[value='Login']")).Click();
            driver.FindElement(By.XPath("//a[@class='list-group-item'][text()='Logout']")).Click();

            Assert.IsTrue(driver.FindElement(By.XPath("//ul[@class='breadcrumb']//a[text()='Logout']")).Displayed);

            driver.FindElement(By.XPath("//a[@class='btn btn-primary'][text()='Continue']")).Click();

            string expectedTitle = "Your Store";

            Assert.AreEqual(expectedTitle, driver.Title);

            

        }



    }
}
