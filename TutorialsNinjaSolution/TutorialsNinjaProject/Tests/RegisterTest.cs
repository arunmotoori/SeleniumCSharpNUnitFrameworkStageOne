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
using TutorialsNinjaProject.Pages;
using TutorialsNinjaProject.Utilities;

namespace TutorialsNinjaProject.Tests
{
    [TestFixture]
    internal class RegisterTest : BaseTest
    {
       
        [Test]
        public void VerifyRegisteringAccountWithMandatoryFields()
        {
            HomePage homePage = new HomePage(driver);
            homePage.ClickOnMyAccountOption();
            homePage.SelectRegisterOption();
            RegisterPage registerPage = new RegisterPage(driver);
            registerPage.EnterFirstName(config.FirstName.ToString());
            registerPage.EnterLastName(config.LastName.ToString());
            String email = new CommonMethods().GenerateEmail();
            registerPage.EnterEmail(email);
            registerPage.EnterTelephone(config.TelephoneNumber.ToString());
            registerPage.EnterPassword(config.ValidPassword.ToString());
            registerPage.EnterConfirmPassword(config.ValidPassword.ToString());
            registerPage.SelectPrivacyPolicyField();
            registerPage.ClickOnContinueButton();
            AccountSuccessPage accountSuccessPage = new AccountSuccessPage(driver); 
            Assert.IsTrue(accountSuccessPage.DidWeNavigateToAccountSuccessPage());

        }

        [Test]
        public void VerifyRegisteringAccountWithAllFields()
        {
            HomePage homePage = new HomePage(driver);
            homePage.ClickOnMyAccountOption();
            homePage.SelectRegisterOption();
            RegisterPage registerPage = new RegisterPage(driver);
            registerPage.EnterFirstName(config.FirstName.ToString());
            registerPage.EnterLastName(config.LastName.ToString());
            String email = new CommonMethods().GenerateEmail();
            registerPage.EnterEmail(email);
            registerPage.EnterTelephone(config.TelephoneNumber.ToString());
            registerPage.EnterPassword(config.ValidPassword.ToString());
            registerPage.EnterConfirmPassword(config.ValidPassword.ToString());
            registerPage.SelectYesNewsletterOption();
            registerPage.SelectPrivacyPolicyField();
            registerPage.ClickOnContinueButton();

            AccountSuccessPage accountSuccessPage = new AccountSuccessPage(driver);
            Assert.IsTrue(accountSuccessPage.DidWeNavigateToAccountSuccessPage());

        }


   
    }
}
