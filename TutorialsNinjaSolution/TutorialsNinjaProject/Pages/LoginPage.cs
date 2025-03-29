using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TutorialsNinjaProject.Pages
{
    internal class LoginPage
    {
        IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement EmailField => driver.FindElement(By.Id("input-email"));
        private IWebElement PasswordField => driver.FindElement(By.Id("input-password"));

        private IWebElement LoginButton => driver.FindElement(By.CssSelector("input[value='Login']"));

        private IWebElement WarningMessage => driver.FindElement(By.CssSelector("div[class='alert alert-danger alert-dismissible']"));

        public void EnterEmail(string emailText)
        {
            EmailField.SendKeys(emailText);
        }

        public void EnterPassword(string passwordText)
        {
            PasswordField.SendKeys(passwordText);
        }

        public void ClickOnLoginButton()
        {
            LoginButton.Click();
        }

        public string GetWarningMessage()
        {
           return WarningMessage.Text;
        }















    }
}
