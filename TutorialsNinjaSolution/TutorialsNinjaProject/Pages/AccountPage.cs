using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TutorialsNinjaProject.Pages
{
    internal class AccountPage
    {
        IWebDriver driver;

        public AccountPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement LogoutOption => driver.FindElement(By.LinkText("Logout"));

        public bool IsUserLoggedIn()
        {
            return LogoutOption.Displayed;
        }


    }
}
