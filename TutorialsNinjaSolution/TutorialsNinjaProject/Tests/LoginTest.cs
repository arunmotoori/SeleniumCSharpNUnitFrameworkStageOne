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


namespace TutorialsNinjaProject.Tests
{
    [TestFixture]
    internal class LoginTest : BaseTest
    {

        [Test]
        public void VerifyLoginWithValidCredentials()
        {
            HomePage homePage = new HomePage(driver);
            homePage.ClickOnMyAccountOption();
            homePage.SelectLoginOption();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterEmail("amotooricap6@gmail.com");
            loginPage.EnterPassword("12345");
            loginPage.ClickOnLoginButton();
            AccountPage accountPage = new AccountPage(driver);
            Assert.IsTrue(accountPage.IsUserLoggedIn());

        }

        [Test]
        public void VerifyLoginWithInvalidCredentials()
        {

            HomePage homePage = new HomePage(driver);
            homePage.ClickOnMyAccountOption();
            homePage.SelectLoginOption();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterEmail(GenerateEmail());
            loginPage.EnterPassword("67890");
            loginPage.ClickOnLoginButton();

            String expectedWarningMessage = "Warning: No match for E-Mail Address and/or Password.";
            Assert.AreEqual(expectedWarningMessage,loginPage.GetWarningMessage());

            

        }

        [Test]
        public void VerifyLoginWithInvalidEmailAndVaidPassword()
        {
            HomePage homePage = new HomePage(driver);
            homePage.ClickOnMyAccountOption();
            homePage.SelectLoginOption();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterEmail(GenerateEmail());
            loginPage.EnterPassword("12345");
            loginPage.ClickOnLoginButton();

            String expectedWarningMessage = "Warning: No match for E-Mail Address and/or Password.";
            Assert.AreEqual(expectedWarningMessage, loginPage.GetWarningMessage());

        }

        [Test]
        public void VerifyLoginWithValidEmailAndInvaidPassword()
        {

            HomePage homePage = new HomePage(driver);
            homePage.ClickOnMyAccountOption();
            homePage.SelectLoginOption();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.EnterEmail("amotooricap8@gmail.com");
            loginPage.EnterPassword("67890");
            loginPage.ClickOnLoginButton();

            String expectedWarningMessage = "Warning: No match for E-Mail Address and/or Password.";
            Assert.AreEqual(expectedWarningMessage,loginPage.GetWarningMessage());

      
        }

        [Test]
        public void VerifyLoginWithoutEnteringAnyCredentials()
        {
            HomePage homePage = new HomePage(driver);
            homePage.ClickOnMyAccountOption();
            homePage.SelectLoginOption();
            LoginPage loginPage = new LoginPage(driver);
            loginPage.ClickOnLoginButton();

            String expectedWarningMessage = "Warning: No match for E-Mail Address and/or Password.";
            Assert.AreEqual(expectedWarningMessage, loginPage.GetWarningMessage());


        }



        public string GenerateEmail()
        {
            string timestamp = DateTime.UtcNow.ToString("yyyyMMddHHmmssfff"); // Generate a timestamp-based unique identifier
            string domain = "example.com"; // Change this to your desired domain
            return $"user{timestamp}@{domain}";
        }



    }
}
