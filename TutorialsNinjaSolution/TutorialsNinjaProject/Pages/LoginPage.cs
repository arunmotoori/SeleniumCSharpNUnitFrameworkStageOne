using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TutorialsNinjaProject.Utilities;

namespace TutorialsNinjaProject.Pages
{
    internal class LoginPage
    {
        IWebDriver driver;
        ElementUtilities elementUtilities;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            elementUtilities = new ElementUtilities(driver);
        }

        private IWebElement EmailField => driver.FindElement(By.Id("input-email"));
        private IWebElement PasswordField => driver.FindElement(By.Id("input-password"));

        private IWebElement LoginButton => driver.FindElement(By.CssSelector("input[value='Login']"));

        private IWebElement WarningMessage => driver.FindElement(By.CssSelector("div[class='alert alert-danger alert-dismissible']"));

        public void EnterEmail(string emailText)
        {
            elementUtilities.EnterTextIntoElement(EmailField, emailText);
        }

        public void EnterPassword(string passwordText)
        {
            elementUtilities.EnterTextIntoElement(PasswordField, passwordText);
        }

        public void ClickOnLoginButton()
        {
            elementUtilities.ClickOnElement(LoginButton);
        }

        public string GetWarningMessage()
        {
            return elementUtilities.GetTextFromElement(WarningMessage);
        }















    }
}
