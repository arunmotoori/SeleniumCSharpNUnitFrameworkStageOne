using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TutorialsNinjaProject.Utilities;

namespace TutorialsNinjaProject.Pages
{
    internal class LogoutPage
    {
        IWebDriver driver;
        ElementUtilities elementUtilities;

        public LogoutPage(IWebDriver driver)
        {
            this.driver = driver;
            elementUtilities = new ElementUtilities(driver);
        }

        private IWebElement LogoutPageBreadcrumb => driver.FindElement(By.XPath("//ul[@class='breadcrumb']//a[text()='Logout']"));

        private IWebElement ContinueButton => driver.FindElement(By.XPath("//a[@class='btn btn-primary'][text()='Continue']"));


        public bool DidWeNavigateToLogoutPage()
        {
            return elementUtilities.IsElementDisplayed(LogoutPageBreadcrumb);
        }

        public void ClickOnContinueButton()
        {
            elementUtilities.ClickOnElement(ContinueButton);
        }

    }
}
