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
    internal class RegisterTest : BaseTest
    {
       
        [Test]
        public void VerifyRegisteringAccountWithMandatoryFields()
        {
            driver.FindElement(By.XPath("//span[text()='My Account']")).Click();
            driver.FindElement(By.LinkText("Register")).Click();
            driver.FindElement(By.Id("input-firstname")).SendKeys("Arun");
            driver.FindElement(By.Id("input-lastname")).SendKeys("Motoori");
            String email = GenerateEmail();
            driver.FindElement(By.Id("input-email")).SendKeys(email);
            driver.FindElement(By.Id("input-telephone")).SendKeys("1234567890");
            driver.FindElement(By.Id("input-password")).SendKeys("12345");
            driver.FindElement(By.Id("input-confirm")).SendKeys("12345");
            driver.FindElement(By.Name("agree")).Click();
            driver.FindElement(By.CssSelector("input[value='Continue']")).Click();

            Assert.IsTrue(driver.FindElement(By.XPath("//ul[@class='breadcrumb']//a[text()='Success']")).Displayed);


        }

        [Test]
        public void VerifyRegisteringAccountWithAllFields()
        {
            driver.FindElement(By.XPath("//span[text()='My Account']")).Click();
            driver.FindElement(By.LinkText("Register")).Click();
            driver.FindElement(By.Id("input-firstname")).SendKeys("Arun");
            driver.FindElement(By.Id("input-lastname")).SendKeys("Motoori");
            String email = GenerateEmail();
            driver.FindElement(By.Id("input-email")).SendKeys(email);
            driver.FindElement(By.Id("input-telephone")).SendKeys("1234567890");
            driver.FindElement(By.Id("input-password")).SendKeys("12345");
            driver.FindElement(By.Id("input-confirm")).SendKeys("12345");
            driver.FindElement(By.CssSelector("input[name='newsletter'][value='1']")).Click();
            driver.FindElement(By.Name("agree")).Click();
            driver.FindElement(By.CssSelector("input[value='Continue']")).Click();

            Assert.IsTrue(driver.FindElement(By.XPath("//ul[@class='breadcrumb']//a[text()='Success']")).Displayed);


        }


        public string GenerateEmail()
        {
            string timestamp = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff"); // Generate a timestamp-based unique identifier
            string domain = "example.com"; // Change this to your desired domain
            return $"user{timestamp}@{domain}";
        }

    }
}
