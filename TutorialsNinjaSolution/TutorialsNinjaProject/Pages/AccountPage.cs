using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TutorialsNinjaProject.Utilities;

namespace TutorialsNinjaProject.Pages
{
    internal class AccountPage
    {
        IWebDriver driver;
        ElementUtilities elementUtilities;

        public AccountPage(IWebDriver driver)
        {
            this.driver = driver;
            elementUtilities = new ElementUtilities(driver);
        }

        private IWebElement LogoutOption => driver.FindElement(By.LinkText("Logout"));

        private IWebElement MyAccountLogoutOption => driver.FindElement(By.LinkText("Logout"));

        private IWebElement MyAccountDropMenu => driver.FindElement(By.XPath("//span[text()='My Account']"));


        public void ClickOnMyAccountLogoutOption()
        {
            elementUtilities.ClickOnElement(MyAccountLogoutOption);
        }

        public void ClickOnMyAccountDropMenu()
        {
            elementUtilities.ClickOnElement(MyAccountDropMenu);
        }

        public bool IsUserLoggedIn()
        {
            return elementUtilities.IsElementDisplayed(LogoutOption);
        }


    }
}
