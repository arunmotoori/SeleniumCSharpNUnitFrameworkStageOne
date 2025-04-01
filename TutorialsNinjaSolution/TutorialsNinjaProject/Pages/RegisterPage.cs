using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TutorialsNinjaProject.Utilities;

namespace TutorialsNinjaProject.Pages
{
    internal class RegisterPage
    {
        IWebDriver driver;
        ElementUtilities elementUtilities;

        public RegisterPage(IWebDriver driver)
        {
            this.driver = driver;
            elementUtilities = new ElementUtilities(driver);
        }

        private IWebElement FirstNameField => driver.FindElement(By.Id("input-firstname"));

        private IWebElement LastNameField => driver.FindElement(By.Id("input-lastname"));

        private IWebElement EmailField => driver.FindElement(By.Id("input-email"));

        private IWebElement TelephoneField => driver.FindElement(By.Id("input-telephone"));

        private IWebElement PasswordField => driver.FindElement(By.Id("input-password"));

        private IWebElement PasswordConfirmField => driver.FindElement(By.Id("input-confirm"));

        private IWebElement PrivacyPolicyField => driver.FindElement(By.Name("agree"));

        private IWebElement ContinueButton => driver.FindElement(By.CssSelector("input[value='Continue']"));

        private IWebElement YesNewsletterOption => driver.FindElement(By.CssSelector("input[name='newsletter'][value='1']"));

        public void SelectYesNewsletterOption()
        {
            elementUtilities.ClickOnElement(YesNewsletterOption);
        }

        public void ClickOnContinueButton()
        {
            elementUtilities.ClickOnElement(ContinueButton);
        }

        public void SelectPrivacyPolicyField()
        {
            elementUtilities.ClickOnElement(PrivacyPolicyField);
        }

  
        public void EnterConfirmPassword(string passwordText)
        {
            elementUtilities.EnterTextIntoElement(PasswordConfirmField, passwordText);
        }

        public void EnterPassword(string passwordText)
        {
            elementUtilities.EnterTextIntoElement(PasswordField, passwordText);
        }

        public void EnterTelephone(string telephoneText)
        {
            elementUtilities.EnterTextIntoElement(TelephoneField, telephoneText);
        }

        public void EnterEmail(string emailText)
        {
            elementUtilities.EnterTextIntoElement(EmailField, emailText);
        }

        public void EnterLastName(string lastNameText)
        {
            elementUtilities.EnterTextIntoElement(LastNameField, lastNameText);
        }


        public void EnterFirstName(string firstNameText)
        {
            elementUtilities.EnterTextIntoElement(FirstNameField, firstNameText);
        }


    }
}
