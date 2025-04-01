using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V132.Network;
using TutorialsNinjaProject.Utilities;

namespace TutorialsNinjaProject.Pages
{
    internal class AccountSuccessPage
    {

        IWebDriver driver;
        ElementUtilities elementUtilities;

        public AccountSuccessPage(IWebDriver driver)
        {
            this.driver = driver;
            elementUtilities = new ElementUtilities(driver);
        }

        private IWebElement AccountSuccessBreadcrumb => driver.FindElement(By.XPath("//ul[@class='breadcrumb']//a[text()='Success']"));

        public bool DidWeNavigateToAccountSuccessPage()
        {
            return elementUtilities.IsElementDisplayed(AccountSuccessBreadcrumb);
        }


    }
}
