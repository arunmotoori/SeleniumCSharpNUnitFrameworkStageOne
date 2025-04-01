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
    internal class LogoutTest : BaseTest
    {
        [Test]
        public void VerifyLoggingOutFromMyAccountDropMenu()
        {

            HomePage homePage = new HomePage(driver);
            homePage.ClickOnMyAccountOption();
            homePage.SelectLoginOption();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterEmail(config.ValidEmail.ToString());
            loginPage.EnterPassword(config.ValidPassword.ToString());
            loginPage.ClickOnLoginButton();
            AccountPage accountPage = new AccountPage(driver);
            accountPage.ClickOnMyAccountDropMenu();
            accountPage.ClickOnMyAccountLogoutOption();
            LogoutPage logoutPage = new LogoutPage(driver);
            Assert.IsTrue(logoutPage.DidWeNavigateToLogoutPage());
            logoutPage.ClickOnContinueButton();
            string expectedTitle = "Your Store";
            Assert.AreEqual(expectedTitle,new ElementUtilities(driver).GetPageTitle());

        }

        [Test]
        public void VerifyLoggingOutFromRightColumnOptions()
        {
            HomePage homePage = new HomePage(driver);
            homePage.ClickOnMyAccountOption();
            homePage.SelectLoginOption();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterEmail(config.ValidEmail.ToString());
            loginPage.EnterPassword((config.ValidPassword.ToString()));
            loginPage.ClickOnLoginButton();
            AccountPage accountPage = new AccountPage(driver);
            accountPage.ClickOnMyAccountLogoutOption();
            LogoutPage logoutPage = new LogoutPage(driver);
            Assert.IsTrue(logoutPage.DidWeNavigateToLogoutPage());
            logoutPage.ClickOnContinueButton();
            string expectedTitle = "Your Store";
            Assert.AreEqual(expectedTitle, new ElementUtilities(driver).GetPageTitle());

        }



    }
}
