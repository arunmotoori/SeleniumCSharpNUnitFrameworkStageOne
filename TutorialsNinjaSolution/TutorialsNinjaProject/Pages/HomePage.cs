using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TutorialsNinjaProject.Pages
{
    internal class HomePage
    {
        IWebDriver driver;

        public HomePage(IWebDriver driver) {

            this.driver = driver;

        }

        private IWebElement MyAccountOption => driver.FindElement(By.XPath("//span[text()='My Account']"));
        private IWebElement LoginOption => driver.FindElement(By.LinkText("Login"));


        public void ClickOnMyAccountOption()
        {
            MyAccountOption.Click();
        }

        public void SelectLoginOption()
        {
            LoginOption.Click();
        }


    }
}
